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

        string elevensNamn;
        string elevensKlass;
        string bokensNamn;
        string bokensNummer;
        string bokensKostnad;

        public Dashboard()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM Booksis(namn,klass,kurs,boknamn,boknummer,bokenskostnad,uTdatum,aLDatum) VALUES(@elevensNamn, @elevensKlass, @kurs, @boknamn, @boknummer, @bokKostnad, @utDatum, @atDatum)", conn))
                {

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();

                    this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[0].Cells[1].Value = rdr.GetString(0);
                    this.dataGridView1.Rows[0].Cells[2].Value = rdr.GetString(1);
                }
            }
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
            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("INSERT INTO Booksis(namn,klass,kurs,boknamn,boknummer,bokenskostnad,uTdatum,aLDatum) VALUES('"+tbxName.Text+"','"+tbxKlass.Text+"','"+tbxÄmne.Text+"','"+tbxBokNamn.Text+"','"+tbxBokNummer.Text+"','"+tbxKostnad.Text+"','"+dtpUL.Text+"','"+dtpÅL.Text+"')", conn))
                {
                    try
                    {
                        cmd.ExecuteReader();
                        conn.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
            


    }
}
