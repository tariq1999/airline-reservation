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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket_Reservation frm = new Ticket_Reservation();
            frm.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest frm = new Guest();
            frm.ShowDialog();
        }

        private void SearchCustomer_Click(object sender, EventArgs e)
        {
            Search_Customers frm = new Search_Customers();
            frm.ShowDialog();
        }

        private void addNewFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flight_Details frm = new Flight_Details();
            frm.ShowDialog();
        }
    }
}
