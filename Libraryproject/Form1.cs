using Google.Protobuf.Reflection;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Libraryproject.libraryDataSetTableAdapters;
using Libraryproject.Properties;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Fpe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;


namespace Libraryproject
{

    public partial class Form1 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form5 ff5= new Form5();
            //ff5.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Borrower' table. You can move, or remove it, as needed.
            panel4.Hide();
            panel1.Hide();
            panel2.Show();
            timer1.Start();
            guna2Panel6.Hide();
            starter();
            guna2Panel4.Visible = false;
            pictureBox2.Visible = false; pictureBox3.Visible = true; guna2Panel1.Width = 47;
            guna2GradientTileButton11.Visible = true;
            guna2GradientTileButton13.Visible = true;
            accesses();
            guna2GradientTileButton17.Visible = true;
            guna2GradientTileButton16.Visible = true;
            guna2GradientTileButton15.Visible= true;
            panel2.Show();
            guna2DataGridView2.Hide();
        }
        public void timing()
        {
            timer4.Start();
            label11.Text = DateTime.Now.ToString("T");
        }
        public void accesses()
        {
            if (gpanel4>0)
            {
                guna2GradientTileButton1.BackColor = Color.White;
            }
            else {
                guna2GradientTileButton1.BackColor = Color.Transparent;
            }
        }
        public void login()
        {
            Form form = new Form();
            using (Form5 modal = new Form5())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = .50d;
                form.BackColor = Color.Black;
                form.Size = this.Size;
                form.Location = this.Location;
                form.ShowInTaskbar = false;
                form.Show();
                modal.Owner = form;
                parentx = this.Location.X;
                parenty = this.Location.Y;

                modal.ShowDialog();
                form.Dispose();
            }
            loginnamechanges();
        }
        libraryDataSet data = new libraryDataSet();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }
        public void showdataoverdue() {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                DateTime dateTime = DateTime.Today;
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select s.Borrowerid,s.name,n.bookname,s.phoneno,s.email from studentdata as s join Borrower as o on s.Borrowerid = o.Borrowed_Id,Borrower as c join newbook as n on c.Book_Id=n.ISBN_id  where o.Borrowed_TO > GETDATE()", sqlcon);
                DataTable dt1 = new DataTable();
                sqlda.Fill(dt1);
                guna2DataGridView3.DataSource = dt1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            showdataoverdue();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guna2Panel1.Width = 47;
            guna2Transition1.ShowSync(guna2Panel1);
            pictureBox2.Visible = false; pictureBox3.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 200;
            guna2Transition1.ShowSync(guna2Panel1);

        }
        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            guna2Panel1.Width = 222;
            guna2Transition1.ShowSync(guna2Panel1);
            pictureBox3.Visible = false; pictureBox2.Visible = true;
        }
        public int gpanel4=0;
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            guna2Panel4.Show();
            panel1.Hide();
            panel2.Hide();guna2Panel7.Hide();
            panel4.Hide(); guna2Panel3.Hide();
            guna2GradientTileButton1.BackColor = Color.White;
            Form3 ff3 = new Form3() { TopLevel = false, TopMost = true };
            ff3.FormBorderStyle = FormBorderStyle.None;
            guna2Panel4.Controls.Add(ff3);
            ff3.Show();
            
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            guna2Panel3.Show();
            panel1.Hide();
            panel2.Hide();
            guna2Panel7.Hide();
            panel4.Hide();
            Form2 ff2 = new Form2() { TopLevel = false, TopMost = true };
            ff2.FormBorderStyle= FormBorderStyle.None;
            guna2Panel3.Controls.Add(ff2);
            ff2.Show();
            guna2Panel4.Hide();
            guna2GradientTileButton1.BackColor = Color.Transparent;
            gpanel4--;
        }
        public static string colorpicked;
        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            guna2Panel7.Show();
            guna2Panel3.Hide();
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
            guna2Panel4.Hide();
            Form4 ff4 = new Form4(){ TopLevel = false, TopMost = true };
            ff4.FormBorderStyle = FormBorderStyle.None;
            guna2Panel7.Controls.Add(ff4);
            ff4.Show();
            guna2GradientTileButton1.BackColor = Color.Transparent;
            gpanel4--;
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            panel2.Show();
            guna2Panel4.Hide();
            panel1.Hide();guna2Panel7.Hide();
            panel4.Hide(); guna2Panel3.Hide();
        }
        public int parentxx, parentyy;
        int j;
        public void animation()
        {
            parentxx=panel1.Location.X;
            parentyy=panel1.Location.Y;
            j = 222;
        }
        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            guna2Panel4.Hide();
            panel2.Hide();
            panel4.Hide(); guna2Panel3.Hide();
            panel1.Show();guna2Panel7.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection scon3 = new SqlConnection(connectionstring))
                {
                    scon3.Open();
                    SqlCommand comm1 = new SqlCommand("select bookname from newbook where ISBN_id like '%" + guna2TextBox2.Text.ToString()+"%'", scon3);
                    SqlDataReader srd1 = comm1.ExecuteReader();
                    while (srd1.Read())
                    {
                        label4.Text = srd1.GetValue(0).ToString();
                    }
                    scon3.Close();
                }
            }
            catch(Exception ex) 
            {
                label4.Text = "Not Found";
            }
            
        }

       
        
        public void renew()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                if (guna2TextBox1.Text != null && guna2TextBox2.Text != null)
                {
                    sqlcon.Open();
                    SqlDataAdapter sqdata = new SqlDataAdapter("update Borrower set Borrowed_From = GetDate(),Borrowed_To = DateAdd(week,1,GetDate()) where Borrowed_Id ='" + guna2TextBox1.Text.ToString()+"'", sqlcon);
                    DataTable dt = new DataTable();
                    sqdata.Fill(dt);
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("Please Fill All boxes");
                }
            }
        }

        
        public static int parentx,parenty;

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView2.Show();
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqdata = new SqlDataAdapter("select o.bookname,s.Available_books,o.auther,o.publication,o.price,o.branch,o.noitems from newbook as o join availablebook as s on o.ISBN_id=s.isbnid where bookname like '%" + guna2TextBox3.Text + "%'", sqlcon);
                DataTable dt1 = new DataTable();
                sqdata.Fill(dt1);
                guna2DataGridView2.DataSource = dt1;
                sqlcon.Close();
            }
        }
        public void loginnamechanges()
        {
            if (Form5.t>0)
            {
                guna2GradientTileButton14.Visible = true;
                guna2GradientTileButton14.Text = Form5.Log_InNAME.ToString();
                guna2GradientTileButton13.Text = "Log Out";
                guna2GradientTileButton11.Visible = true;
            }
            else 
            {
                guna2GradientTileButton13.Text = "Log In";
                guna2GradientTileButton11.Visible = false;
            }
        }
        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            using (Form5 modal = new Form5())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = .50d;
                form.BackColor = Color.Black;
                form.Size = this.Size;
                form.Location = this.Location;
                form.ShowInTaskbar = false;
                form.Show();
                modal.Owner = form;
                parentx = this.Location.X;
                parenty = this.Location.Y;

                modal.ShowDialog();
                form.Dispose();
            }
            loginnamechanges();
        }

        private void guna2GradientTileButton8_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientTileButton10_Click(object sender, EventArgs e)
        {  
            panel1.Hide();
            panel2.Hide();
            panel4.Show();
            guna2Panel4.Hide();
            panel1.Hide();
            guna2Panel7.Hide();
            panel2.Hide(); guna2Panel3.Hide();
            showdataoverdue();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerforlogin_Tick(object sender, EventArgs e)
        {
            login();
            timerforlogin.Start();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public int C3=0;
        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            ButtonStateBlack();
            colorpicked = guna2ComboBox1.Text.ToString();
            C3++;
        }
        public void ButtonStateBlack()
        {
        }
        public static int t3;
        
        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            ButtonStateWhite();
            colorpicked = guna2ComboBox1.Text.ToString();
            t3++;
        }
        public void ButtonStateWhite()
        {
        }

        private void guna2GradientTileButton11_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            using (Form5 modal = new Form5())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = .50d;
                form.BackColor = Color.Black;
                form.Size = this.Size;
                form.Location = this.Location;
                form.ShowInTaskbar = false;
                form.Show();
                modal.Owner = form;
                parentx = this.Location.X;
                parenty = this.Location.Y;

                modal.ShowDialog();
                form.Dispose();
            }
            loginnamechanges();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientTileButton12_Click(object sender, EventArgs e)
        {
            renew();
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        libraryDataSet db=new libraryDataSet();
        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            //db.AcceptChanges();
            //studentdataTableAdapter st12 = new studentdataTableAdapter();
            //var s = st12.GetData();
            //foreach (DataRow row01 in s.Rows)
            //{
            //    if (guna2TextBox1.Text.Equals(row01["Borrowerid"].ToString()))

            //    {
            //        label3.Text = row01["name"].ToString();
            //    }
            //    else
            //    {
            //        label3.Text = "Not Found";
            //    }
            //}
            try
            {
                if (guna2TextBox1.Text != null)
                    using (SqlConnection scon2 = new SqlConnection(connectionstring))
                    {
                        scon2.Open();
                        SqlCommand comm = new SqlCommand("select name from studentdata where Borrowerid like '%"+guna2TextBox1.Text+"%'", scon2);
                        SqlDataReader srd = comm.ExecuteReader();
                        while (srd.Read())
                        {
                            label3.Text = srd.GetValue(0).ToString();
                        }
                        scon2.Close();
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                    label3.Text = "Not Found";
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 ff23=new Form2();
            ff23.ShowDialog();
        }

        private void studentdataGuna2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentdataGuna2DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton9_Click(object sender, EventArgs e)
        {
            guna2Panel6.Show();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientTileButton13_Click_1(object sender, EventArgs e)
        {
            login1();
            loginnamechanges();
        }
        public void login1()
        {
            timer3.Stop();
                Form form = new Form();
                using (Form5 modal = new Form5())
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Opacity = .50d;
                    form.BackColor = Color.Black;
                    form.Size = this.Size;
                    form.Location = this.Location;
                    form.ShowInTaskbar = false;
                    form.Show();
                    modal.Owner = form;
                    parentx = this.Location.X;
                    parenty = this.Location.Y;
                    modal.ShowDialog();
                    form.Dispose();
                    loginnamechanges();
                }
        }
        public void starter()
        {
            timer3.Start();
        }
        private void guna2GradientTileButton15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void guna2GradientTileButton17_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            login1();
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timing();
            timer4.Start();
        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_animation_Tick(object sender, EventArgs e)
        {
            if (parentxx >= j)
            {
                panel1_animation.Stop();
            }
            int xx=panel1.Location.X-5;
            this.Location=new Point(xx, parentyy);
            if (xx <= j)
            {
                panel1_animation.Stop();
            }
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
           
        }
    }
}