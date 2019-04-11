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
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;



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
        public static string teacher;

        // runs the method "importInfo();" on the programs start
        // and clears the lblElevId 


        public Dashboard()
        {
            InitializeComponent();
            importInfo();
            lblElevId.Text = null;
            lblLärare.Text = teacher;
            /* 
            *  /////////////////////////////////////////////////////I
            *  | this includes the licenses for the gembox library |I
            *  \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\I
            */
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }


        //adds a book to the DB
        private void btnAdd_Click(object sender, EventArgs e)
        {

            id = rnd.Next(8000);

            metroGrid1.Rows.Clear();

            if (tbxNamn.Text != null && tbxKlass.Text != null && tbxÄmne.Text != null && tbxBokNamn.Text != null && tbxBokNummer.Text != null && tbxBokKostnad.Text != null)
            {

                using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO '" + teacher + "'(id,namn,klass,kurs,boknamn,boknummer,bokenskostnad,uTdatum,aLDatum) VALUES('" + id + "','" + tbxNamn.Text + "','" + tbxKlass.Text + "','" + tbxÄmne.Text + "','" + tbxBokNamn.Text + "','" + tbxBokNummer.Text + "','" + tbxBokKostnad.Text + " kr" + "','" + dtpUL.Text + "','" + dtpÅL.Text + "')", conn))
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

            //refreashes the grid
            importInfo();
        }


        //Gets the books information from the DB
        void importInfo()
        {
            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM '" + teacher + "'", conn))
                {

                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        metroGrid1.Rows.Add(new object[]
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

        // Loads the textboxes when the information in the table
        private void btnHämta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                lblElevId.Text = row.Cells[0].Value.ToString();
                tbxNamn.Text = row.Cells[1].Value.ToString();
                tbxKlass.Text = row.Cells[2].Value.ToString();
                tbxÄmne.Text = row.Cells[3].Value.ToString();
                tbxBokNamn.Text = row.Cells[4].Value.ToString();
                tbxBokNummer.Text = row.Cells[5].Value.ToString();
                tbxBokKostnad.Text = row.Cells[6].Value.ToString();
                dtpUL.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
                dtpÅL.Value = Convert.ToDateTime(row.Cells[8].Value.ToString());

            }


        }

        // Clears all the fields
        private void label9_Click(object sender, EventArgs e)
        {
            lblElevId.Text = null;
            tbxNamn.Clear();
            tbxÄmne.Clear();
            tbxBokKostnad.Clear();
            tbxKlass.Clear();
            tbxBokNummer.Clear();
            tbxBokNamn.Clear();
            dtpUL.Value = DateTime.Now;
            dtpÅL.Value = DateTime.Now;
        }




        //Update the info in the DB
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {

            string rowId = "";
            //find the row id

            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                rowId = row.Cells[0].Value.ToString();
            }

            //update row id in DB


            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\abdsak11\Documents\GitHub\booksis\BooksisC#\booksis\booksis.sqlite;Version=3;New=False;Compress=True;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("update '" + teacher + "' set namn='" + tbxNamn.Text + "',klass='" + tbxKlass.Text + "',kurs='" + tbxÄmne.Text + "',boknamn='" + tbxBokNamn.Text + "',boknummer='" + tbxBokNummer.Text + "', bokenskostnad='" + tbxBokKostnad.Text + "',uTdatum='" + dtpUL.Text + "',aLDatum='" + dtpÅL.Text + "' where id='" + rowId + "'", conn))
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

            //update grid
            metroGrid1.Rows.Clear();
            importInfo();
        }

        private void btnUpdateExcel_Click(object sender, EventArgs e)
        {
            // the saving dialog
            var saveFileDialog = new SaveFileDialog();
            // the types of files that can be saved
            saveFileDialog.Filter = "XLS files (*.xls)|*.xls|XLT files (*.xlt)|*.xlt|XLSX files (*.xlsx)|*.xlsx|XLSM files (*.xlsm)|*.xlsm|XLTX (*.xltx)|*.xltx|XLTM (*.xltm)|*.xltm|ODS (*.ods)|*.ods|OTS (*.ots)|*.ots|CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|HTML (*.html)|*.html|MHTML (.mhtml)|*.mhtml|PDF (*.pdf)|*.pdf|XPS (*.xps)|*.xps|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // create a new excel file
                var workbook = new ExcelFile();
                // add a new excel sheet
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // From metrogrid1 to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(worksheet, this.metroGrid1, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                // saves the file
                workbook.Save(saveFileDialog.FileName);
            }
        }
    }
}
