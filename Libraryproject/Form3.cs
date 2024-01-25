using Libraryproject.libraryDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Libraryproject
{
    public partial class Form3 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void newbookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.newbookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.newbook' table. You can move, or remove it, as needed.
            this.newbookTableAdapter.Fill(this.libraryDataSet.newbook);
            designform();

        }
        libraryDataSet lb = new libraryDataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            newbookBindingSource.EndEdit();
            newbookTableAdapter.Update(libraryDataSet.newbook);

            using (SqlConnection scon1 = new SqlConnection(connectionstring))
            {

                scon1.Open();
                SqlDataAdapter sdata = new SqlDataAdapter("insert into availablebook(Available_books,isbnid) values('" + guna2NumericUpDown1.Value + "','" +gunaTextBox5.Text + "')", scon1);
                DataTable dt11 = new DataTable();
                sdata.Fill(dt11);
                dataGridView1.DataSource = dt11;
            }
        }
        public void designform()
        {
            if (Form1.t3 > 0)
            {

                if (Form1.colorpicked == "Blue")
                {
                }
                if (Form1.colorpicked == "Red")
                { 
                }
                else { }
            }
            else
            {
                if (Form1.colorpicked == "Blue")
                {

                }
                if (Form1.colorpicked == "Red")
                {

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            newbookBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            newbookBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f4 = new Form1();
            f4.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MovePrevious();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MoveNext();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            newbookBindingSource.RemoveCurrent();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MoveFirst();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            newbookBindingSource.MoveLast();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            newbookBindingSource.EndEdit();
            newbookTableAdapter.Update(libraryDataSet.newbook);
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            newbookBindingSource.AddNew();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.newbookTableAdapter.FillBy(this.libraryDataSet.newbook, guna2TextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void iSBN_idToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {

        }

        private void iSBN_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void autherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void autherLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
