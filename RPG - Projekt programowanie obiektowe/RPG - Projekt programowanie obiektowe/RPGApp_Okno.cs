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
        string path = System.IO.Path.GetTempPath() + "/";
        string nazwaFolderu = "RPG Projekt programowanie obiektowe";
        // Stworzenie bohatera
        Bohater hero = new Bohater("Domyslny bohater gry", true, -1);

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
        private void Btn_Odpocznij_Click(object sender, EventArgs e)
        {
            Odpocznij(hero.poziom * 5);
        }

        private void Btn_Zaleczrany_Click(object sender, EventArgs e)
        {
            Ulecz(hero.poziom * 2);
        }

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
                WysunEkranGry();
                WysunEtap1();
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
        // Zachowanie okienka
        private void Pnl_TytulWczytajGre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Lbl_Wczytaj_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // Wywołanie okna
        private void Btn_WczytajGre_Click(object sender, EventArgs e)
        {
            if (Pnl_WczytajGre.Visible == false)
            {
                Pnl_WczytajGre.Visible = !Pnl_WczytajGre.Visible;
                Pnl_WczytajGre.Visible = !Pnl_WczytajGre.Visible;
                Util.Animate(Pnl_WczytajGre, Util.Effect.Center, 100, 0);
            }
        }
        // Sprawdzenie czy istnieje taki bohater
        private void Btn_OtworzZapis_Click(object sender, EventArgs e)
        {
            WczytajBohatera(TBox_WczytajGre.Text);
        }
        // Zamkniecie okna
        private void ZamknijWczytywanieGry_Click(object sender, EventArgs e)
        {
            if (Pnl_WczytajGre.Visible == true)
            {
                Util.Animate(Pnl_WczytajGre, Util.Effect.Center, 100, 0);
            }
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
        //
        // Zbiór funkcji odpowiedzialnych za zmieny obiektu klasy bohater
        //



        // Nowy Bohater
        private void NowyBohater()
        {
            hero.name = TBox_NazwaPostaci.Text;
            Lbl_Nick.Text = hero.name;
            hero.gender =Rdo_Male.Checked;
            hero.numerAvatara = ktoryAvatar;
            Pic_Avatar.BackgroundImage =  jakiAvatar(hero.gender, hero.numerAvatara);
            DodajExp(0);
            Ulecz(0);
            Odpocznij(0);
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
        private void WczytajBohatera(string fileName)
        {
            string tempPath = path + nazwaFolderu + "/" + fileName + ".txt";
            if (File.Exists(tempPath))
            {
                using (StreamReader odczyt = new StreamReader(tempPath))
                {
                    hero.name = odczyt.ReadLine();
                    hero.gender = Convert.ToBoolean(odczyt.ReadLine());
                    hero.numerAvatara = Convert.ToInt32(odczyt.ReadLine());
                    hero.doswiadczenie = Convert.ToInt32(odczyt.ReadLine());
                    hero.poziom = Convert.ToInt32(odczyt.ReadLine());
                    hero.poziomZdrowia = Convert.ToInt32(odczyt.ReadLine());
                    hero.maxPoziomZdrowia = Convert.ToInt32(odczyt.ReadLine());
                    hero.wytrzymalosc = Convert.ToInt32(odczyt.ReadLine());
                    hero.maxPoziomWytrzymalosc = Convert.ToInt32(odczyt.ReadLine());
                    hero.zloto = Convert.ToInt32(odczyt.ReadLine());
                    for (int i = 0; i < 16; i++)
                    {
                        hero.statusMisji[i] = Convert.ToInt32(odczyt.ReadLine());
                    }
                    odczyt.Close();
                    odczyt.Dispose();
                }
                MessageBox.Show("Wczytano postać " +fileName);
                TBox_WczytajGre.Text = "";
                
                // Schowanie paneli
                if (Pnl_WczytajGre.Visible == true)
                {
                    Util.Animate(Pnl_WczytajGre, Util.Effect.Center, 100, 0);
                }
                PokazPrzyciskMenu();
                SchowajMenu();
                // Załadowanie panelu bohatera
                DodajExp(hero.doswiadczenie);
                Lbl_Nick.Text = hero.name;
                Pic_Avatar.BackgroundImage = jakiAvatar(hero.gender, hero.numerAvatara);
                Ulecz(0);
                Odpocznij(0);
                dodajZloto(0);
                // Wysuniecie paneli
                WysunBohater();
            }
            else
            {
                MessageBox.Show("Nie poprawna nazwa postaci lub brak pliku zapisu na tym komputerze");
                TBox_WczytajGre.Text = "";
            }
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
                if (MessageBox.Show("Przegrałeś. :-(", "Czy chcesz spróbować jeszcze raz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // otwieroa nowe okno aplikacji
                    this.Close(); // zamyka stare okno aplikacji
                }
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
                if (Pnl_LeftGame.Visible)
                {
                    MessageBox.Show("Zostałeś uleczony do pełna");
                }
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
                MessageBox.Show("Brak wytrzymalosci, otrzymujesz obrazenia");
                zadajObrazenia(hero.poziom*5);
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
                if (Pnl_LeftGame.Visible)
                {
                    MessageBox.Show("Jestes w pełni wypoczety");
                }
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
        //
        // Sekcja do zarzadzania przejciami pomiedzy panelami
        //


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
            if (Pnl_CreatorPostaci.Visible == false)
            {
                // Zapobiega blednemu wysunieciu panelu za pierwszym razem zwiazanego prawdopodobnie z brakiem inicjalizacji na niewidocznym elemencie
                Pnl_CreatorPostaci.Visible = !Pnl_CreatorPostaci.Visible;
                Pnl_CreatorPostaci.Visible = !Pnl_CreatorPostaci.Visible;
                // Wysuniecie panelu tworzenia postaci
                Util.Animate(Pnl_CreatorPostaci, Util.Effect.Slide, 250, 180);
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
            if (Pnl_CreatorPostaci.Visible == true)
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
                Util.Animate(Pnl_CreatorPostaci, Util.Effect.Slide, 250, 180);
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



        // Wysun ekran gre
        private void WysunEkranGry()
        {
            Pnl_Etapy.Visible = !Pnl_Etapy.Visible;
            Pnl_Etapy.Visible = !Pnl_Etapy.Visible;
            if (!Pnl_Etapy.Visible)
            {
                Util.Animate(Pnl_Etapy, Util.Effect.Slide, 125, 180);
            }
        }
        // Schowaj ekran gre
        private void SchowajEkranGry()
        {
            if (Pnl_Etapy.Visible)
            {
                Util.Animate(Pnl_Etapy, Util.Effect.Slide, 125, 180);
            }
        }

        // 1 Etap gry
        private void WysunEtap1()
        {
            if (!Pnl_Etap1.Visible)
            {
                Util.Animate(Pnl_Etap1, Util.Effect.Slide, 125, 180);
                Util.Animate(TBox_Etap1_1, Util.Effect.Center, 80, 180);
                Util.Animate(Pnl_ButtonsE1, Util.Effect.Slide, 125, 180);
                Util.Animate(Btn_Etap1_1, Util.Effect.Center, 80, 180);
            }
        }
        private void SchowajEtap1()
        {
            if (Pnl_Etap1.Visible)
            {
                Util.Animate(Pnl_Etap1, Util.Effect.Slide, 125, 180);
                Util.Animate(Pnl_ButtonsE1, Util.Effect.Slide, 125, 180);
            }
        }
        private void Btn_Etap1_1_Click(object sender, EventArgs e)
        {
            if (!Btn_Etap1_2.Visible)
            {
                Util.Animate(TBox_Etap1_2, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_Etap1_2, Util.Effect.Center, 80, 180);
                Zmeczenie(5);
            }
        }
        private void Btn_Etap1_2_Click(object sender, EventArgs e)
        {
            if (!Btn_Etap1_3.Visible)
            {
                DodajExp(40);
                dodajZloto(50);
                zadajObrazenia(15);
                Zmeczenie(10);
                MessageBox.Show("Znalazłeś Miecz!");
                Util.Animate(TBox_Etap1_3, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_Etap1_3, Util.Effect.Center, 80, 180);
            }
        }
        private void Btn_Etap1_3_Click(object sender, EventArgs e)
        {
            if (!Btn_Etap1_4.Visible)
            {
                Util.Animate(TBox_Etap1_4, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_Etap1_4, Util.Effect.Center, 80, 180);
            }
        }
        private void Btn_Etap1_4_Click(object sender, EventArgs e)
        {
            Zmeczenie(40);
            SchowajEtap1();
            WysunEtap2();
        }

        // 2 Etap gry
        private void WysunEtap2()
        {
            if (!Pnl_Etap2.Visible)
            {
                Util.Animate(Pnl_Etap2, Util.Effect.Slide, 125, 180);
                Util.Animate(TBox_Etap2_1, Util.Effect.Center, 80, 180);
                Util.Animate(Pnl_ButtonsE2, Util.Effect.Slide, 125, 180);
                Util.Animate(Btn_Etap2_1, Util.Effect.Center, 80, 180);
                Ulecz(20);
                Odpocznij(35);
            }
        }
        private void SchowajEtap2()
        {
            if (Pnl_Etap2.Visible)
            {
                Util.Animate(Pnl_Etap2, Util.Effect.Slide, 125, 180);
                Util.Animate(Pnl_ButtonsE2, Util.Effect.Slide, 125, 180);
            }
        }
        private void Btn_Etap2_1_Click(object sender, EventArgs e)
        {
            Util.Animate(TBox_Etap2_2, Util.Effect.Center, 80, 180);
            Util.Animate(Btn_Etap2_2, Util.Effect.Center, 80, 180);
            zadajObrazenia(20);
        }
        private void Btn_Etap2_2_Click(object sender, EventArgs e)
        {
            Util.Animate(TBox_Etap2_3, Util.Effect.Center, 80, 180);
            Util.Animate(Btn_Etap2_3, Util.Effect.Center, 80, 180);
            DodajExp(5);
            Zmeczenie(35);
            Ulecz(15);
        }
        private void Btn_Etap2_3_Click(object sender, EventArgs e)
        {
            Util.Animate(TBox_Etap2_4, Util.Effect.Center, 80, 180);
            Util.Animate(Btn_Etap2_4, Util.Effect.Center, 80, 180);
            Zmeczenie(20);
            zadajObrazenia(40);
            DodajExp(50);
            dodajZloto(5);
        }
        private void Btn_Etap2_4_Click(object sender, EventArgs e)
        {
            Zmeczenie(60);
            SchowajEtap2();
            WysunEtap3();
        }

        // 3 Etap gry
        private void WysunEtap3()
        {
            if (!Pnl_Etap3.Visible)
            {
                Util.Animate(Pnl_Etap3, Util.Effect.Slide, 125, 180);
                Util.Animate(TBox_Etap3_1, Util.Effect.Center, 80, 180);
                Util.Animate(Pnl_ButtonsE3, Util.Effect.Slide, 125, 180);
                Util.Animate(Btn_Etap3_1, Util.Effect.Center, 80, 180);
                Odpocznij(10);
                DodajExp(100);
            }
        }
        private void SchowajEtap3()
        {
            if (Pnl_Etap3.Visible)
            {
                Util.Animate(Pnl_Etap3, Util.Effect.Slide, 125, 180);
                Util.Animate(Pnl_ButtonsE3, Util.Effect.Slide, 125, 180);
            }
        }
        private void Btn_Etap3_1_Click(object sender, EventArgs e)
        {
            SchowajEtap3();
            WysunEtap4();
        }




        // 4 Etap gry
        private void WysunEtap4()
        {
            if (!Pnl_Etap4.Visible)
            {
                Util.Animate(Pnl_Etap4, Util.Effect.Slide, 125, 180);
                Util.Animate(TBox_Etap4_1, Util.Effect.Center, 80, 180);
                Util.Animate(Pnl_ButtonsE4, Util.Effect.Slide, 125, 180);
                Util.Animate(Btn_Etap4_1, Util.Effect.Center, 80, 180);
            }
        }
        private void SchowajEtap4()
        {
            if (!Pnl_Etap4.Visible)
            {
                Util.Animate(Pnl_Etap4, Util.Effect.Slide, 125, 180);
                Util.Animate(Pnl_ButtonsE4, Util.Effect.Slide, 125, 180);
            }
        }

        private void Btn_Etap4_1_Click(object sender, EventArgs e)
        {
            if (!TBox_Etap4_2.Visible)
            {
                Util.Animate(TBox_Etap4_2, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_Etap4_2, Util.Effect.Center, 80, 180);
                Zmeczenie(10);
                DodajExp(10);
                hero.maxPoziomZdrowia += hero.maxPoziomZdrowia + 50;
                Cpb_Health.Maximum = hero.maxPoziomZdrowia;
            }

        }

        private void Btn_Etap4_2_Click(object sender, EventArgs e)
        {
            if (!TBox_Etap4_3.Visible)
            {
                SchowajEtap4();
                WysunEtap5();

                Zmeczenie(60);
                DodajExp(300);
                zadajObrazenia(40);
            }
        }

        private void Btn_Etap4_4_Click(object sender, EventArgs e)
        {
            Wygrana();
        }

        private void Btn_Etap4_3_Click(object sender, EventArgs e)
        {

        }
        // 5 Etap gry
        private void WysunEtap5()
        {
            if (!Pnl_Etap5.Visible)
            {
                Util.Animate(Pnl_Etap5, Util.Effect.Slide, 125, 180);
                Util.Animate(TBox_Etap5_1, Util.Effect.Center, 80, 180);
                Util.Animate(Pnl_ButtonsE5, Util.Effect.Slide, 125, 180);
                Util.Animate(Btn_Etap5_1, Util.Effect.Center, 80, 180);
            }
            Zmeczenie(40);
            DodajExp(30);
        }
        private void SchowajEtap5()
        {
            if (!Pnl_Etap5.Visible)
            {
                Util.Animate(Pnl_Etap5, Util.Effect.Slide, 125, 180);
                Util.Animate(Pnl_ButtonsE5, Util.Effect.Slide, 125, 180);
            }
        }

        private void Btn_Etap5_1_Click(object sender, EventArgs e)
        {
            if (!Btn_Etap5_2.Visible)
            {
                Util.Animate(TBox_Etap5_2, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_Etap5_2, Util.Effect.Center, 80, 180);
                Zmeczenie(40);
                zadajObrazenia(10);
                DodajExp(200);
            }
        }

        private void Btn_Etap5_2_Click(object sender, EventArgs e)
        {
            Util.Animate(TBox_Etap5_3, Util.Effect.Center, 80, 180);
            Util.Animate(Btn_Etap5_3, Util.Effect.Center, 80, 180);
            DodajExp(600);
            dodajZloto(4000);
            zadajObrazenia(80);
        }

        private void Btn_Etap5_4_Click(object sender, EventArgs e)
        {
            SchowajEtap5();
            WysunEtap4();
            if (!TBox_Etap4_4.Visible)
            {
                Util.Animate(TBox_Etap4_4, Util.Effect.Center, 80, 180);
                Util.Animate(Btn_Etap4_4, Util.Effect.Center, 80, 180);
            }
            Zmeczenie(20);
            DodajExp(400);
            dodajZloto(10);
        }

        //
        // Ciąg dalszy nastąpi ...
        //



        //Wygrana
        public void Wygrana()
        {
            MessageBox.Show("Braow wygrałeś! Niedługo czeka cię dłuższa przygoda, do zobaczenia następnym razem :-)");
        }

        #endregion
    }
}
