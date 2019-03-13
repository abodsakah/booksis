using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace booksis
{


    public partial class Dashboard : Form
    {

        Random rnd = new Random();
        int id;

        string elevensNamn;
        string elevensKlass;
        string bokensNamn;
        string bokensNummer;
        string bokensKostnad;

        public Dashboard()
        {
            InitializeComponent();
            importInfo();
            lblElevId.Text = null;
        }

        public void updateDB()
        {
            using(var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using(var cmd = new SQLiteCommand("SELECT ", conn))
                {

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            id = rnd.Next(8000);

            dataGridView1.Rows.Clear();

            if (tbxName.Text != null && tbxKlass.Text != null && tbxÄmne.Text != null && tbxBokNamn.Text != null && tbxBokNummer.Text != null && tbxKostnad.Text != null)
            {

                using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO Booksis(id,namn,klass,kurs,boknamn,boknummer,bokenskostnad,uTdatum,aLDatum) VALUES('"+id+"','" + tbxName.Text + "','" + tbxKlass.Text + "','" + tbxÄmne.Text + "','" + tbxBokNamn.Text + "','" + tbxBokNummer.Text + "','" + tbxKostnad.Text + " kr" + "','" + dtpUL.Text + "','" + dtpÅL.Text + "')", conn))
                    {
                        try
                        {
                            cmd.ExecuteReader();
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }

            importInfo();
        }



        void importInfo()
        {
            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM Booksis", conn))
                {

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        dataGridView1.Rows.Add(new object[]
                            {
                            rdr.GetValue(rdr.GetOrdinal("id")),
                            rdr.GetValue(rdr.GetOrdinal("namn")),
                            rdr.GetValue(rdr.GetOrdinal("klass")),
                            rdr.GetValue(rdr.GetOrdinal("kurs")),
                            rdr.GetValue(rdr.GetOrdinal("boknamn")),
                            rdr.GetValue(rdr.GetOrdinal("boknummer")),
                            rdr.GetValue(rdr.GetOrdinal("bokenskostnad")),
                            rdr.GetValue(rdr.GetOrdinal("uTdatum")),
                            rdr.GetValue(rdr.GetOrdinal("aLDatum"))
                            });

                    }

                }
            }
        }

        private void btnHämta_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                lblElevId.Text = row.Cells[0].Value.ToString();
                tbxName.Text = row.Cells[1].Value.ToString();
                tbxKlass.Text = row.Cells[2].Value.ToString();
                tbxÄmne.Text = row.Cells[3].Value.ToString();
                tbxBokNamn.Text = row.Cells[4].Value.ToString();
                tbxBokNummer.Text = row.Cells[5].Value.ToString();
                tbxKostnad.Text = row.Cells[6].Value.ToString();
                dtpUL.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                dtpÅL.Value = Convert.ToDateTime(row.Cells[8].Value.ToString());

            }
 

        }

        private void label9_Click(object sender, EventArgs e)
        {
            lblElevId.Text = null;
            tbxName.Clear();
            tbxÄmne.Clear();
            tbxKostnad.Clear();
            tbxKlass.Clear();
            tbxBokNummer.Clear();
            tbxBokNamn.Clear();
            dtpUL.Value = DateTime.Now;
            dtpÅL.Value = DateTime.Now;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpÅL.Enabled = checkBox1.Checked;
        }

 
    
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //find the row id


            //update row id in DB

            //update grid
        }
    }
}
