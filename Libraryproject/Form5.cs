using Libraryproject.libraryDataSetTableAdapters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraryproject
{
    public partial class Form5 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        int i;
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.libraryDataSet.staff);
            panel2.Hide();
            panel3.Visible= false;
            panel1.Show();
            i = Form1.parenty + 150;
            this.Location = new Point(Form1.parentx + 160, Form1.parenty + 220);
        }
        private void modal_effect_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modal_effect.Stop();
            }
            else
            {
                Opacity += .02;
            }
            int y = Form1.parenty += 3;
            this.Location = new Point(Form1.parentx + 220, y);
            if (y >= i)
            {
                modal_effect.Stop();
            }
        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Hide();
            panel2.Show();
        }
        libraryDataSet db=new libraryDataSet();


        private void button1_Click_1(object sender, EventArgs e)
        {

            /*if (textBox1.Text != null && textBox2.Text!= null)
            {
                if (textBox2.Text == "adibaba@2002")
                {
                    this.Hide();
                    f7.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Passsword");
                }
            }
            else
            {
                MessageBox.Show("Enter Fill Up the Boxes");
            }*/
        }            
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextBox.Text == textBox4.Text)
                {
                    staffBindingSource.EndEdit();
                    staffTableAdapter.Update(libraryDataSet.staff);
                    panel3.Hide();panel2.Hide();
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("Password Does Not Match");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void designationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void designationLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "123876")
            {
                panel1.Hide();
                panel2.Hide(); panel3.Show();
                staffBindingSource.AddNew();
            }
        }
        public static string Log_InNAME;
        public static int t = 0;
        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            DateTime sessionstart = DateTime.Now;

                string password = "";
                using (SqlConnection scon = new SqlConnection(connectionstring))
                {
                    scon.Open();
                    SqlCommand scomm = new SqlCommand("select password from staff where staff_name='" + textBox1.Text + "'", scon);
                    SqlDataReader sread = scomm.ExecuteReader();
                    while (sread.Read())
                    {
                        password = sread.GetValue(0).ToString();
                    }
                    if (password.Equals(textBox2.Text))
                    {
                    SqlDataAdapter sq = new SqlDataAdapter("update table staff",scon);
                        Log_InNAME = textBox1.Text;
                        t++;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Or Id Is Incorrect");
                    }
                }
        }
        void createlogin()
        {
            this.Hide();
        }
        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextBox.Text == textBox4.Text)
                {
                    staffBindingSource.EndEdit();
                    staffTableAdapter.Update(libraryDataSet.staff);
                    panel3.Hide(); panel2.Hide();
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("Password Does Not Match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
    }

