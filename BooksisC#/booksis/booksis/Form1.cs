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
    public partial class Form1 : Form
    {
        // the connection port to sqlite
        SQLiteConnection dbConnection;


        public Form1()
        {
            InitializeComponent();
            //the domain of the port
            dbConnection = new SQLiteConnection("Data Source=booksis.sqlite; Version=3");
            //opening the connection to the port
            dbConnection.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT username,password FROM login WHERE username='"+this.tbxUser.Text+ "' AND password = '" + this.tbxPass.Text +"'", conn))
                    {

                        using(var reader = cmd.ExecuteReader())
                        {
                            var count = 0;
                            while (reader.Read())
                            {
                                count = count += 1;
                            }
                            if(count == 1)
                            {
                                MessageBox.Show("login..");
                            }
                            else if (count == 0)
                            {
                                lblStatus.Text = "felaktig information!";
                                lblStatus.ForeColor = Color.Red;
                            }
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loadData();
            }
        }
    }
}
