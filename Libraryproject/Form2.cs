using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraryproject
{
    public partial class Form2 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
    //    public Form2()
      //  {
        //    InitializeComponent();
        //}

        
       
        public static bool IsValidEmail(string mail)
        {
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return email.IsMatch(mail);
        }   
        int tycse;
        int Basic_Science;
        string borrower;
        public void basicscience(string s1)
        {
            try {
                if (guna2ComboBox1.Text.Equals("Basic Science"))
                {
                    tycse++;
                    borrower = "dc" + Basic_Science;
                }
            }
            catch(Exception e) { 
                basicscience(s1);
            }
        }
        public void ty_cse(string s2)
        {
                    tycse++;
            if (tycse < 10)
            {
                borrower = s2 + "0" + tycse;
            }
            else
            {
                borrower = s2 + tycse;
            }
                    bool t = IsValidEmail(guna2TextBox2.Text.ToString());
                    if (t)
                    {
                        using (SqlConnection scon = new SqlConnection(connectionstring))
                        {
                            scon.Open();
                            try
                            {
                                SqlDataAdapter sdata = new SqlDataAdapter("insert into studentdata(name,phoneno,email,Borrowerid,branch,dob,Gender) values('" + guna2TextBox1.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox2.Text + "','" + borrower + "','" + guna2ComboBox1.Text + "','" + guna2DateTimePicker1.Text + "','" + male + "')", scon);
                                DataTable dt1 = new DataTable();
                                sdata.Fill(dt1);
                            }
                            catch (Exception ex)
                            {
                                ty_cse(s2);
                            }
                        }
                        label4.Text = "Name:-" + guna2TextBox1.Text + "\tPhone No:" + guna2TextBox3.Text + "\nEmail Address:-" + guna2TextBox2.Text + "\nAllocated BorrowerId:" + borrower;
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Email");
                        label2.ForeColor = Color.Red;
                    }        
        }
        string male = "";
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked) { male = "male"; }
            if (guna2CustomCheckBox2.Checked) { male = "female"; }
            ty_cse(guna2ComboBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                guna2CustomCheckBox2.Checked = false;
            }
        }

        private void guna2CustomCheckBox2_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox2.Checked)
            {
                guna2CustomCheckBox1.Checked = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
