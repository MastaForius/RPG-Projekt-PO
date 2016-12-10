using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// biblioteka wymagana do pobierania danych zwiazanych z przesuwaniem okna przy pomocy myszy
using System.Runtime.InteropServices;

namespace RPG___Projekt_programowanie_obiektowe
{
    public partial class RPG_MainWindow : Form
    {
        public RPG_MainWindow()
        {
            InitializeComponent();
        }
        // Elementy potrzebne do przesuwania okna oraz wysuwania paneli, zwiazane z biblioteką System.Runtime.InteropServices
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void RPG_MainWindow_Load(object sender, EventArgs e)
        {
            //Automatuczne ladowanie menu
            if (!Pnl_MainLeft.Contains(ucMenu.Instance))
            {
                Pnl_MainLeft.Controls.Add(ucMenu.Instance);
            }
            //test
            if (!Pnl_Ekran.Contains(ucCreatorPostaci.Instance))
            {
                Pnl_Ekran.Controls.Add(ucCreatorPostaci.Instance);
            }
            //
            // Start licznika migania tekstu przy otwarciu okna
            //
            
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;

            timer.Start();
            if (Lbl_PressAnyKeyToContinue.ForeColor == Color.Red)
                timer.Tick += new EventHandler(timer1_Tick);
            else
                timer.Tick -= timer1_Tick;
            Btn_WelcomeScreen.Focus();
            KeyPreview = false;
            KeyPress += new KeyPressEventHandler(PressAnyKeyToContinue);
            MouseClick += new MouseEventHandler(PressAnyKeyToContinue2);
        }

        #region Welcome Screen
        //
        // Funkcja odpowiadajaca za miganie tekstu
        // 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Lbl_PressAnyKeyToContinue.ForeColor == Color.Red)
                Lbl_PressAnyKeyToContinue.ForeColor = Color.Maroon;
            else
                Lbl_PressAnyKeyToContinue.ForeColor = Color.Red;
        }
        private void Btn_WelcomeScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        private void Btn_WelcomeScreen_MouseClick(object sender, MouseEventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        private void Btn_WelcomeScreen_Click(object sender, EventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        private void Lbl_TyulWelcomeScreen_Click(object sender, EventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        private void Lbl_PressAnyKeyToContinue_Click(object sender, EventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        private void PressAnyKeyToContinue(object sender, KeyPressEventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        private void PressAnyKeyToContinue2(object sender, MouseEventArgs e)
        {
            Pnl_WelcomeScreen.Visible = false;
            timer1.Stop();
        }
        #endregion

        #region Zachowania okna
        // Elementy ktorymi mozna przesuwac okno
        private void Pnl_TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Lbl_Tytul_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // Minimalizacja okna
        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Zamkniecie okna
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funkcja wysuwania menu/ paneli
        // Algorytm wysuwanego menu
        public static class Util
        {
            public enum Effect { Roll, Slide, Center, Blend }

            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];
                if (ctl.Visible) { flags |= 0x10000; angle += 180; }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }
                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animation failed");
                ctl.Visible = !ctl.Visible;
            }

            private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]
            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        }


        #endregion

        #region Zarzadzanie przejsciami
        //Nowa Gra
        bool czyNowaGraPierwszyRaz = true;
        public void WysunCreatorPostaci()
        {
            // Mozliwosc rozszerzania o kolejne cechy postaci
            if (ucCreatorPostaci.Instance.Pnl_CreatorPostaci.Visible == false)
            {
                // Resetowanie elementow tworzenia postaci
                ucCreatorPostaci.Instance.Pic_ChooseAvatar.Image = Properties.Resources.Avatar_Unkown1;
                ucCreatorPostaci.Instance.TBox_NazwaPostaci.Text = "";
                ucCreatorPostaci.Instance.Rdo_Male.Checked = false;
                ucCreatorPostaci.Instance.Rdo_Female.Checked = false;
                // Zapobiega blednemu wysunieciu panelu za pierwszym razem zwiazanego prawdopodobnie z brakiem inicjalizacji na niewidocznym elemencie
                if (czyNowaGraPierwszyRaz == true)
                {
                    ucCreatorPostaci.Instance.Pnl_CreatorPostaci.Visible = !ucCreatorPostaci.Instance.Pnl_CreatorPostaci.Visible;
                    ucCreatorPostaci.Instance.Pnl_CreatorPostaci.Visible = !ucCreatorPostaci.Instance.Pnl_CreatorPostaci.Visible;
                    czyNowaGraPierwszyRaz = false;
                }
                // Wysuniecie panelu tworzenia postaci
                Util.Animate(ucCreatorPostaci.Instance.Pnl_CreatorPostaci, Util.Effect.Slide, 250, 180);
                // Wysuniecie zawartosci panelu
                Util.Animate(ucCreatorPostaci.Instance.TBox_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Lbl_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Rdo_Female, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Rdo_Male, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Lbl_Plec, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Lbl_WygladPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_NextAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Pic_ChooseAvatar, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_PrevAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_StworzPostac, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_CofnijCreatorPostaci, Util.Effect.Center, 80, 180);
                // Schowanie reszty jeśli widoczna
            }
        }
        public void SchowajCreatorPostaci()
        {   
            if (ucCreatorPostaci.Instance.Pnl_CreatorPostaci.Visible == true)
            {
                // Schowanie zawartosci panelu
                Util.Animate(ucCreatorPostaci.Instance.TBox_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Lbl_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Rdo_Female, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Rdo_Male, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Lbl_Plec, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Lbl_WygladPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_NextAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Pic_ChooseAvatar, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_PrevAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_StworzPostac, Util.Effect.Center, 80, 180);
                Util.Animate(ucCreatorPostaci.Instance.Btn_CofnijCreatorPostaci, Util.Effect.Center, 80, 180);
                // Schowanie panelu tworzenia postaci
                Util.Animate(ucCreatorPostaci.Instance.Pnl_CreatorPostaci, Util.Effect.Slide, 250, 180);
            }
        }
        #endregion
    }
}
