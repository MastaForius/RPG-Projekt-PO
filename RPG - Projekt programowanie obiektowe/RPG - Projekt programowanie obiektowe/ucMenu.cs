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
    public partial class ucMenu : UserControl
    {
        // Pozwala na dostęp z innego poziomu
        private static ucMenu _instance;
        public static ucMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMenu();
                return _instance;
            }
        }
        public ucMenu()
        {
            InitializeComponent();
        }
        private void Btn_LeftMenuOn_Click(object sender, EventArgs e)
        {

        }

        private void Btn_NowaGra_Click(object sender, EventArgs e)
        {
            ((RPG_MainWindow)TopLevelControl).WysunCreatorPostaci();
        }

        private void Btn_ZapiszGre_Click(object sender, EventArgs e)
        {

        }

        private void Btn_WczytajGre_Click(object sender, EventArgs e)
        {

        }

        #region Credits
        private void Btn_Credits_Click(object sender, EventArgs e)
        {
            CreditsInfo credits = new CreditsInfo();
            credits.Show();
        }
        #endregion

        private void Btn_Wyjscie_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Close();
        }
    }
}
