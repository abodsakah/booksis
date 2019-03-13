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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKlass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxÄmne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBokNamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpUL = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpÅL = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxKostnad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxBokNummer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHämta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bokNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bokNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bokKostnad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ütDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblElevId = new System.Windows.Forms.Label();
            this.dashboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(13, 124);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(245, 20);
            this.tbxName.TabIndex = 0;
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
            // tbxKlass
            // 
            this.tbxKlass.Location = new System.Drawing.Point(13, 175);
            this.tbxKlass.Name = "tbxKlass";
            this.tbxKlass.Size = new System.Drawing.Size(245, 20);
            this.tbxKlass.TabIndex = 1;
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
            // tbxÄmne
            // 
            this.tbxÄmne.Location = new System.Drawing.Point(13, 226);
            this.tbxÄmne.Name = "tbxÄmne";
            this.tbxÄmne.Size = new System.Drawing.Size(245, 20);
            this.tbxÄmne.TabIndex = 2;
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
            // tbxBokNamn
            // 
            this.tbxBokNamn.Location = new System.Drawing.Point(13, 277);
            this.tbxBokNamn.Name = "tbxBokNamn";
            this.tbxBokNamn.Size = new System.Drawing.Size(245, 20);
            this.tbxBokNamn.TabIndex = 3;
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
            // dtpUL
            // 
            this.dtpUL.Location = new System.Drawing.Point(13, 434);
            this.dtpUL.Name = "dtpUL";
            this.dtpUL.Size = new System.Drawing.Size(245, 20);
            this.dtpUL.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Återlämnings datum";
            // 
            // dtpÅL
            // 
            this.dtpÅL.Enabled = false;
            this.dtpÅL.Location = new System.Drawing.Point(13, 520);
            this.dtpÅL.Name = "dtpÅL";
            this.dtpÅL.Size = new System.Drawing.Size(245, 20);
            this.dtpÅL.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 558);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(246, 67);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "lägg till bok";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxKostnad
            // 
            this.tbxKostnad.Location = new System.Drawing.Point(13, 379);
            this.tbxKostnad.Name = "tbxKostnad";
            this.tbxKostnad.Size = new System.Drawing.Size(245, 20);
            this.tbxKostnad.TabIndex = 5;
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
            // tbxBokNummer
            // 
            this.tbxBokNummer.Location = new System.Drawing.Point(13, 328);
            this.tbxBokNummer.Name = "tbxBokNummer";
            this.tbxBokNummer.Size = new System.Drawing.Size(245, 20);
            this.tbxBokNummer.TabIndex = 4;
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
            // btnHämta
            // 
            this.btnHämta.BackColor = System.Drawing.Color.Blue;
            this.btnHämta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHämta.FlatAppearance.BorderSize = 0;
            this.btnHämta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHämta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHämta.Location = new System.Drawing.Point(12, 631);
            this.btnHämta.Name = "btnHämta";
            this.btnHämta.Size = new System.Drawing.Size(246, 67);
            this.btnHämta.TabIndex = 9;
            this.btnHämta.Text = "Hämta information";
            this.btnHämta.UseVisualStyleBackColor = false;
            this.btnHämta.Click += new System.EventHandler(this.btnHämta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 777);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 67);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exportera till Excel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namn,
            this.Klass,
            this.Amne,
            this.bokNamn,
            this.bokNummer,
            this.bokKostnad,
            this.ütDatum,
            this.atDatum});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(293, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(936, 849);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Namn
            // 
            this.Namn.DividerWidth = 1;
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            // 
            // Klass
            // 
            this.Klass.DividerWidth = 1;
            this.Klass.HeaderText = "Klass";
            this.Klass.Name = "Klass";
            this.Klass.ReadOnly = true;
            // 
            // Amne
            // 
            this.Amne.DividerWidth = 1;
            this.Amne.HeaderText = "Ämne";
            this.Amne.Name = "Amne";
            this.Amne.ReadOnly = true;
            // 
            // bokNamn
            // 
            this.bokNamn.DividerWidth = 1;
            this.bokNamn.HeaderText = "Bokens namn";
            this.bokNamn.Name = "bokNamn";
            this.bokNamn.ReadOnly = true;
            // 
            // bokNummer
            // 
            this.bokNummer.DividerWidth = 1;
            this.bokNummer.HeaderText = "Bokens nummer";
            this.bokNummer.Name = "bokNummer";
            this.bokNummer.ReadOnly = true;
            // 
            // bokKostnad
            // 
            this.bokKostnad.DividerWidth = 1;
            this.bokKostnad.HeaderText = "Bokens kostnad";
            this.bokKostnad.Name = "bokKostnad";
            this.bokKostnad.ReadOnly = true;
            // 
            // ütDatum
            // 
            this.ütDatum.DividerWidth = 1;
            this.ütDatum.HeaderText = "Utlämnings datum";
            this.ütDatum.Name = "ütDatum";
            this.ütDatum.ReadOnly = true;
            // 
            // atDatum
            // 
            this.atDatum.DividerWidth = 1;
            this.atDatum.HeaderText = "Återlämnings datum";
            this.atDatum.Name = "atDatum";
            this.atDatum.ReadOnly = true;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 460);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 29);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Inlämnad";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.lblElevId.Location = new System.Drawing.Point(130, 66);
            this.lblElevId.Name = "lblElevId";
            this.lblElevId.Size = new System.Drawing.Size(48, 25);
            this.lblElevId.TabIndex = 2;
            this.lblElevId.Text = "123";
            // 
            // dashboardBindingSource
            // 
            this.dashboardBindingSource.DataSource = typeof(booksis.Dashboard);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(12, 704);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(246, 67);
            this.btnUpdateInfo.TabIndex = 9;
            this.btnUpdateInfo.Text = "Uppdatera rad";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 849);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnHämta);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpÅL);
            this.Controls.Add(this.dtpUL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxKostnad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxBokNummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBokNamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxÄmne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKlass);
            this.Controls.Add(this.lblElevId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Booksis dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKlass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxÄmne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBokNamn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpUL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpÅL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxKostnad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxBokNummer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ämne;
        private System.Windows.Forms.DataGridViewTextBoxColumn utDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn åtDatum;
        private System.Windows.Forms.Button btnHämta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dashboardBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amne;
        private System.Windows.Forms.DataGridViewTextBoxColumn bokNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bokNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bokKostnad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ütDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn atDatum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblElevId;
        private System.Windows.Forms.Button btnUpdateInfo;
    }
}