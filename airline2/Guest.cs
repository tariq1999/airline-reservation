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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities();
            Customer_Details customers = new Customer_Details
            {
                Name = nametxt.Text,
                FatherName = fathertxt.Text,
                BirthDate = birthdate.Value,
                Email = emailtxt.Text,
                Phone = phonetxt.Text,
                Address = addresstxt.Text
            };
            db.Customer_Details.Add(customers);
            db.SaveChanges();
            MessageBox.Show("Add one customer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
