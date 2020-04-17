using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline2
{
    public partial class Search_Customers : Form
    {
        public Search_Customers()
        {
            InitializeComponent();
        }

        private void Search_Customers_Load(object sender, EventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities();
            var items = db.Customer_Details.ToList();
            dataGridView1.DataSource = items;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities();
            var items = db.Customer_Details.Where(a => a.Name.Equals(textBox1.Text)).ToList();
            dataGridView1.DataSource = items;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Customer c1 = new Customer(id);
            c1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
