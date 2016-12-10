using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG___Projekt_programowanie_obiektowe
{
    public partial class ucCreatorPostaci : UserControl
    {
        // Pozwala na dostęp z innego poziomu
        private static ucCreatorPostaci _instance;
        public static ucCreatorPostaci Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCreatorPostaci();
                return _instance;
            }
        }
        public ucCreatorPostaci()
        {
            InitializeComponent();
        }
        #region Sprawdzanie podczas tworzenia postaci
        // Zmiana plci
        int ktoryMaleAvatar = 0;
        int ktoryFemaleAvatar = 0;
        private void Rdo_Male_CheckedChanged(object sender, EventArgs e)
        {
            Pic_ChooseAvatar.Image = Properties.Resources.Male1;
            Lbl_CheckPlec.Text = "";
            ktoryMaleAvatar = 0;
        }
        private void Rdo_Female_CheckedChanged(object sender, EventArgs e)
        {
            Pic_ChooseAvatar.Image = Properties.Resources.Female1;
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
                    Pic_ChooseAvatar.Image = Properties.Resources.Male1;
                else if (ktoryMaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Properties.Resources.Male2;
                else
                    Pic_ChooseAvatar.Image = Properties.Resources.Male3;
            }
            else if (Rdo_Female.Checked == true)
            {
                if (ktoryFemaleAvatar == 0)
                    Pic_ChooseAvatar.Image = Properties.Resources.Female1;
                else if (ktoryFemaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Properties.Resources.Female2;
                else
                    Pic_ChooseAvatar.Image = Properties.Resources.Female3;
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
                    Pic_ChooseAvatar.Image = Properties.Resources.Male1;
                else if (ktoryMaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Properties.Resources.Male2;
                else
                    Pic_ChooseAvatar.Image = Properties.Resources.Male3;
            }
            else if (Rdo_Female.Checked == true)
            {
                if (ktoryFemaleAvatar == 0)
                    Pic_ChooseAvatar.Image = Properties.Resources.Female1;
                else if (ktoryFemaleAvatar == 1)
                    Pic_ChooseAvatar.Image = Properties.Resources.Female2;
                else
                    Pic_ChooseAvatar.Image = Properties.Resources.Female3;
            }
        }
        #endregion

        #region Cofnij
        private void Btn_CofnijCreatorPostaci_Click(object sender, EventArgs e)
        {
                ((RPG_MainWindow)TopLevelControl).SchowajCreatorPostaci();
        }
        #endregion

        #region Stworz
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
                MessageBox.Show("Błędna przy tworzeniu postaci");
            }
            else if (Rdo_Male.Checked == false && Rdo_Female.Checked == false)
            {
                Lbl_CheckPlec.Text = "Nie wybrano płóci\noraz\nwyglądu postaci";
            }
            else
            {
                //// Zapisanie postaci




                //// Schowanie zawartosci panelu tworzenia postaci
                //Util.Animate(TBox_NazwaPostaci, Util.Effect.Center, 80, 180);
                //Util.Animate(Lbl_NazwaPostaci, Util.Effect.Center, 80, 180);
                //Util.Animate(Rdo_Female, Util.Effect.Center, 80, 180);
                //Util.Animate(Rdo_Male, Util.Effect.Center, 80, 180);
                //Util.Animate(Lbl_Plec, Util.Effect.Center, 80, 180);
                //Util.Animate(Lbl_WygladPostaci, Util.Effect.Center, 80, 180);
                //Util.Animate(Btn_NextAvatarView, Util.Effect.Center, 80, 180);
                //Util.Animate(Pic_ChooseAvatar, Util.Effect.Center, 80, 180);
                //Util.Animate(Btn_PrevAvatarView, Util.Effect.Center, 80, 180);
                //Util.Animate(Btn_StworzPostac, Util.Effect.Center, 80, 180);
                //Util.Animate(Btn_CofnijCreatorPostaci, Util.Effect.Center, 80, 180);
                //// Schowanie panelu tworzenia postaci
                //Util.Animate(Pnl_CreatorPostaci, Util.Effect.Slide, 250, 180);
                //// Schowanie Menu gry
                //Util.Animate(Btn_NowaGra, Util.Effect.Slide, 125, 0);
                //Util.Animate(Btn_ZapiszGre, Util.Effect.Slide, 125, 0);
                //Util.Animate(Btn_WczytajGre, Util.Effect.Slide, 125, 0);
                //Util.Animate(Btn_Credits, Util.Effect.Slide, 125, 0);
                //Util.Animate(Btn_Wyjscie, Util.Effect.Slide, 125, 0);
                //Util.Animate(Pnl_LeftPanelMenu, Util.Effect.Slide, 250, 0);
                //// Wysunięcie Panelu
                //Util.Animate(Btn_LeftMenuOff, Util.Effect.Slide, 125, 0);
                //Util.Animate(Cpb_Exp, Util.Effect.Slide, 125, 0);
                //Util.Animate(Pic_Avatar, Util.Effect.Slide, 125, 0);

            }
        }
        #endregion
    }
}
