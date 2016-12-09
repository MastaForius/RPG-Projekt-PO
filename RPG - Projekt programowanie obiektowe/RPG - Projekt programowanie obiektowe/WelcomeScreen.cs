using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG___Projekt_programowanie_obiektowe
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();

        }
        //
        // Funkcja odpowiadajaca za miganie tekstu
        // 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Lbl_PressAnyToContinue.ForeColor == Color.Red)
                Lbl_PressAnyToContinue.ForeColor = Color.Maroon;
            else
                Lbl_PressAnyToContinue.ForeColor = Color.Red;
        }

        private void MenuWelcome_Load(object sender, EventArgs e)
        {
            //
            // Start licznika migania tekstu przy otwarciu okna
            //
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;

            timer.Start();
            if (Lbl_PressAnyToContinue.ForeColor == Color.Red)
                timer.Tick += new EventHandler(timer1_Tick);
            else
                timer.Tick -= timer1_Tick;

            this.KeyPreview = false;
            this.KeyPress += new KeyPressEventHandler(PressAnyKeyToContinue);
            this.MouseClick += new MouseEventHandler(PressAnyKeyToContinue2);
        }

        private void PressAnyKeyToContinue(object sender, KeyPressEventArgs e)
        {
            this.Close();           
        }
        private void PressAnyKeyToContinue2(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void WelcomeScreen_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
