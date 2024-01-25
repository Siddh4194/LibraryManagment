using Libraryproject.libraryDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraryproject
{
    public partial class Form6 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form6()
        {
            InitializeComponent();
        }

        public static bool IsValidEmail(string mail)
        {
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return email.IsMatch(mail);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            //bool t = IsValidEmail(guna2TextBox2.Text);
            //if (t)
            //{
            //    using (SqlConnection scon = new SqlConnection(connectionstring))
            //    {
            //        scon.Open();
            //        try
            //        {
            //            SqlDataAdapter sdata = new SqlDataAdapter("insert into studentdata(name,phoneno,email,Borrowerid,branch,male,female,dob) values('" + guna2TextBox1.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox4.Text + "','" + guna2CustomCheckBox1.Checked + "')", scon);
            //            DataTable dt1 = new DataTable();
            //            sdata.Fill(dt1);
            //            SqlDataAdapter sdata1 = new SqlDataAdapter("update availablebook set Available_books=Available_books-1 where isbnid=" + textBox2.Text, scon);
            //            DataTable dt12 = new DataTable();
            //            sdata1.Fill(dt12);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("This Student Alredy Taken A Book" + ex.Message);
            //        }

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Enter Valid Email");
            //}
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }

}
