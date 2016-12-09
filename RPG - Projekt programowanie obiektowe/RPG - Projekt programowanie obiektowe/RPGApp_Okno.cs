using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// biblioteka wymagana do pobierania danych zwiazanych z przesuwaniem okna przy pomocy myszy
using System.Runtime.InteropServices;
using RPG___Projekt_programowanie_obiektowe.Properties;

namespace RPG___Projekt_programowanie_obiektowe
{
    public partial class RPGApp_Okno : Form
    {
        public RPGApp_Okno()
        {
            InitializeComponent();
            this.ActiveControl = Btn_WelcomeScreen;
        }

        #region Funkcja wysuwania menu/ paneli
        // Algorytm wysuwanego menu
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            //
            // Start licznika migania tekstu przy otwarciu okna
            //
            Btn_WelcomeScreen.Focus();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;

            timer.Start();
            if (Lbl_PressAnyKeyToContinue.ForeColor == Color.Red)
                timer.Tick += new EventHandler(timer1_Tick);
            else
                timer.Tick -= timer1_Tick;

            KeyPreview = false;
            KeyPress += new KeyPressEventHandler(PressAnyKeyToContinue);
            MouseClick += new MouseEventHandler(PressAnyKeyToContinue2);
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

        #region Lewe menu

        // Lewe Menu
        // Zjazd
        private void Btn_LeftMenuOn_Click(object sender, EventArgs e)
        {
            //Menu
            Util.Animate(Btn_NowaGra, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_ZapiszGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_WczytajGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Credits, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Wyjscie, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_LeftMenuOn, Util.Effect.Slide, 125, 0);
            Util.Animate(Pnl_LeftPanelMenu, Util.Effect.Slide, 5, 0);
            Util.Animate(Btn_LeftMenuOff, Util.Effect.Slide, 125, 0);
            // Reszta
            Util.Animate(Cpb_Exp, Util.Effect.Slide, 125, 0);
            Util.Animate(Pic_Avatar, Util.Effect.Slide, 125, 0);
        }
        // Wjazd+
        private void Btn_LeftMenuOff_Click(object sender, EventArgs e)
        {
            // Reszta
            Util.Animate(Pic_Avatar, Util.Effect.Slide, 125, 180);
            Util.Animate(Cpb_Exp, Util.Effect.Slide, 125, 180);
            //Menu
            Util.Animate(Btn_LeftMenuOff, Util.Effect.Slide, 125, 0);
            Util.Animate(Pnl_LeftPanelMenu, Util.Effect.Slide, 5, 0);
            Util.Animate(Btn_LeftMenuOn, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_NowaGra, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_ZapiszGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_WczytajGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Credits, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Wyjscie, Util.Effect.Slide, 125, 0);
        }

        #endregion

        #region Dolne menu


        #endregion

        #region Nowa Gra
        //Nowa Gra
        bool czyNowaGraPierwszyRaz = true;
        private void Btn_NowaGra_Click(object sender, EventArgs e)
        {
            // Mozliwosc rozszerzania o kolejne cechy postaci
            if (Pnl_NowaGra.Visible == false)
            {
                // Resetowanie elementow tworzenia postaci
                Pic_ChooseAvatar.Image = Resources.Avatar_Unkown1;
                TBox_NazwaPostaci.Text = "";
                Rdo_Male.Checked = false;
                Rdo_Female.Checked = false;
                // Zapobiega blednemu wysunieciu panelu za pierwszym razem zwiazanego prawdopodobnie z brakiem inicjalizacji na niewidocznym elemencie
                if (czyNowaGraPierwszyRaz == true)
                {
                    Pnl_NowaGra.Visible = !Pnl_NowaGra.Visible;
                    Pnl_NowaGra.Visible = !Pnl_NowaGra.Visible;
                    czyNowaGraPierwszyRaz = false;
                }
                // Wysuniecie panelu tworzenia postaci
                Util.Animate(Pnl_NowaGra, Util.Effect.Slide, 250, 180);
                // Wysuniecie zawartosci panelu
                Util.Animate(TBox_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Rdo_Female, Util.Effect.Center, 80, 180);
                Util.Animate(Rdo_Male, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_Plec, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_WygladPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_NextAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(Pic_ChooseAvatar, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_PrevAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_StworzPostac, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_CofnijCreatorPostaci, Util.Effect.Center, 80, 180);
                // Schowanie reszty jeśli widoczna
            }
        }
        // Zmiana plci
        int ktoryMaleAvatar = 0;
        int ktoryFemaleAvatar = 0;
        private void Rdo_Male_CheckedChanged(object sender, EventArgs e)
        {
            Pic_ChooseAvatar.Image = Resources.Male1;
            Lbl_CheckPlec.Text = "";
            ktoryMaleAvatar = 0;
        }
        private void Rdo_Female_CheckedChanged(object sender, EventArgs e)
        {
            Pic_ChooseAvatar.Image = Resources.Female1;
            Lbl_CheckPlec.Text = "";
            ktoryFemaleAvatar = 0;
        }
        // Zmiana avatara
        private void Btn_PrevAvatarView_Click(object sender, EventArgs e)
        {
            if (ktoryMaleAvatar > 0 && Rdo_Male.Checked == true)
                ktoryMaleAvatar--;
            if (ktoryFemaleAvatar > 0 && Rdo_Female.Checked == true)
                ktoryFemaleAvatar--;

            if (Rdo_Male.Checked == true)
            {
                if (ktoryMaleAvatar == 0)
                    Pic_ChooseAvatar.Image = Resources.Male1;
                else if (ktoryMaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Resources.Male2;
                else
                    Pic_ChooseAvatar.Image = Resources.Male3;
            }
            else if(Rdo_Female.Checked == true)
            {
                if (ktoryFemaleAvatar == 0)
                    Pic_ChooseAvatar.Image = Resources.Female1;
                else if (ktoryFemaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Resources.Female2;
                else
                    Pic_ChooseAvatar.Image = Resources.Female3;
            }
        }
        private void Btn_NextAvatarView_Click(object sender, EventArgs e)
        {
            if (ktoryMaleAvatar < 2 && Rdo_Male.Checked == true)
                ktoryMaleAvatar++;
            if (ktoryFemaleAvatar < 2 && Rdo_Female.Checked == true)
                ktoryFemaleAvatar++;

            if (Rdo_Male.Checked == true)
            {
                if (ktoryMaleAvatar == 0)
                    Pic_ChooseAvatar.Image = Resources.Male1;
                else if (ktoryMaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Resources.Male2;
                else
                    Pic_ChooseAvatar.Image = Resources.Male3;
            }
            else if (Rdo_Female.Checked == true)
            {
                if (ktoryFemaleAvatar == 0)
                    Pic_ChooseAvatar.Image = Resources.Female1;
                else if (ktoryFemaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Resources.Female2;
                else
                    Pic_ChooseAvatar.Image = Resources.Female3;
            }
        }

        #endregion

            #region Cofnij
        private void Btn_CofnijCreatorPostaci_Click(object sender, EventArgs e)
        {
            if (Pnl_NowaGra.Visible == true)
            {
                // Schowanie zawartosci panelu
                Util.Animate(TBox_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Rdo_Female, Util.Effect.Center, 80, 180);
                Util.Animate(Rdo_Male, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_Plec, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_WygladPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_NextAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(Pic_ChooseAvatar, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_PrevAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_StworzPostac, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_CofnijCreatorPostaci, Util.Effect.Center, 80, 180);
                // Schowanie panelu tworzenia postaci
                Util.Animate(Pnl_NowaGra, Util.Effect.Slide, 250, 180);
            }
        }
        #endregion

            #region Stworz
        // Sprawdzanie poprawnosci pol creatora postaci
        private void TBox_NazwaPostaci_Leave(object sender, EventArgs e)
        {
            // Sprawdzzanie nazwy postaci
            if (String.IsNullOrEmpty(TBox_NazwaPostaci.Text) || TBox_NazwaPostaci.Text.StartsWith(" ") || TBox_NazwaPostaci.Text.EndsWith(" "))
            {
                if (String.IsNullOrEmpty(TBox_NazwaPostaci.Text) || String.IsNullOrWhiteSpace(TBox_NazwaPostaci.Text)) ;
                Lbl_CheckNazwaPostaci.Text = "Nie podano nazwy postaci";
                if (TBox_NazwaPostaci.Text.Contains(" "))
                {
                    if (TBox_NazwaPostaci.Text.StartsWith(" "))
                        Lbl_CheckNazwaPostaci.Text = "Nazwa postaci nie może\nzaczynać się od 'spacji'";
                    else if (TBox_NazwaPostaci.Text.EndsWith(" "))
                        Lbl_CheckNazwaPostaci.Text = "Nazwa postaci nie może\nkończyć się 'spacją'";
                }
            }
            else
                Lbl_CheckNazwaPostaci.Text = "";

        }
        private void Btn_StworzPostac_Click(object sender, EventArgs e)
        {
            // Sprawdzzanie wymagan stworzenia postaci
            if (String.IsNullOrEmpty(TBox_NazwaPostaci.Text) || TBox_NazwaPostaci.Text.StartsWith(" ") || TBox_NazwaPostaci.Text.EndsWith(" "))
            {
                MessageBox.Show("Błędna nazwa postaci");            
            }
            else if (Rdo_Male.Checked == false && Rdo_Female.Checked == false)
            {
                Lbl_CheckPlec.Text = "Nie wybrano płóci\noraz\nwyglądu postaci";
            }
            else
            {
                // Zapisanie postaci




                // Schowanie zawartosci panelu tworzenia postaci
                Util.Animate(TBox_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_NazwaPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Rdo_Female, Util.Effect.Center, 80, 180);
                Util.Animate(Rdo_Male, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_Plec, Util.Effect.Center, 80, 180);
                Util.Animate(Lbl_WygladPostaci, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_NextAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(Pic_ChooseAvatar, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_PrevAvatarView, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_StworzPostac, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_CofnijCreatorPostaci, Util.Effect.Center, 80, 180);
                // Schowanie panelu tworzenia postaci
                Util.Animate(Pnl_NowaGra, Util.Effect.Slide, 250, 180);
                // Schowanie Menu gry
                Util.Animate(Btn_NowaGra, Util.Effect.Slide, 125, 0);
                Util.Animate(Btn_ZapiszGre, Util.Effect.Slide, 125, 0);
                Util.Animate(Btn_WczytajGre, Util.Effect.Slide, 125, 0);
                Util.Animate(Btn_Credits, Util.Effect.Slide, 125, 0);
                Util.Animate(Btn_Wyjscie, Util.Effect.Slide, 125, 0);
                Util.Animate(Pnl_LeftPanelMenu, Util.Effect.Slide, 250, 0);
                // Wysunięcie Panelu
                Util.Animate(Btn_LeftMenuOff, Util.Effect.Slide, 125, 0);
                Util.Animate(Cpb_Exp, Util.Effect.Slide, 125, 0);
                Util.Animate(Pic_Avatar, Util.Effect.Slide, 125, 0);

            }
        }
        #endregion

        #region Zapisz gre

        #endregion

        #region Wczytaj gre

        #endregion

        #region Credits
        // Credits
        private void Btn_Credits_Click(object sender, EventArgs e)
        {
            CreditsInfo credits = new CreditsInfo();
            credits.Show();
        }
        #endregion

        #region Wyjscie
        // Wyjscie
        private void Btn_Wyjscie_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        #endregion
    }
}
