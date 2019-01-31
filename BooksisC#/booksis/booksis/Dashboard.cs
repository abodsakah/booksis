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
        public Dashboard()
        {
            InitializeComponent();
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
