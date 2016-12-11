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
// Do zapisywania/wczytywania plikow
using System.IO;

namespace RPG___Projekt_programowanie_obiektowe
{
    public partial class RPGApp_Okno : Form
    {
        public RPGApp_Okno()
        {
            InitializeComponent();
            this.ActiveControl = Btn_WelcomeScreen;
        }
        string path = @"C:/Users/Admin/AppData/Local/Temp/";
        string nazwaFolderu = "RPG Projekt programowanie obiektowe";
        // Stworzenie bohatera
        Bohater hero = new Bohater("imie bohatera", true, -1);

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
            SchowajMenu();
            // Reszta
            WysunBohater();
        }
        // Wjazd+
        private void Btn_LeftMenuOff_Click(object sender, EventArgs e)
        {
            // Reszta
            SchowajBohater();
            //Menu
            WysunMenu();
        }

        #endregion

        #region Dolne menu


        #endregion

        #region Nowa Gra
        //Nowa Gra
        private void Btn_NowaGra_Click(object sender, EventArgs e)
        {
            // Mozliwosc rozszerzania o kolejne cechy postaci
            TBox_NazwaPostaci.Text = "";
            Rdo_Male.Checked = false;
            Rdo_Female.Checked = false;
            Pic_ChooseAvatar.Image = Resources.Avatar_Unkown1;
            WysunTworzeniePostaci();
        }
        #endregion

        #region Stworz
        // Zmiana plci
        int ktoryAvatar = 0;
        private void Rdo_Male_CheckedChanged(object sender, EventArgs e)
        {
            Pic_ChooseAvatar.Image = Resources.Male1;
            Lbl_CheckPlec.Text = "";
            hero.gender = true;
            ktoryAvatar = 0;
        }
        private void Rdo_Female_CheckedChanged(object sender, EventArgs e)
        {
            Pic_ChooseAvatar.Image = Resources.Female1;
            Lbl_CheckPlec.Text = "";
            hero.gender = false;
            ktoryAvatar = 0;
        }
        // Zmiana avatara
        private void Btn_PrevAvatarView_Click(object sender, EventArgs e)
        {
            if (ktoryAvatar > 0)
                ktoryAvatar--;
            Pic_ChooseAvatar.Image = jakiAvatar(Rdo_Male.Checked, ktoryAvatar);
        }
        private void Btn_NextAvatarView_Click(object sender, EventArgs e)
        {
            if (ktoryAvatar < 2)
                ktoryAvatar++;

            Pic_ChooseAvatar.Image = jakiAvatar(Rdo_Male.Checked, ktoryAvatar);
        }
        // Schemat wyboru avatara
        private System.Drawing.Image jakiAvatar(bool plec, int numer)
        {
            if (plec == true)
            {
                if (numer == 0)
                    return Resources.Male1;
                else if (numer == 1)
                    return Resources.Male2;
                else
                    return Resources.Male3;
            }
            else if (plec == false)
            {
                if (numer == 0)
                    return Resources.Female1;
                else if (numer == 1)
                    return Resources.Female2;
                else
                    return Resources.Female3;
            }
            else
            {
                return Resources.Avatar_Unkown1;
            }
        }

        // Cofnij
        private void Btn_CofnijCreatorPostaci_Click(object sender, EventArgs e)
        {
            SchowajTworzeniePostaci();
        }

        // Sprawdzanie poprawnosci pol creatora postaci
        private void TBox_NazwaPostaci_Leave(object sender, EventArgs e)
        {
            // Sprawdzzanie nazwy postaci
            if (String.IsNullOrEmpty(TBox_NazwaPostaci.Text) || TBox_NazwaPostaci.Text.StartsWith(" ") || TBox_NazwaPostaci.Text.EndsWith(" "))
            {
                if (String.IsNullOrEmpty(TBox_NazwaPostaci.Text) || String.IsNullOrWhiteSpace(TBox_NazwaPostaci.Text))
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
                NowyBohater();
                StworzFolder();
                ZapiszBohatera();
                // Schowanie zawartosci panelu tworzenia postaci
                SchowajTworzeniePostaci();
                // Schowanie Menu gry
                PokazPrzyciskMenu();
                SchowajMenu();
                // Wysunięcie Panelu
                WysunBohater();

            }
        }
        #endregion

        #region Zapisz gre
        private void Btn_ZapiszGre_Click(object sender, EventArgs e)
        {
            ZapiszBohatera();
        }
        #endregion

        #region Wczytaj gre
        private void Btn_WczytajGre_Click(object sender, EventArgs e)
        {
            WczytajBohatera();
        }
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


        #region Zarzadzanie bohaterem
        // Nowy Bohater
        private void NowyBohater()
        {
            hero.name = TBox_NazwaPostaci.Text;
            Lbl_Nick.Text = hero.name;
            hero.gender =Rdo_Male.Checked;
            hero.numerAvatara = ktoryAvatar;
            Pic_Avatar.BackgroundImage =  jakiAvatar(hero.gender, hero.numerAvatara);
            DodajExp(0);
            Ulecz(9999);
            Odpocznij(9999);
            dodajZloto(0);
        }
        // Zapis
        private void StworzFolder()
        {
            string dirPath = path + nazwaFolderu;
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

        }
        private void StworzPlik()
        {
            string tempPath = path + nazwaFolderu + "/" + hero.name + ".txt";
            if (!File.Exists(tempPath))
            {
                FileStream fs = File.Create(tempPath);
                fs.Close();
                fs.Dispose();
            }
        }
        private void ZapiszBohatera()
        {
            string tempPath = path + nazwaFolderu + "/" + hero.name + ".txt";
            if (!File.Exists(tempPath))
            {
                StworzPlik();
            }
            if (File.Exists(tempPath))
            {
                using (StreamWriter zapis = new StreamWriter(tempPath))
                {
                    zapis.WriteLine(hero.name);
                    zapis.WriteLine(hero.gender);
                    zapis.WriteLine(hero.numerAvatara);
                    zapis.WriteLine(hero.doswiadczenie);
                    zapis.WriteLine(hero.poziom);
                    zapis.WriteLine(hero.poziomZdrowia);
                    zapis.WriteLine(hero.maxPoziomZdrowia);
                    zapis.WriteLine(hero.wytrzymalosc);
                    zapis.WriteLine(hero.maxPoziomWytrzymalosc);
                    zapis.WriteLine(hero.zloto);
                    for (int i = 0; i < 16; i++)
                    {
                        zapis.WriteLine(hero.statusMisji[i]);
                    }
                    zapis.Close();
                    zapis.Dispose();
                }
            }
        }
        // Odczyt
        private void WczytajBohatera()
        {

            //using (StreamReader odczyt = new StreamReader(wczytaj))
            //{
            //    hero.name = odczyt.ReadLine();
            //    hero.gender = Convert.ToBoolean(odczyt.ReadLine());
            //    hero.numerAvatara = Convert.ToInt32(odczyt.ReadLine());
            //    hero.doswiadczenie = Convert.ToInt32(odczyt.ReadLine());
            //    hero.poziom = Convert.ToInt32(odczyt.ReadLine());
            //    hero.poziomZdrowia = Convert.ToInt32(odczyt.ReadLine());
            //    hero.maxPoziomZdrowia = Convert.ToInt32(odczyt.ReadLine());
            //    hero.wytrzymalosc = Convert.ToInt32(odczyt.ReadLine());
            //    hero.maxPoziomWytrzymalosc = Convert.ToInt32(odczyt.ReadLine());
            //    hero.zloto = Convert.ToInt32(odczyt.ReadLine());
            //    for (int i = 0; i < 16; i++)
            //    {
            //        hero.statusMisji[i] = Convert.ToInt32(odczyt.ReadLine());
            //    }
            //    odczyt.Close();
            //    odczyt.Dispose();
            //}
        }
        // zarzadzanie doswiadczeniem
        private void DodajExp(int plusExp)
        {
            int exp=Cpb_Exp.Value;
            hero.doswiadczenie = exp;
            if (hero.poziom < 11)
            {
                Cpb_Exp.Maximum = hero.expNaPoziom[hero.poziom - 1];
                Cpb_Exp.Value = hero.doswiadczenie;
                Lbl_Poziom.Text = "Poziom " + Convert.ToString(hero.poziom);
                Lbl_Doswiadczenie.Text = Convert.ToString(Cpb_Exp.Value);
                Lbl_MaxDoswiadczenie.Text = "/ " + Convert.ToString(Cpb_Exp.Maximum);
                exp += plusExp;
                if (exp < hero.expNaPoziom[hero.poziom - 1])
                {
                    Cpb_Exp.Value = exp;
                    Lbl_Doswiadczenie.Text = Convert.ToString(Cpb_Exp.Value);
                }
                else if (exp >= hero.expNaPoziom[hero.poziom - 1])
                {
                    while (exp >= hero.expNaPoziom[hero.poziom - 1])
                    {
                        exp = exp - hero.expNaPoziom[hero.poziom - 1];
                        hero.poziom += 1;
                        if (hero.poziom < 11)
                            Cpb_Exp.Maximum = hero.expNaPoziom[hero.poziom - 1];
                        else
                        {
                            Cpb_Exp.Maximum = 100000;
                            break;
                        }
                    }
                    if (hero.poziom < 11)
                    {
                        Cpb_Exp.Value = exp;
                        Lbl_Poziom.Text = "Poziom " + Convert.ToString(hero.poziom);
                        Lbl_Doswiadczenie.Text = Convert.ToString(Cpb_Exp.Value);
                        Lbl_MaxDoswiadczenie.Text = "/ " + Convert.ToString(Cpb_Exp.Maximum);
                    }
                    else
                    {
                        Lbl_Poziom.Text = "Poziom " + Convert.ToString(hero.poziom - 1);
                        Lbl_Doswiadczenie.Text = "max";
                        Lbl_MaxDoswiadczenie.Text = "/ max";
                        Cpb_Exp.Value = 100000;
                    }
                }
            }

            
        }
        // zarzadzanie zyciem
        private void zadajObrazenia(int obrazenia)
        {
            if ((hero.poziomZdrowia - obrazenia) > 0)
            {
                hero.poziomZdrowia -= obrazenia;
            }
            else
            {
                hero.poziomZdrowia = 0;
            }
            Cpb_Health.Value = hero.poziomZdrowia;
        }
        private void Ulecz(int leczenie)
        {
            if ((hero.poziomZdrowia+leczenie) <= hero.maxPoziomZdrowia)
            {
                hero.poziomZdrowia += leczenie;
            }
            else
            {
                hero.poziomZdrowia = hero.maxPoziomZdrowia;
            }
            Cpb_Health.Value = hero.poziomZdrowia;
        }
        // zarzadzanie wytrzymalosca
        private void Zmeczenie(int zmecz)
        {
            if ((hero.wytrzymalosc -zmecz) > 0)
            {
                hero.wytrzymalosc -= zmecz;
            }
            else
            {
                MessageBox.Show("Brak wytrzymalosci");
            }
            Cpb_Stamina.Value = hero.wytrzymalosc;
        }
        private void Odpocznij(int odpoczynek)
        {
            if((hero.wytrzymalosc)+odpoczynek < hero.maxPoziomWytrzymalosc)
            {
                hero.wytrzymalosc += odpoczynek;
            }
            else
            {
                hero.wytrzymalosc = hero.maxPoziomWytrzymalosc;
                MessageBox.Show("Jestes w pełni wypoczety");
            }
            Cpb_Stamina.Value = hero.wytrzymalosc;
        }
        // zarzadzanie zlotem
        private void dodajZloto(int dodajZloto)
        {
            hero.zloto += dodajZloto;
            Lbl_IloscZlota.Text = Convert.ToString(hero.zloto);
        }
        private void kosztZlota(int koszt)
        {
            dodajZloto(-koszt);
        }

        #endregion

        #region Zarządzanie panelami
        //Paner menu
        private void WysunMenu()
        {
            Util.Animate(Pnl_LeftPanelMenu, Util.Effect.Slide, 5, 0);
            Util.Animate(Btn_LeftMenuOn, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_NowaGra, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_ZapiszGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_WczytajGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Credits, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Wyjscie, Util.Effect.Slide, 125, 0);
        }
        private void SchowajMenu()
        {
            Util.Animate(Btn_NowaGra, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_ZapiszGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_WczytajGre, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Credits, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_Wyjscie, Util.Effect.Slide, 125, 0);
            Util.Animate(Btn_LeftMenuOn, Util.Effect.Slide, 125, 0);
            Util.Animate(Pnl_LeftPanelMenu, Util.Effect.Slide, 5, 0);
        }
        private void PokazPrzyciskMenu()
        {
            if(Btn_LeftMenuOn.Visible == false && Btn_LeftMenuOff.Visible == false)
            {
                Util.Animate(Btn_LeftMenuOn, Util.Effect.Center, 80, 0);
            }
        }
        // Panel tworzenia postaci
        private void WysunTworzeniePostaci()
        {
            if (Pnl_NowaGra.Visible == false)
            {
                // Zapobiega blednemu wysunieciu panelu za pierwszym razem zwiazanego prawdopodobnie z brakiem inicjalizacji na niewidocznym elemencie
                Pnl_NowaGra.Visible = !Pnl_NowaGra.Visible;
                Pnl_NowaGra.Visible = !Pnl_NowaGra.Visible;
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
        private void SchowajTworzeniePostaci()
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
        // Elementy Postaci
        private void WysunBohater()
        {
            if (Btn_LeftMenuOff.Visible == false)
            {
                Util.Animate(Btn_LeftMenuOff, Util.Effect.Slide, 125, 0);
                Util.Animate(Cpb_Exp, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Doswiadczenie, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_MaxDoswiadczenie, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Poziom, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Nick, Util.Effect.Center, 50, 0);
                Util.Animate(Pic_Avatar, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Zdrowie, Util.Effect.Center, 50, 0);
                Util.Animate(Cpb_Health, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Wytrzymalosc, Util.Effect.Center, 50, 0);
                Util.Animate(Cpb_Stamina, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Zloto, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_IloscZlota, Util.Effect.Center, 50, 0);
            }
        }
        private void SchowajBohater()
        {
            if (Btn_LeftMenuOff.Visible == true)
            {
                Util.Animate(Btn_LeftMenuOff, Util.Effect.Slide, 125, 0);
                Util.Animate(Cpb_Exp, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Doswiadczenie, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_MaxDoswiadczenie, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Poziom, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Nick, Util.Effect.Center, 50, 0);
                Util.Animate(Pic_Avatar, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Zdrowie, Util.Effect.Center, 50, 0);
                Util.Animate(Cpb_Health, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Wytrzymalosc, Util.Effect.Center, 50, 0);
                Util.Animate(Cpb_Stamina, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_Zloto, Util.Effect.Center, 50, 0);
                Util.Animate(Lbl_IloscZlota, Util.Effect.Center, 50, 0);
            }
        }

        // 1 Etap gry
        private void WysunEtap1()
        {

        }
        private void SchowajEtap1()
        {

        }
        // 2 Etap gry
        private void WysunEtap2()
        {

        }
        private void SchowajEtap2()
        {

        }
        // 3 Etap gry
        private void WysunEtap3()
        {

        }
        private void SchowajEtap3()
        {

        }
        // 4 Etap gry
        private void WysunEtap4()
        {

        }
        private void SchowajEtap4()
        {

        }
        // 5 Etap gry
        private void WysunEtap5()
        {

        }
        private void SchowajEtap5()
        {

        }
        #endregion
    }
}
