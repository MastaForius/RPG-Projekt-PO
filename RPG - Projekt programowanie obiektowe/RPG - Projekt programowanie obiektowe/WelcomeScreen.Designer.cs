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
            this.Lbl_PressAnyToContinue.Click += new System.EventHandler(this.Lbl_PressAnyToContinue_Click);
            // 
            // WelcomeScreen
            // 
            this.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Kraty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.Lbl_Tytul);
            this.Controls.Add(this.Lbl_PressAnyToContinue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.Load += new System.EventHandler(this.MenuWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tytul;
        private System.Windows.Forms.Label Lbl_PressAnyToContinue;
        private System.Windows.Forms.Timer timer1;
    }
}