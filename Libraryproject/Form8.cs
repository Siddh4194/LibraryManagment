using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Libraryproject
{
    
    public partial class Form8 : Form
    {
        string connectionstring = @"Data Source=(localdb)\Local;Initial Catalog=library;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.libraryDataSet.Table);
            // TODO: This line of code loads data into the 'libraryDataSet.history' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void historyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void show()
        {
            
        }
        public static int f1 = 0,f2=0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            f1++;f2--;show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2++;f1--; show();
        }
    }
}
