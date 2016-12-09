using System.Windows.Forms;

namespace RPG___Projekt_programowanie_obiektowe
{
    partial class WelcomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Tytul = new System.Windows.Forms.Label();
            this.Lbl_PressAnyToContinue = new System.Windows.Forms.Label();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_Tytul
            // 
            this.Lbl_Tytul.AutoSize = true;
            this.Lbl_Tytul.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tytul.Font = new System.Drawing.Font("Segoe Print", 28F, System.Drawing.FontStyle.Bold);
            this.Lbl_Tytul.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Tytul.Location = new System.Drawing.Point(102, 25);
            this.Lbl_Tytul.Name = "Lbl_Tytul";
            this.Lbl_Tytul.Size = new System.Drawing.Size(820, 68);
            this.Lbl_Tytul.TabIndex = 0;
            this.Lbl_Tytul.Text = "RPG - projekt programowanie obiektowe";
            // 
            // Lbl_PressAnyToContinue
            // 
            this.Lbl_PressAnyToContinue.AutoSize = true;
            this.Lbl_PressAnyToContinue.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_PressAnyToContinue.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.Lbl_PressAnyToContinue.ForeColor = System.Drawing.Color.Red;
            this.Lbl_PressAnyToContinue.Location = new System.Drawing.Point(172, 336);
            this.Lbl_PressAnyToContinue.Name = "Lbl_PressAnyToContinue";
            this.Lbl_PressAnyToContinue.Size = new System.Drawing.Size(679, 47);
            this.Lbl_PressAnyToContinue.TabIndex = 1;
            this.Lbl_PressAnyToContinue.Text = "- Naciśnij dowolny przycisk aby kontynuować -";
            // 
            // MyPanel
            // 
            this.MyPanel.Location = new System.Drawing.Point(246, 188);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(315, 126);
            this.MyPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(133, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(649, 151);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(661, 456);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(249, 506);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(391, 69);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 45;
            // 
            // WelcomeScreen
            // 
            this.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Kraty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MyPanel);
            this.Controls.Add(this.Lbl_Tytul);
            this.Controls.Add(this.Lbl_PressAnyToContinue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.Load += new System.EventHandler(this.MenuWelcome_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WelcomeScreen_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tytul;
        private System.Windows.Forms.Label Lbl_PressAnyToContinue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel MyPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private KeyPressEventHandler MyPanelPress;
    }
}