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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string roll = "";

            if(cbRoll.Text == "admin")
            {
                roll = "admin";
            }else if (cbRoll.Text == "lärare")
            {
                roll = "teacher";
            }

            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("INSERT INTO login(username,password,role) VALUES('"+tbxUser.Text+"', '"+tbxPass.Text+"', '"+roll+"')", conn))
                {
                    try
                    {
                        cmd.ExecuteReader();
                        conn.Close();
                        MessageBox.Show("användaren läggs till", "succe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            string roll = "";

            if (cbRole.Text == "admin")
            {
                roll = "admin";
            }
            else if (cbRole.Text == "lärare")
            {
                roll = "teacher";
            }

            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("update login set password='"+tbxLösen.Text+ "',role='"+roll+"'  where username= '" + tbxNamn.Text+"'", conn))
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


    }
}
