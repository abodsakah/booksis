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

            
            lblStatus.Text = "Loggar in....";
            lblStatus.ForeColor = Color.Green;
        }
    }
}
