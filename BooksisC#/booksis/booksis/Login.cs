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
using System.Runtime.InteropServices;

namespace booksis
{
    public partial class Login : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public bool isLogedin;

        // the connection port to sqlite
        SQLiteConnection dbConnection;


        public Login()
        {
            InitializeComponent();
            //the domain of the port
            dbConnection = new SQLiteConnection("Data Source=booksis.sqlite; Version=3");
            //opening the connection to the port
            dbConnection.Open();
            lblStatus.Text = null;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {

            string admin = "admin", teacher = "teacher";

            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT username,password,role FROM login WHERE username='"+this.tbxUser.Text+ "' AND password = '" + this.tbxPass.Text +"' AND role='"+admin+"' ", conn))
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


                                Dashboard dashboardForm = new Dashboard();
                                adminPanel aP = new adminPanel();
                                isLogedin = true;

                                Hide();
                                aP.ShowDialog();
                                dashboardForm.ShowDialog();
                                Close();

                            }
                            else if (count == 0)
                            {
                                lblStatus.Text = "felaktig information!";
                                lblStatus.ForeColor = Color.Red;
                            }

                            conn.Close();
                        }

                    }
                }

                using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("SELECT username,password,role FROM login WHERE username='" + this.tbxUser.Text + "' AND password = '" + this.tbxPass.Text + "' AND role='" + teacher + "' ", conn))
                    {

                        using (var reader = cmd.ExecuteReader())
                        {
                            var count = 0;
                            while (reader.Read())
                            {
                                count = count += 1;
                            }
                            if (count == 1)
                            {


                                Dashboard dashboardForm = new Dashboard();
                                isLogedin = true;

                                Hide();
                                dashboardForm.ShowDialog();
                                Close();

                            }
                            else if (count == 0)
                            {
                                lblStatus.Text = "felaktig information!";
                                lblStatus.ForeColor = Color.Red;
                            }

                            conn.Close();
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

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X-170;
                mouseY = MousePosition.Y-20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
