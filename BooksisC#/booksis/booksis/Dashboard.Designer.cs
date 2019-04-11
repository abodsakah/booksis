namespace booksis
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblElevId = new System.Windows.Forms.Label();
            this.tbxNamn = new MetroFramework.Controls.MetroTextBox();
            this.tbxKlass = new MetroFramework.Controls.MetroTextBox();
            this.tbxÄmne = new MetroFramework.Controls.MetroTextBox();
            this.tbxBokNamn = new MetroFramework.Controls.MetroTextBox();
            this.tbxBokNummer = new MetroFramework.Controls.MetroTextBox();
            this.tbxBokKostnad = new MetroFramework.Controls.MetroTextBox();
            this.dtpUL = new MetroFramework.Controls.MetroDateTime();
            this.dtpÅL = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKlass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colÄmne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBokensNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBokensnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBokensKostnad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colULDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colÅLDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dashboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLärare = new System.Windows.Forms.Label();
            this.btnUpdateExcel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elvens namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elvens klass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ämne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bokens namn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Utlämnings datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Återlämnings datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bokens kostnad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bokens nummer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(260, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Elvens id: ";
            // 
            // lblElevId
            // 
            this.lblElevId.AutoSize = true;
            this.lblElevId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevId.Location = new System.Drawing.Point(130, 58);
            this.lblElevId.Name = "lblElevId";
            this.lblElevId.Size = new System.Drawing.Size(48, 25);
            this.lblElevId.TabIndex = 2;
            this.lblElevId.Text = "123";
            // 
            // tbxNamn
            // 
            // 
            // 
            // 
            this.tbxNamn.CustomButton.Image = null;
            this.tbxNamn.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tbxNamn.CustomButton.Name = "";
            this.tbxNamn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxNamn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxNamn.CustomButton.TabIndex = 1;
            this.tbxNamn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxNamn.CustomButton.UseSelectable = true;
            this.tbxNamn.CustomButton.Visible = false;
            this.tbxNamn.Lines = new string[0];
            this.tbxNamn.Location = new System.Drawing.Point(17, 125);
            this.tbxNamn.MaxLength = 32767;
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.PasswordChar = '\0';
            this.tbxNamn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxNamn.SelectedText = "";
            this.tbxNamn.SelectionLength = 0;
            this.tbxNamn.SelectionStart = 0;
            this.tbxNamn.ShortcutsEnabled = true;
            this.tbxNamn.Size = new System.Drawing.Size(241, 23);
            this.tbxNamn.TabIndex = 0;
            this.tbxNamn.UseSelectable = true;
            this.tbxNamn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxNamn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxKlass
            // 
            // 
            // 
            // 
            this.tbxKlass.CustomButton.Image = null;
            this.tbxKlass.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tbxKlass.CustomButton.Name = "";
            this.tbxKlass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxKlass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxKlass.CustomButton.TabIndex = 1;
            this.tbxKlass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxKlass.CustomButton.UseSelectable = true;
            this.tbxKlass.CustomButton.Visible = false;
            this.tbxKlass.Lines = new string[0];
            this.tbxKlass.Location = new System.Drawing.Point(17, 172);
            this.tbxKlass.MaxLength = 32767;
            this.tbxKlass.Name = "tbxKlass";
            this.tbxKlass.PasswordChar = '\0';
            this.tbxKlass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxKlass.SelectedText = "";
            this.tbxKlass.SelectionLength = 0;
            this.tbxKlass.SelectionStart = 0;
            this.tbxKlass.ShortcutsEnabled = true;
            this.tbxKlass.Size = new System.Drawing.Size(241, 23);
            this.tbxKlass.TabIndex = 1;
            this.tbxKlass.UseSelectable = true;
            this.tbxKlass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxKlass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxÄmne
            // 
            // 
            // 
            // 
            this.tbxÄmne.CustomButton.Image = null;
            this.tbxÄmne.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tbxÄmne.CustomButton.Name = "";
            this.tbxÄmne.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxÄmne.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxÄmne.CustomButton.TabIndex = 1;
            this.tbxÄmne.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxÄmne.CustomButton.UseSelectable = true;
            this.tbxÄmne.CustomButton.Visible = false;
            this.tbxÄmne.Lines = new string[0];
            this.tbxÄmne.Location = new System.Drawing.Point(17, 223);
            this.tbxÄmne.MaxLength = 32767;
            this.tbxÄmne.Name = "tbxÄmne";
            this.tbxÄmne.PasswordChar = '\0';
            this.tbxÄmne.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxÄmne.SelectedText = "";
            this.tbxÄmne.SelectionLength = 0;
            this.tbxÄmne.SelectionStart = 0;
            this.tbxÄmne.ShortcutsEnabled = true;
            this.tbxÄmne.Size = new System.Drawing.Size(241, 23);
            this.tbxÄmne.TabIndex = 2;
            this.tbxÄmne.UseSelectable = true;
            this.tbxÄmne.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxÄmne.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxBokNamn
            // 
            // 
            // 
            // 
            this.tbxBokNamn.CustomButton.Image = null;
            this.tbxBokNamn.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tbxBokNamn.CustomButton.Name = "";
            this.tbxBokNamn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxBokNamn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxBokNamn.CustomButton.TabIndex = 1;
            this.tbxBokNamn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxBokNamn.CustomButton.UseSelectable = true;
            this.tbxBokNamn.CustomButton.Visible = false;
            this.tbxBokNamn.Lines = new string[0];
            this.tbxBokNamn.Location = new System.Drawing.Point(17, 274);
            this.tbxBokNamn.MaxLength = 32767;
            this.tbxBokNamn.Name = "tbxBokNamn";
            this.tbxBokNamn.PasswordChar = '\0';
            this.tbxBokNamn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxBokNamn.SelectedText = "";
            this.tbxBokNamn.SelectionLength = 0;
            this.tbxBokNamn.SelectionStart = 0;
            this.tbxBokNamn.ShortcutsEnabled = true;
            this.tbxBokNamn.Size = new System.Drawing.Size(241, 23);
            this.tbxBokNamn.TabIndex = 3;
            this.tbxBokNamn.UseSelectable = true;
            this.tbxBokNamn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxBokNamn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxBokNummer
            // 
            // 
            // 
            // 
            this.tbxBokNummer.CustomButton.Image = null;
            this.tbxBokNummer.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tbxBokNummer.CustomButton.Name = "";
            this.tbxBokNummer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxBokNummer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxBokNummer.CustomButton.TabIndex = 1;
            this.tbxBokNummer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxBokNummer.CustomButton.UseSelectable = true;
            this.tbxBokNummer.CustomButton.Visible = false;
            this.tbxBokNummer.Lines = new string[0];
            this.tbxBokNummer.Location = new System.Drawing.Point(17, 328);
            this.tbxBokNummer.MaxLength = 32767;
            this.tbxBokNummer.Name = "tbxBokNummer";
            this.tbxBokNummer.PasswordChar = '\0';
            this.tbxBokNummer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxBokNummer.SelectedText = "";
            this.tbxBokNummer.SelectionLength = 0;
            this.tbxBokNummer.SelectionStart = 0;
            this.tbxBokNummer.ShortcutsEnabled = true;
            this.tbxBokNummer.Size = new System.Drawing.Size(241, 23);
            this.tbxBokNummer.TabIndex = 4;
            this.tbxBokNummer.UseSelectable = true;
            this.tbxBokNummer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxBokNummer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxBokKostnad
            // 
            // 
            // 
            // 
            this.tbxBokKostnad.CustomButton.Image = null;
            this.tbxBokKostnad.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.tbxBokKostnad.CustomButton.Name = "";
            this.tbxBokKostnad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxBokKostnad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxBokKostnad.CustomButton.TabIndex = 1;
            this.tbxBokKostnad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxBokKostnad.CustomButton.UseSelectable = true;
            this.tbxBokKostnad.CustomButton.Visible = false;
            this.tbxBokKostnad.Lines = new string[0];
            this.tbxBokKostnad.Location = new System.Drawing.Point(17, 379);
            this.tbxBokKostnad.MaxLength = 32767;
            this.tbxBokKostnad.Name = "tbxBokKostnad";
            this.tbxBokKostnad.PasswordChar = '\0';
            this.tbxBokKostnad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxBokKostnad.SelectedText = "";
            this.tbxBokKostnad.SelectionLength = 0;
            this.tbxBokKostnad.SelectionStart = 0;
            this.tbxBokKostnad.ShortcutsEnabled = true;
            this.tbxBokKostnad.Size = new System.Drawing.Size(241, 23);
            this.tbxBokKostnad.TabIndex = 5;
            this.tbxBokKostnad.UseSelectable = true;
            this.tbxBokKostnad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxBokKostnad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpUL
            // 
            this.dtpUL.Location = new System.Drawing.Point(17, 434);
            this.dtpUL.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpUL.Name = "dtpUL";
            this.dtpUL.Size = new System.Drawing.Size(241, 29);
            this.dtpUL.TabIndex = 6;
            // 
            // dtpÅL
            // 
            this.dtpÅL.Location = new System.Drawing.Point(17, 503);
            this.dtpÅL.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpÅL.Name = "dtpÅL";
            this.dtpÅL.Size = new System.Drawing.Size(241, 29);
            this.dtpÅL.TabIndex = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 550);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(241, 32);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Lägg till bok";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(17, 588);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(241, 32);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Hämta Rad";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.btnHämta_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(17, 626);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(241, 32);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "Updatera rad";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNamn,
            this.colKlass,
            this.colÄmne,
            this.colBokensNamn,
            this.colBokensnummer,
            this.colBokensKostnad,
            this.colULDatum,
            this.colÅLDatum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(293, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(924, 705);
            this.metroGrid1.TabIndex = 10;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNamn
            // 
            this.colNamn.HeaderText = "Namn";
            this.colNamn.Name = "colNamn";
            this.colNamn.ReadOnly = true;
            // 
            // colKlass
            // 
            this.colKlass.HeaderText = "klass";
            this.colKlass.Name = "colKlass";
            this.colKlass.ReadOnly = true;
            // 
            // colÄmne
            // 
            this.colÄmne.HeaderText = "Ämne";
            this.colÄmne.Name = "colÄmne";
            this.colÄmne.ReadOnly = true;
            // 
            // colBokensNamn
            // 
            this.colBokensNamn.HeaderText = "Bokens namn";
            this.colBokensNamn.Name = "colBokensNamn";
            this.colBokensNamn.ReadOnly = true;
            // 
            // colBokensnummer
            // 
            this.colBokensnummer.HeaderText = "Bokens nummer";
            this.colBokensnummer.Name = "colBokensnummer";
            this.colBokensnummer.ReadOnly = true;
            // 
            // colBokensKostnad
            // 
            this.colBokensKostnad.HeaderText = "Bokens kostnad";
            this.colBokensKostnad.Name = "colBokensKostnad";
            this.colBokensKostnad.ReadOnly = true;
            // 
            // colULDatum
            // 
            this.colULDatum.HeaderText = "Utlämnings datum";
            this.colULDatum.Name = "colULDatum";
            this.colULDatum.ReadOnly = true;
            // 
            // colÅLDatum
            // 
            this.colÅLDatum.HeaderText = "Återlämnings datum";
            this.colÅLDatum.Name = "colÅLDatum";
            this.colÅLDatum.ReadOnly = true;
            // 
            // dashboardBindingSource
            // 
            this.dashboardBindingSource.DataSource = typeof(booksis.Dashboard);
            // 
            // lblLärare
            // 
            this.lblLärare.AutoSize = true;
            this.lblLärare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLärare.Location = new System.Drawing.Point(12, 20);
            this.lblLärare.Name = "lblLärare";
            this.lblLärare.Size = new System.Drawing.Size(67, 25);
            this.lblLärare.TabIndex = 2;
            this.lblLärare.Text = "lärare";
            // 
            // btnUpdateExcel
            // 
            this.btnUpdateExcel.Location = new System.Drawing.Point(17, 664);
            this.btnUpdateExcel.Name = "btnUpdateExcel";
            this.btnUpdateExcel.Size = new System.Drawing.Size(241, 32);
            this.btnUpdateExcel.TabIndex = 9;
            this.btnUpdateExcel.Text = "Updatera Excel";
            this.btnUpdateExcel.UseSelectable = true;
            this.btnUpdateExcel.Click += new System.EventHandler(this.btnUpdateExcel_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 705);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnUpdateExcel);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtpÅL);
            this.Controls.Add(this.dtpUL);
            this.Controls.Add(this.tbxBokKostnad);
            this.Controls.Add(this.tbxBokNummer);
            this.Controls.Add(this.tbxBokNamn);
            this.Controls.Add(this.tbxÄmne);
            this.Controls.Add(this.tbxKlass);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblElevId);
            this.Controls.Add(this.lblLärare);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Booksis dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ämne;
        private System.Windows.Forms.DataGridViewTextBoxColumn utDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn åtDatum;
        private System.Windows.Forms.BindingSource dashboardBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblElevId;
        private MetroFramework.Controls.MetroTextBox tbxNamn;
        private MetroFramework.Controls.MetroTextBox tbxKlass;
        private MetroFramework.Controls.MetroTextBox tbxÄmne;
        private MetroFramework.Controls.MetroTextBox tbxBokNamn;
        private MetroFramework.Controls.MetroTextBox tbxBokNummer;
        private MetroFramework.Controls.MetroTextBox tbxBokKostnad;
        private MetroFramework.Controls.MetroDateTime dtpUL;
        private MetroFramework.Controls.MetroDateTime dtpÅL;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKlass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colÄmne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBokensNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBokensnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBokensKostnad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colULDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colÅLDatum;
        private System.Windows.Forms.Label lblLärare;
        private MetroFramework.Controls.MetroButton btnUpdateExcel;
    }
}