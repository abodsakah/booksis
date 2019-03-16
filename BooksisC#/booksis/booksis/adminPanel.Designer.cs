namespace booksis
{
    partial class adminPanel
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbRoll = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxUser = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cbRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbxLösen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbxNamn = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 450);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.cbRoll);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.tbxPass);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tbxUser);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Lägg till användare";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(9, 186);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(245, 30);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "lägg till användare";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cbRoll
            // 
            this.cbRoll.FormattingEnabled = true;
            this.cbRoll.ItemHeight = 23;
            this.cbRoll.Items.AddRange(new object[] {
            "admin",
            "lärare"});
            this.cbRoll.Location = new System.Drawing.Point(9, 136);
            this.cbRoll.Name = "cbRoll";
            this.cbRoll.Size = new System.Drawing.Size(245, 29);
            this.cbRoll.TabIndex = 2;
            this.cbRoll.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "roll";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Lösenord";
            // 
            // tbxPass
            // 
            // 
            // 
            // 
            this.tbxPass.CustomButton.Image = null;
            this.tbxPass.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.tbxPass.CustomButton.Name = "";
            this.tbxPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPass.CustomButton.TabIndex = 1;
            this.tbxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPass.CustomButton.UseSelectable = true;
            this.tbxPass.CustomButton.Visible = false;
            this.tbxPass.Lines = new string[0];
            this.tbxPass.Location = new System.Drawing.Point(8, 87);
            this.tbxPass.MaxLength = 32767;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '•';
            this.tbxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPass.SelectedText = "";
            this.tbxPass.SelectionLength = 0;
            this.tbxPass.SelectionStart = 0;
            this.tbxPass.ShortcutsEnabled = true;
            this.tbxPass.Size = new System.Drawing.Size(246, 23);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.UseSelectable = true;
            this.tbxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Användernamn";
            // 
            // tbxUser
            // 
            // 
            // 
            // 
            this.tbxUser.CustomButton.Image = null;
            this.tbxUser.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.tbxUser.CustomButton.Name = "";
            this.tbxUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxUser.CustomButton.TabIndex = 1;
            this.tbxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxUser.CustomButton.UseSelectable = true;
            this.tbxUser.CustomButton.Visible = false;
            this.tbxUser.Lines = new string[0];
            this.tbxUser.Location = new System.Drawing.Point(8, 39);
            this.tbxUser.MaxLength = 32767;
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.PasswordChar = '\0';
            this.tbxUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUser.SelectedText = "";
            this.tbxUser.SelectionLength = 0;
            this.tbxUser.SelectionStart = 0;
            this.tbxUser.ShortcutsEnabled = true;
            this.tbxUser.Size = new System.Drawing.Size(246, 23);
            this.tbxUser.TabIndex = 0;
            this.tbxUser.UseSelectable = true;
            this.tbxUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.cbRole);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.tbxLösen);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.tbxNamn);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 408);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Ändra lösenord";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.ItemHeight = 23;
            this.cbRole.Items.AddRange(new object[] {
            "admin",
            "lärare"});
            this.cbRole.Location = new System.Drawing.Point(8, 134);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(245, 29);
            this.cbRole.TabIndex = 9;
            this.cbRole.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(28, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "roll";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(8, 169);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(245, 32);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Uppdatera";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 63);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Nya lösenordet";
            // 
            // tbxLösen
            // 
            // 
            // 
            // 
            this.tbxLösen.CustomButton.Image = null;
            this.tbxLösen.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.tbxLösen.CustomButton.Name = "";
            this.tbxLösen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxLösen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxLösen.CustomButton.TabIndex = 1;
            this.tbxLösen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxLösen.CustomButton.UseSelectable = true;
            this.tbxLösen.CustomButton.Visible = false;
            this.tbxLösen.Lines = new string[0];
            this.tbxLösen.Location = new System.Drawing.Point(8, 85);
            this.tbxLösen.MaxLength = 32767;
            this.tbxLösen.Name = "tbxLösen";
            this.tbxLösen.PasswordChar = '•';
            this.tbxLösen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxLösen.SelectedText = "";
            this.tbxLösen.SelectionLength = 0;
            this.tbxLösen.SelectionStart = 0;
            this.tbxLösen.ShortcutsEnabled = true;
            this.tbxLösen.Size = new System.Drawing.Size(246, 23);
            this.tbxLösen.TabIndex = 5;
            this.tbxLösen.UseSelectable = true;
            this.tbxLösen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxLösen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 15);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Användernamn";
            // 
            // tbxNamn
            // 
            // 
            // 
            // 
            this.tbxNamn.CustomButton.Image = null;
            this.tbxNamn.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.tbxNamn.CustomButton.Name = "";
            this.tbxNamn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxNamn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxNamn.CustomButton.TabIndex = 1;
            this.tbxNamn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxNamn.CustomButton.UseSelectable = true;
            this.tbxNamn.CustomButton.Visible = false;
            this.tbxNamn.Lines = new string[0];
            this.tbxNamn.Location = new System.Drawing.Point(8, 37);
            this.tbxNamn.MaxLength = 32767;
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.PasswordChar = '\0';
            this.tbxNamn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxNamn.SelectedText = "";
            this.tbxNamn.SelectionLength = 0;
            this.tbxNamn.SelectionStart = 0;
            this.tbxNamn.ShortcutsEnabled = true;
            this.tbxNamn.Size = new System.Drawing.Size(246, 23);
            this.tbxNamn.TabIndex = 4;
            this.tbxNamn.UseSelectable = true;
            this.tbxNamn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxNamn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox cbRoll;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxUser;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbxLösen;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbxNamn;
        private MetroFramework.Controls.MetroComboBox cbRole;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}