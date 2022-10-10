using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace TailerApp
{
    public partial class Data : Form
    {
        string constring = @"Data Source=localhost\sqlexpress;Initial Catalog=Tailer;Integrated Security=True";
        string sdate = "";
        string edate = "";

        string serial = "";
        string Contact = "";

        public Data()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Details", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;// fro removing columns line
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sdate = dt_searchfrom.Value.ToString("dd-MM-yyyy");
            edate = dt_searchto.Value.ToString("dd-MM-yyyy");

            FillDataGrid(sdate,edate);
        }
        private void FillDataGrid(string sdate,string edate)
        {
            //for index size
            dataGridView.AllowUserToAddRows = false;
            using (SqlConnection connection =new SqlConnection(constring))
            {
                string CmdString = string.Empty;

                CmdString = "select * from Details where cast([CreatedDate] as varchar(100)) >= '"+sdate+"' and cast([CreatedDate] as varchar(100)) < '"+edate+"'";

                SqlCommand cmd = new SqlCommand(CmdString, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;// fro removing columns line
                                                                                             // ReportGrid.FirstDisplayedScrollingRowIndex = ReportGrid.RowCount-1;
                dataGridView.DataSource = dt;

                //for total sum of fee
                int sum = 0;
                for (int i = 0; i <= dataGridView.Rows.Count - 1; i++)
                {
                    //working from her
                    // string value=ReportGrid.Rows[i].Cells[2].Value.ToString();
                    if (dataGridView.Rows[i].Cells[24].Value.ToString() == "")
                    {
                        //ReportGrid.Rows[i].Cells[2].Value.ToString().Replace("","0");
                        return;
                    }
                    sum = sum + int.Parse(dataGridView.Rows[i].Cells[2].Value.ToString());
                }

                label3.Text = sum.ToString();



                //printPreviewDialog1.Document = printDocument1;
                //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
                //printPreviewDialog1.Show();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial = txt_search_data.Text;
            dataGridView.AllowUserToAddRows = false;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                string CmdString = string.Empty;

                CmdString = "select * from Details where Id='" + serial + "'";

                SqlCommand cmd = new SqlCommand(CmdString, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;// fro removing columns line
                                                                                            // ReportGrid.FirstDisplayedScrollingRowIndex = ReportGrid.RowCount-1;
                dataGridView.DataSource = dt;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Contact = txt_contact_search.Text;
            dataGridView.AllowUserToAddRows = false;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                string CmdString = string.Empty;

                CmdString = "select * from Details where ContactNo='" + Contact + "'";

                SqlCommand cmd = new SqlCommand(CmdString, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;// fro removing columns line
                                                                                            // ReportGrid.FirstDisplayedScrollingRowIndex = ReportGrid.RowCount-1;
                dataGridView.DataSource = dt;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\AllData.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
           // app.Quit();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        string id;
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = dataGridView.CurrentCell.RowIndex; //for showing the index number 
            //dataGridView.Rows.RemoveAt(rowIndex);
            id =  dataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();
            DialogResult res = MessageBox.Show("Do You Want To Delete '" + id + "' This Record....!!", "Exit", MessageBoxButtons.YesNo) ;
            if (res == DialogResult.Yes)
            {
                //Some task…
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                SqlCommand SqlComm = new SqlCommand("DELETE FROM Details WHERE Id='" + id + "'", connection);
                SqlComm.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record SuccesFully Deleted..");
            }
            if (res == DialogResult.No)
            {
                //Some task…
                BindGrid();
            }
           
            BindGrid();


        }
    }
}
