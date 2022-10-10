
using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;


namespace TailerApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Tailer;Integrated Security=True");
        SqlCommand cmd;
        //private object dataGridView;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_update.Visible = false;
            txt_customerName.Focus();
            retrive();
        }

        public void retrive()
        {
            con.Open();
            string query = "select isnull(MAX(Id),0)+1 as Id from Details";
            using (SqlCommand cmdRead = new SqlCommand(query, con))
            {

                using (SqlDataReader reader = cmdRead.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        txt_SerialNo.Text = reader["Id"].ToString();

                    };

                }

            }
            con.Close();

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text=="" && txt_kames.Text=="" && txt_bazo.Text=="" &&  txt_shalwar.Text=="" )
            {
                MessageBox.Show("درج کرے");
                return;
                
            }
            if (txt_payment.Text == "" && txt_Remaing.Text == "")
            {
                MessageBox.Show("درج کرے");
                return;
            }
            if ( txt_payment.Text != "" && txt_Remaing.Text == "" || txt_payment.Text == "" && txt_Remaing.Text != "" )
            {
                goto run;
               // MessageBox.Show("درج کرے");
               // return;
            }
            else
            {
                MessageBox.Show("درج کرے");
                return;
            }


            
             run:
            con.Open();
           
            SqlCommand cmdd = new SqlCommand("Declare @ID int =(select isnull(MAX(Id),0)+1 as ID from [Details])"
            + "insert into details (Id,CustomerName,Kames,Bazo,Tera,Galla,Chate,Kamar,Gera,Shalwar,Pancha,SidePockets,Hep,Cuf,FrontPocket,Kalar,Bain,Plait,SadaDaman,GolDaman,SignleSilai,DoubleSilai,ChamakTar,ShalwarPocket,PatyalaShalwar,Color,Amount,Remaning,ContactNo,CreatedDate)"
            + " Values (@ID,@CustomerName,@Kames,@Bazo,@Tera,@Galla,@Chate,@Kamar,@Gera,@Shalwar,@Pancha,@SidePockets,@Hep,@Cuf,@FrontPocket,@Kalar,@Bain,@Plait,@SadaDaman,@GolDaman,@SignleSilai,@DoubleSilai,@ChamakTar,@ShalwarPocket,@PatyalaShalwar,@Color,@Amount,@Remaning,@ContactNo,@CreatedDate)", con);
            cmdd.Parameters.AddWithValue("CustomerName", txt_customerName.Text);
            cmdd.Parameters.AddWithValue("Kames", txt_kames.Text);
            cmdd.Parameters.AddWithValue("Bazo", txt_bazo.Text);
            cmdd.Parameters.AddWithValue("Tera", txt_Tera.Text);
            cmdd.Parameters.AddWithValue("Galla", txt_gala.Text);
            cmdd.Parameters.AddWithValue("Chate", txt_chate.Text);
            cmdd.Parameters.AddWithValue("Kamar", txt_kamar.Text);
            cmdd.Parameters.AddWithValue("Gera", txt_gera.Text);
            cmdd.Parameters.AddWithValue("Shalwar", txt_shalwar.Text);
            cmdd.Parameters.AddWithValue("Pancha", txt_pancha.Text);
            cmdd.Parameters.AddWithValue("SidePockets", comb_saides.Text);
            cmdd.Parameters.AddWithValue("Hep", txt_heep.Text);
            cmdd.Parameters.AddWithValue("Cuf", txt_cufSize.Text);
            cmdd.Parameters.AddWithValue("FrontPocket", chk_front_pocket.Checked);
            cmdd.Parameters.AddWithValue("Kalar", chk_kalar.Checked);
            cmdd.Parameters.AddWithValue("Bain", chk_bain.Checked);
            cmdd.Parameters.AddWithValue("Plait", chk_plaits.Checked);
            cmdd.Parameters.AddWithValue("SadaDaman", chk_sada_daman.Checked);
            cmdd.Parameters.AddWithValue("GolDaman", chk_gol_dman.Checked);
            cmdd.Parameters.AddWithValue("SignleSilai", chk_signle_silai.Checked);
            cmdd.Parameters.AddWithValue("DoubleSilai", chk_double_silai.Checked);
            cmdd.Parameters.AddWithValue("ChamakTar", chk_chamaktar.Checked);
            cmdd.Parameters.AddWithValue("ShalwarPocket", chk_shalwar_jeb.Checked);
            cmdd.Parameters.AddWithValue("PatyalaShalwar", chk_patyala.Checked);
            cmdd.Parameters.AddWithValue("Color", txt_color.Text);
            cmdd.Parameters.AddWithValue("Amount", txt_payment.Text);
            cmdd.Parameters.AddWithValue("Remaning", txt_Remaing.Text);
            cmdd.Parameters.AddWithValue("ContactNo",txt_ContactNo.Text);
            cmdd.Parameters.AddWithValue("CreatedDate", dateTimePicker1.Text);
            //return;
            cmdd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("درج");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            lbl_date.Text = "";
            txt_SearchBox.Text = "";
            txt_customerName.Text = "";
            txt_cufSize.Text = "";
            txt_color.Text = "";
            txt_chate.Text = "";
            txt_gala.Text = "";
            txt_gera.Text = "";
            txt_heep.Text = "";
            txt_pancha.Text = "";
            txt_shalwar.Text = "";
            txt_kamar.Text = "";
            txt_Tera.Text = "";
            txt_kames.Text = "";
            txt_ContactNo.Text = "";
            txt_payment.Text = "";
            txt_Remaing.Text = "";
            txt_bazo.Text = "";
            chk_bain.Checked = false;
            chk_chamaktar.Checked = false;
            chk_double_silai.Checked = false;
            chk_front_pocket.Checked = false;
            chk_gol_dman.Checked = false;
            chk_kalar.Checked = false;
            chk_patyala.Checked = false;
            chk_plaits.Checked = false;
            chk_sada_daman.Checked = false;
            chk_shalwar_jeb.Checked = false;
            chk_signle_silai.Checked = false;
            comb_saides.SelectedIndex = 0;
            btn_update.Visible = false;
            btn_prnt.Text = "پرنٹ کریں";
            retrive();
        }

        private void txt_SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {

                txt_SearchBox.Focus();
                SearchVoucher();
                btn_update.Visible = true;   
                
            }
        }

        private void SearchVoucher()
        {
            con.Open();
            string query = "select * from Details where Id ='" + txt_SearchBox.Text + "'";
            using (SqlCommand cmdRead = new SqlCommand(query, con))
            {

                using (SqlDataReader reader = cmdRead.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        txt_SerialNo.Text = reader["Id"].ToString();
                        txt_customerName.Text = reader["CustomerName"].ToString();
                        txt_kames.Text = reader["Kames"].ToString();
                        txt_bazo.Text = reader["Bazo"].ToString();
                        txt_Tera.Text = reader["Tera"].ToString();
                        txt_gala.Text = reader["Galla"].ToString();
                        txt_chate.Text = reader["Chate"].ToString();
                        txt_kamar.Text = reader["Kamar"].ToString();
                        txt_gera.Text = reader["Gera"].ToString();
                        txt_shalwar.Text = reader["Shalwar"].ToString();
                        txt_cufSize.Text = reader["Cuf"].ToString();
                        txt_pancha.Text = reader["Pancha"].ToString();
                        txt_heep.Text = reader["Hep"].ToString();
                        txt_ContactNo.Text = reader["ContactNo"].ToString();
                        txt_Remaing.Text = reader["Remaning"].ToString();

                        string value = reader["SidePockets"].ToString();
                        // int v = int.Parse(value.ToString());
                        if (value == "")
                        {
                            comb_saides.SelectedIndex = -1;

                        }
                        if (value == "1")
                        {
                            comb_saides.SelectedIndex = 1;
                        }
                        if (value == "2")
                        {
                            comb_saides.SelectedIndex = 2;
                        }
                        string chk1 = reader["FrontPocket"].ToString();
                        if (chk1 == "1" || chk1== "True")
                        {
                            chk_front_pocket.Checked = true;
                        }
                        string chk2 = reader["Kalar"].ToString();
                       // int v2 = int.Parse(chk2.ToString());
                        if (chk2 == "1" || chk2 == "True")
                        {
                            chk_kalar.Checked = true;
                        }
                        string chk3 = reader["Bain"].ToString();
                        //int v3 = int.Parse(chk3.ToString());
                        if (chk3 == "1" || chk3 == "True")
                        {
                            chk_bain.Checked = true;
                        }
                        string chk4 = reader["Plait"].ToString();
                       // int v4 = int.Parse(chk4.ToString());
                        if (chk4 == "1" || chk4 == "True")
                        {
                            chk_plaits.Checked = true;
                        }
                        string chk5 = reader["SadaDaman"].ToString();
                      //  int v5 = int.Parse(chk5.ToString());
                        if (chk5 == "1" || chk5 == "True")
                        {
                            chk_sada_daman.Checked = true;
                        }
                        string chk6 = reader["GolDaman"].ToString();
                       // int v6 = int.Parse(chk6.ToString());
                        if (chk6 == "1" || chk6 == "True")
                        {
                            chk_gol_dman.Checked = true;
                        }
                        string chk7 = reader["SignleSilai"].ToString();
                        //int v7 = int.Parse(chk7.ToString());
                        if (chk7 == "1" || chk7 == "True")
                        {
                            chk_signle_silai.Checked = true;
                        }
                        string chk8 = reader["DoubleSilai"].ToString();
                        //int v8 = int.Parse(chk8.ToString());
                        if (chk8 == "1" || chk8 == "True")
                        {
                            chk_double_silai.Checked = true;
                        }
                        string chk9 = reader["ShalwarPocket"].ToString();
                        //int v9 = int.Parse(chk9.ToString());
                        if (chk9 == "1" || chk9 == "True")
                        {
                            chk_double_silai.Checked = true;
                        }
                        string chk10 = reader["PatyalaShalwar"].ToString();
                       // int v10 = int.Parse(chk10.ToString());
                        if (chk10 == "1" || chk10 == "True")
                        {
                            chk_double_silai.Checked = true;
                        }
                        txt_color.Text = reader["Color"].ToString();
                        txt_payment.Text = reader["Amount"].ToString();
                        lbl_date.Text = reader["CreatedDate"].ToString();
                    };

                }
               

            }
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand comm = new SqlCommand("update Details "
            + " set CustomerName= '" + txt_customerName.Text + "'"
            + " , Kames='"+txt_kames.Text+"' "
            + " , Bazo='"+txt_bazo.Text+"' "
            + " , Tera='"+txt_Tera.Text+"' "
            + " , Galla='"+txt_gala.Text+"' "
            + " , Chate='"+txt_chate.Text+"'"
            + " , Kamar='" + txt_kamar.Text+"' "
            + " , Gera='" + txt_gera.Text+"' "
            + " , Shalwar='" + txt_shalwar.Text+"' "
            + " , Cuf='" + txt_cufSize.Text+"' "
            + " , Pancha='" + txt_pancha.Text+"' "
            + " , Hep='" + txt_heep.Text+"' "
            + " , SidePockets='" + comb_saides.Text+"' "
            + " , FrontPocket='" + chk_front_pocket.Checked+"' "
            + " , Kalar='" + chk_kalar.Checked+"' "
            + " , Bain='" + chk_bain.Checked+"'  "
            + " , Plait='" + chk_plaits.Checked+"' "
            + " , SadaDaman='" + chk_sada_daman.Checked+"'"
            + " , GolDaman='" + chk_gol_dman.Checked+"'"
            + " , SignleSilai='" + chk_signle_silai.Checked+"'"
            + " , DoubleSilai='" + chk_double_silai.Checked+"'"
            + " , ChamakTar='" + chk_chamaktar.Checked + "'"
            + " , ShalwarPocket='" + chk_shalwar_jeb.Checked+"'"
            + " , PatyalaShalwar='" + chk_patyala.Checked+"' "
            + " , Color='" + txt_color.Text+"'"
            + " , Amount='" + txt_payment.Text+"'"
            + " , CreatedDate='" + dateTimePicker1.Text+"' where Id='" + txt_SearchBox.Text+"'",con);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("اپٹڈ کردیا ھے");
            }
            catch (Exception)
            {
                MessageBox.Show("اپٹڈ نھی ھو رھا");
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_kames_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_bazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Tera_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_gala_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_chate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_kamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_gera_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_shalwar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_pancha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_heep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_cufSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            
            if (txt_customerName.Text == "") {MessageBox.Show("load date"); return; }
                if (btn_prnt.Text == "پرنٹ کریں")
                {
                    printPreviewDialog1.Document = printDocument1;
                    printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
                    printPreviewDialog1.Show();
                    btn_prnt.Text = "پریندیڈ";

                }
                else if (btn_prnt.Text == "پریندیڈ")
                {
                printPreviewDialog1.Hide();
                btn_prnt.Text = "پرنٹ کریں";
                }
               
                con.Close(); 
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ///////////////////////////
            con.Open();
            string CmdString = string.Empty;
            CmdString = " select * from Details where Id ='" + txt_SearchBox.Text + "' ";
            SqlCommand comm = new SqlCommand(CmdString, con);
            SqlDataReader reader = comm.ExecuteReader();
            Font fontt = new Font("Calibri", 25, FontStyle.Regular);
            float fontHeight = fontt.GetHeight();

            //System.Drawing.Image img = System.Drawing.Image.FromFile("C:\\Users\\Shax00\\Desktop\\TailerApp\\TailerApp\\Resources\\scaner.jpg");
            //Point loc = new Point(100, 200);
            //e.Graphics.DrawImage(img, loc);
            //e.Graphics.DrawString("--------------------------------------------------------------------------------------------", fontt, Brushes.Black, 40, 190);
            e.Graphics.DrawString("گاہک کا نام", fontt, Brushes.Black, 670, 220);
            e.Graphics.DrawString("قمیص", fontt, Brushes.Black, 670, 260);
            e.Graphics.DrawString("بازو", fontt, Brushes.Black, 670, 300);
            e.Graphics.DrawString("تیرا", fontt, Brushes.Black, 670, 350);
            e.Graphics.DrawString("گلا", fontt, Brushes.Black, 670, 400);
            e.Graphics.DrawString("چھاتی", fontt, Brushes.Black, 670, 440);
            e.Graphics.DrawString("کمر", fontt, Brushes.Black, 670, 480);
            e.Graphics.DrawString("گھیرا", fontt, Brushes.Black, 670, 530);
            e.Graphics.DrawString("شلوارلمبائی", fontt, Brushes.Black, 670, 580);
            e.Graphics.DrawString("پانچا", fontt, Brushes.Black, 670, 630);
            e.Graphics.DrawString("سائیڈ جیب", fontt, Brushes.Black, 670, 660);
            e.Graphics.DrawString("ہیپ", fontt, Brushes.Black, 670, 690); 
            e.Graphics.DrawString("کف", fontt, Brushes.Black, 670, 740);

            e.Graphics.DrawString("رابط نمبر", fontt, Brushes.Black, 670, 920);
            e.Graphics.DrawString("رنگ", fontt, Brushes.Black, 670, 960);
          //  e.Graphics.DrawString("قیمت", fontt, Brushes.Black, 670, 1000);
            e.Graphics.DrawString("تاریخ", fontt, Brushes.Black, 450, 1000);

            e.Graphics.DrawString("سامنے جیب", fontt, Brushes.Black, 200, 260);
            e.Graphics.DrawString("کالر", fontt, Brushes.Black, 200, 300);
            e.Graphics.DrawString("بین", fontt, Brushes.Black, 200, 350);
            e.Graphics.DrawString("پلیٹ", fontt, Brushes.Black, 200, 400);
            e.Graphics.DrawString("سادہ دامن", fontt, Brushes.Black, 200, 440);
            e.Graphics.DrawString("گول دامن", fontt, Brushes.Black, 200, 480);
            e.Graphics.DrawString("سنگل سلائی", fontt, Brushes.Black, 200, 530);
            e.Graphics.DrawString("ڈبل سلائی", fontt, Brushes.Black, 200, 580);
            e.Graphics.DrawString("چمک تار", fontt, Brushes.Black, 200, 630);
            e.Graphics.DrawString("شلوار جیب ", fontt, Brushes.Black, 200, 660);
            e.Graphics.DrawString("پٹیالہ شلوار", fontt, Brushes.Black, 200, 690);
            //e.Graphics.DrawString("--------------------------------------------------------------------------------------------", fontt, Brushes.Black, 40, 190);

            string CustomerName = txt_customerName.Text;
            string Kames = txt_kames.Text;
            string Bazo = txt_bazo.Text;
            string Tera = txt_Tera.Text;
            string Galla = txt_gala.Text;
            string Chate = txt_chate.Text;
            string Kamar = txt_kamar.Text;
            string Gera = txt_gera.Text;
            string Shalwar = txt_shalwar.Text;
            string Pancha = txt_pancha.Text;
            string SidePockets = comb_saides.Text;
            string Hep = txt_heep.Text;
            string Cuf = txt_cufSize.Text;
            string Color = txt_color.Text;  
          //  string Amount = txt_payment.Text;
            string ContactNo = txt_ContactNo.Text;
            string Datee = lbl_date.Text;


            //checkboxes
            string front ="";
            if (chk_front_pocket.Text == "True" || chk_front_pocket.Checked) { front = "✓"; } else { front = "✕"; }
            string Kalar="";
            if ( chk_kalar.Checked || chk_kalar.Text == "True" || chk_kalar.Text == "1") { Kalar = "✓"; }else{ Kalar = "✕"; }
            string Bain = "";
            if ( chk_bain.Checked || chk_bain.Text == "True"|| chk_bain.Text == "1" ) { Bain = "✓"; } else { Bain = "✕"; }
            string Plaits ="";
            if ( chk_plaits.Checked ||chk_plaits.Text == "True" || chk_plaits.Text == "1") { Plaits = "✓"; } else { Plaits = "✕"; }
            string sadadanam ="";
            if ( chk_sada_daman.Checked || chk_sada_daman.Text == "True" || chk_sada_daman.Text == "1") { sadadanam = "✓"; } else { sadadanam = "✕"; }
            string golodaman = "";
            if ( chk_gol_dman.Checked || chk_gol_dman.Text == "True" || chk_gol_dman.Text == "1") { golodaman = "✓"; } else { golodaman = "✕"; }
            string singlesilai = "";
            if ( chk_signle_silai.Checked || chk_signle_silai.Text == "True" || chk_signle_silai.Text == "1" ) { singlesilai = "✓"; } else { singlesilai = "✕"; }
            string doublesilai = "";
            if ( chk_double_silai.Checked || chk_double_silai.Text == "True" || chk_double_silai.Text == "1"  ){ doublesilai = "✓"; } else { doublesilai = "✕"; }
            string chamaktar = "";
            if ( chk_chamaktar.Checked || chk_chamaktar.Text == "True" || chk_chamaktar.Text == "1") { chamaktar = "✓"; } else { chamaktar = "✕"; }
            string shalwarjeb = "";
            if (chk_shalwar_jeb.Checked ||chk_shalwar_jeb.Text == "True" || chk_shalwar_jeb.Text == "1") { shalwarjeb = "✓"; } else { shalwarjeb = "✕"; }
            string patyalashalwar = "";
            if ( chk_patyala.Checked || chk_patyala.Text == "True" || chk_patyala.Text == "1") { patyalashalwar = "✓"; } else { patyalashalwar = "✕"; }


            e.Graphics.DrawString(CustomerName, fontt, Brushes.Black, 450, 220);
            e.Graphics.DrawString(Kames, fontt, Brushes.Black, 610, 260);
            e.Graphics.DrawString(Bazo, fontt, Brushes.Black, 610, 300);
            e.Graphics.DrawString(Tera, fontt, Brushes.Black, 610, 350);
            e.Graphics.DrawString(Galla, fontt, Brushes.Black, 610, 400);
            e.Graphics.DrawString(Chate, fontt, Brushes.Black, 610, 440);
            e.Graphics.DrawString(Kamar, fontt, Brushes.Black, 610, 480);
            e.Graphics.DrawString(Gera, fontt, Brushes.Black, 610, 530);
            e.Graphics.DrawString(Shalwar, fontt, Brushes.Black, 610, 580);
            e.Graphics.DrawString(Pancha, fontt, Brushes.Black, 610, 630);
            e.Graphics.DrawString(SidePockets, fontt, Brushes.Black, 610, 660);
            e.Graphics.DrawString(Hep, fontt, Brushes.Black, 610, 690);
            e.Graphics.DrawString(Cuf, fontt, Brushes.Black, 610, 740);

            e.Graphics.DrawString(ContactNo, fontt, Brushes.Black, 400, 920);
            e.Graphics.DrawString(Color, fontt, Brushes.Black, 580, 960);
           // e.Graphics.DrawString(Amount, fontt, Brushes.Black, 580, 1000);
            e.Graphics.DrawString(Datee, fontt, Brushes.Black, 250, 1000);

            //
            e.Graphics.DrawString(front, fontt, Brushes.Black, 100, 260);
            e.Graphics.DrawString(Kalar, fontt, Brushes.Black, 100, 300);
            e.Graphics.DrawString(Bain, fontt, Brushes.Black, 100, 350);
            e.Graphics.DrawString(Plaits, fontt, Brushes.Black, 100, 400);
            e.Graphics.DrawString(sadadanam, fontt, Brushes.Black, 100, 440);
            e.Graphics.DrawString(golodaman, fontt, Brushes.Black, 100, 480);
            e.Graphics.DrawString(singlesilai, fontt, Brushes.Black, 100, 530);
            e.Graphics.DrawString(doublesilai, fontt, Brushes.Black, 100, 580);
            e.Graphics.DrawString(chamaktar, fontt, Brushes.Black, 100, 630);
            e.Graphics.DrawString(shalwarjeb, fontt, Brushes.Black, 100, 660);
            e.Graphics.DrawString(patyalashalwar, fontt, Brushes.Black, 100, 690);






            con.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text== " گاہک کے لے  پرنٹ کریں") {
                printPreviewDialog2.Document = printDocument2;
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument2_PrintPage);
                printPreviewDialog2.Show();
                button1.Text = "پرنٹ";
            }
           else if(button1.Text == "پرنٹ"){
                printPreviewDialog2.Hide();
                button1.Text = " گاہک کے لے  پرنٹ کریں";
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            con.Open();
            string CmdString = string.Empty;
            CmdString = " select * from Details where Id ='" + txt_SearchBox.Text + "' ";
            SqlCommand comm = new SqlCommand(CmdString, con);
            SqlDataReader reader = comm.ExecuteReader();
            Font fontt = new Font("Calibri", 25, FontStyle.Regular);
            float fontHeight = fontt.GetHeight();
            e.Graphics.DrawString("نام", fontt, Brushes.Black, 670, 100);
            e.Graphics.DrawString("تاریخ", fontt, Brushes.Black, 670, 150);
            e.Graphics.DrawString("تعداد", fontt, Brushes.Black, 670, 200);
            e.Graphics.DrawString("ایڈ وانس", fontt, Brushes.Black, 670, 250);

            string CustomerName = txt_customerName.Text;
            string Datee = lbl_date.Text;
            string Bazo = txt_bazo.Text;
            string Advance = txt_payment.Text;

            e.Graphics.DrawString(CustomerName, fontt, Brushes.Black, 450, 100);
            e.Graphics.DrawString(Datee, fontt, Brushes.Black, 450, 150);
            e.Graphics.DrawString("____________", fontt, Brushes.Black, 450, 200);
            e.Graphics.DrawString(Advance, fontt, Brushes.Black, 450, 250);

            e.Graphics.DrawString("نمبر", fontt, Brushes.Black, 340, 100);
            e.Graphics.DrawString("واپسی تاریخ", fontt, Brushes.Black, 300, 150);
            e.Graphics.DrawString("کل رقم", fontt, Brushes.Black, 340, 200);
            e.Graphics.DrawString("بقایا", fontt, Brushes.Black, 340, 250);
            e.Graphics.DrawString("دستخط", fontt, Brushes.Black, 340, 350);


            string Seial = txt_SerialNo.Text;
            string Remaning = txt_Remaing.Text;
            e.Graphics.DrawString(Seial, fontt, Brushes.Black, 150, 100);
            e.Graphics.DrawString("____________", fontt, Brushes.Black, 80, 150);
            e.Graphics.DrawString("____________", fontt, Brushes.Black, 80, 200);
            e.Graphics.DrawString(Remaning, fontt, Brushes.Black, 100, 250);
            e.Graphics.DrawString("____________", fontt, Brushes.Black, 80, 350);


            con.Close();
        }

        private void txt_Remaing_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
