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
    public partial class Form7 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.libraryDataSet.staff);

        }

        private void staff_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection scon1 = new SqlConnection(connectionstring))
            {
                scon1.Open();
                SqlDataAdapter sdata1 = new SqlDataAdapter("select staff_ID,staff_name,password,Designation from staff where staff_ID like '%" + staff_IDTextBox.Text + "%'",scon1);
                DataTable dt3 = new DataTable();
                dt3.Clear();
                sdata1.Fill(dt3);
                staffDataGridView.DataSource = dt3;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            using (SqlConnection scon = new SqlConnection(connectionstring))
            {
                scon.Open();
                SqlDataAdapter sdata = new SqlDataAdapter("update staff set staff_ID=,Borrowed_To=DATEADD(week,1,getdate()) where Borrower_Id#" + "#=#" + staff_IDTextBox.Text + "", scon);
                SqlDataAdapter s1data = new SqlDataAdapter("select * from Borrower_Details", scon);
                DataTable dt1 = new DataTable();
                s1data.Fill(dt1);
                staffDataGridView.DataSource = dt1;
            }
        }
    }
}
