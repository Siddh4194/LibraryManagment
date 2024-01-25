using Guna.UI2.WinForms;
using Libraryproject.libraryDataSetTableAdapters;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Libraryproject
{
    public partial class Form4 : Form
    {
       public string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }



        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Borrower' table. You can move, or remove it, as needed.

            timer1.Start();
            designform();
        }
        public void designform()
        {

            if (Form1.t3 > 0)
            {
                this.BackColor = Color.White;
                if (Form1.colorpicked == "Blue")
                {
                    label1.ForeColor = Color.FromArgb(27, 163, 242);
                    label2.ForeColor = Color.FromArgb(27, 163, 242);
                    label3.ForeColor = Color.FromArgb(27, 163, 242);
                    label4.ForeColor = Color.FromArgb(27, 163, 242);
                    //theme for the datagrid view
                    //textbo theme
                    guna2TextBox1.BackColor = Color.FromArgb(196, 201, 204);
                    guna2TextBox2.BackColor = Color.FromArgb(196, 201, 204);
                    guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;


                    //button color

                    guna2GradientButton1.BackColor = Color.FromArgb(27, 163, 242);
                    guna2GradientButton2.BackColor = Color.FromArgb(27, 163, 242);
                    
                }
                if (Form1.colorpicked == "Red")
                {
                    label1.ForeColor = Color.FromArgb(235, 16, 16);
                    label2.ForeColor = Color.FromArgb(235, 16, 16);
                    label3.ForeColor = Color.FromArgb(235, 16, 16);
                    label4.ForeColor = Color.FromArgb(235, 16, 16);
                    //theme for the datagrid view
                    
                    //theme for the datagrid view
                    //textbo theme
                    guna2TextBox1.BackColor = Color.FromArgb(196, 201, 204);
                    guna2TextBox2.BackColor = Color.FromArgb(196, 201, 204);
                    guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;


                    //button color

                    guna2GradientButton1.BackColor = Color.FromArgb(235, 16, 16);
                    guna2GradientButton2.BackColor = Color.FromArgb(235, 16, 16);

                }
            }
            else
            {
                this.BackColor = Color.Black;
                if (Form1.colorpicked == "Blue")
                {
                    label1.ForeColor = Color.FromArgb(27, 163, 242);
                    label2.ForeColor = Color.FromArgb(27, 163, 242);
                    label3.ForeColor = Color.FromArgb(27, 163, 242);
                    label4.ForeColor = Color.FromArgb(27, 163, 242);
                    //theme for the datagrid view
                    guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
                    //textbo theme
                    guna2TextBox1.BackColor = Color.FromArgb(196, 201, 204);
                    guna2TextBox2.BackColor = Color.FromArgb(196, 201, 204);
                    //button color
                    guna2GradientButton1.BackColor = Color.FromArgb(235, 16, 16);
                    guna2GradientButton2.BackColor = Color.FromArgb(235, 16, 16);
                }
                if (Form1.colorpicked == "Red")
                {
                    label1.ForeColor = Color.FromArgb(27, 163, 242);
                    label2.ForeColor = Color.FromArgb(27, 163, 242);
                    label3.ForeColor = Color.FromArgb(27, 163, 242);
                    label4.ForeColor = Color.FromArgb(27, 163, 242);
                    //theme for the datagrid view
                    guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
                    //textbo theme
                    guna2TextBox1.BackColor = Color.FromArgb(196, 201, 204);
                    guna2TextBox2.BackColor = Color.FromArgb(196, 201, 204);



                    //button color

                    guna2GradientButton1.BackColor = Color.FromArgb(235, 16, 16);
                    guna2GradientButton2.BackColor = Color.FromArgb(235, 16, 16);
                }
            }
        }
        int t1 = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*int tr = 0;
            availablebookTableAdapter avd=new availablebookTableAdapter();
            var avr = avd.GetData();
            foreach(DataRow rows in avr.Rows)
            {
                if (rows["isbnid"].ToString().Equals(textBox2))
                {
                    tr = int.Parse(rows["Available_books"].ToString());
                }
                if (tr > 0)
                {*/

            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                scon.Open();
                try
                {
                    SqlDataAdapter sdata = new SqlDataAdapter("insert into Borrower(Borrowed_Id,Book_Id) values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "')", scon);
                    DataTable dt1 = new DataTable();
                    sdata.Fill(dt1);
                    guna2DataGridView1.DataSource = dt1;
                    SqlDataAdapter sdata1 = new SqlDataAdapter("update availablebook set Available_books=Available_books-1 where isbnid=" + guna2TextBox2.Text, scon);
                    DataTable dt12 = new DataTable();
                    sdata1.Fill(dt12);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Student Alredy Taken A Book" + ex.Message);
                }

                historyTableAdapter hist = new historyTableAdapter();
                var hist2 = hist.GetData();

                foreach (DataRow rows1 in hist2.Rows)
                {
                    if (guna2TextBox1.Text.Equals(rows1["borrowered"]))
                    {
                        t1++;
                    }

                }
                datainsert();
            }
            /*}
            else {
                MessageBox.Show("This Book Is Not Available");

            }*/


        }
        public void datainsert()////////////////8888
        {
            using (SqlConnection scon2 = new SqlConnection(connectionstring))
            {
                newbookTableAdapter new1 = new newbookTableAdapter();
                var hist1 = new1.GetData();
                if (t1 == 0)
                {
                    foreach (DataRow row1 in hist1.Rows)
                    {
                        if (guna2TextBox2.Text.Equals(row1["ISBN_id"]))
                        {
                            SqlDataAdapter sdata2 = new SqlDataAdapter("insert into history(borrowered,books,fine) values('" + guna2TextBox1.Text + "','" + row1["bookname"].ToString() + "','" + 100 + "')", scon2);
                            DataTable dt13 = new DataTable();
                            sdata2.Fill(dt13);
                        }
                    }
                }
                else
                {
                     foreach (DataRow row1 in hist1.Rows)
                     {
                       if (guna2TextBox2.Text.Equals(row1["ISBN_id"]))
                       {
                         SqlDataAdapter sdata2 = new SqlDataAdapter("update history set books="+row1["bookname"]+"+','+books where borrowered="+guna2TextBox1.Text, scon2);
                         DataTable dt14 = new DataTable();
                         sdata2.Fill(dt14);
                       }
                     }
                }
            }
        }
        public void refreshview()
        {
            using (SqlConnection scon1 = new SqlConnection(connectionstring))
            {
                scon1.Open();
                SqlDataAdapter sqldata = new SqlDataAdapter("select * from Borrower", scon1);
                DataTable dt1 = new DataTable();
                sqldata.Fill(dt1);
                guna2DataGridView1.DataSource = dt1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshview();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var s = guna2DataGridView1.CurrentRow;
            guna2TextBox1.Text = s.Cells[0].ToString();
            guna2TextBox2.Text = s.Cells[1].ToString();
            var vr = s.Cells[3].ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var t = 0;
            DateTime today = DateTime.Today;
            var sc = borrowerTableAdapter.GetData();
            try
            {
                using (SqlConnection scon = new SqlConnection(connectionstring))
                {
                    scon.Open();
                    SqlDataAdapter sdata = new SqlDataAdapter("delete from Borrower where Borrowed_Id=" + guna2TextBox1.Text + " and Borrowed_To>=GetDate()", scon);
                    DataTable dt1 = new DataTable();
                    sdata.Fill(dt1);
                    guna2DataGridView1.DataSource = dt1;
                    t++;
                    SqlDataAdapter sdata1 = new SqlDataAdapter("update availablebook set Available_books=Available_books+1 where isbnid=" + guna2TextBox2.Text, scon);
                    DataTable dt12 = new DataTable();
                    sdata1.Fill(dt12);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter the Data");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox1 != null)
                {
                    using (SqlConnection scon0 = new SqlConnection(connectionstring))
                    {
                        scon0.Open();
                        SqlCommand cmd1 = new SqlCommand("select name from studentdata where Borrowerid= " + guna2TextBox1.ToString() + scon0);
                        SqlDataReader srd2= cmd1.ExecuteReader();
                        while (srd2.Read())
                        {
                            label3.Text = srd2.GetValue(0).ToString();
                        }
                        scon0.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label3.Text = "Not Found";

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox2.Text != null)
                    using (SqlConnection scon2 = new SqlConnection(connectionstring))
                    {
                        scon2.Open();
                        SqlCommand comm1 = new SqlCommand("select bookname from newbook where ISBN_id=" + guna2TextBox2.Text.ToString(), scon2);
                        SqlDataReader srd1 = comm1.ExecuteReader();
                        while (srd1.Read())
                        {
                            label4.Text = srd1.GetValue(0).ToString();
                        }
                        scon2.Close();
                    }

            }
            catch (Exception ex)
            {

                label4.Text = "Not Found";

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                scon.Open();
                try
                {
                    SqlDataAdapter sdata = new SqlDataAdapter("insert into Borrower(Borrowed_Id,Book_Id) values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "')", scon);
                    DataTable dt1 = new DataTable();
                    sdata.Fill(dt1);
                    guna2DataGridView1.DataSource = dt1;
                    SqlDataAdapter sdata1 = new SqlDataAdapter("update availablebook set Available_books=Available_books-1 where isbnid=" + guna2TextBox2.Text, scon);
                    DataTable dt12 = new DataTable();
                    sdata1.Fill(dt12);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Student Alredy Taken A Book" + ex.Message);
                }

                historyTableAdapter hist = new historyTableAdapter();
                var hist2 = hist.GetData();

                foreach (DataRow rows1 in hist2.Rows)
                {
                    if (guna2TextBox1.Text.Equals(rows1["borrowered"]))
                    {
                        t1++;
                    }

                }
                datainsert();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Today;
                BorrowerTableAdapter ada = new BorrowerTableAdapter();
                var dates = ada.GetData();
                foreach(DataRow ro in dates.Rows)
                {
                    if (guna2TextBox1.Text.Equals(ro["Borrowed_Id"]))
                    {
                        DateTime st1 = DateTime.Parse(ro["Borrowed_To"].ToString());
                        if (dt >= st1)
                        {
                            using (SqlConnection scon = new SqlConnection(connectionstring))
                            {
                                scon.Open();
                                SqlDataAdapter sdata = new SqlDataAdapter("delete from Borrower where Borrowed_Id='" + guna2TextBox1.Text +"'", scon);
                                DataTable dt1 = new DataTable();
                                sdata.Fill(dt1);
                                guna2DataGridView1.DataSource = dt1;
                                SqlDataAdapter sdata1 = new SqlDataAdapter("update availablebook set Available_books=Available_books+1 where isbnid=" + guna2TextBox2.Text, scon);
                                DataTable dt12 = new DataTable();
                                sdata1.Fill(dt12);

                                TimeSpan dt3 = st1.Subtract(dt);
                                int t = Convert.ToInt32(((double)dt3.TotalDays));
                                MessageBox.Show("Fine for this student is" + t*5);
                            }
                        }
                        else 
                        {
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox1.Text != null)
                    using (SqlConnection scon4 = new SqlConnection(connectionstring))
                    {
                        scon4.Open();
                        SqlCommand comm1 = new SqlCommand("select name from studentdata where Borrowerid='" + guna2TextBox1.Text.ToString()+"'",scon4);
                        SqlDataReader srd1 = comm1.ExecuteReader();
                        while (srd1.Read())
                        {
                            label3.Text = srd1.GetValue(0).ToString();
                        }
                        scon4.Close();
                    }

            }
            catch (Exception ex)
            {

                label3.Text = "Not Found";

            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox2.Text != null)
                    using (SqlConnection scon2 = new SqlConnection(connectionstring))
                    {
                        scon2.Open();
                        SqlCommand comm1 = new SqlCommand("select bookname from newbook where ISBN_id=" + guna2TextBox2.Text.ToString(), scon2);
                        SqlDataReader srd1 = comm1.ExecuteReader();
                        while (srd1.Read())
                        {
                            label4.Text = srd1.GetValue(0).ToString();
                        }
                        scon2.Close();
                    }

            }
            catch (Exception ex)
            {

                label4.Text = "Not Found";

            }
        }
    }
}

