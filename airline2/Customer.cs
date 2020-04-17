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
    public partial class Customer : Form
    {
        AirlineDbEntities db;
        static int id = 0;
        public Customer(int ? Id)
        {
            InitializeComponent();
            if (Id!=null)
            {
                button1.Visible = false;
             db=new AirlineDbEntities();
                Customer_Details customer = db.Customer_Details.Where(addresstxt => addresstxt.Id == Id).FirstOrDefault();
                id = customer.Id;
                nametxt.Text = customer.Name;
                fathertxt.Text = customer.FatherName;
                birthdate.Value = (DateTime)customer.BirthDate;
                emailtxt.Text = customer.Email;
                phonetxt.Text = customer.Phone;
                addresstxt.Text = customer.Address;

            }
            else
            {
                button2.Visible = false;
            }
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
            db = new AirlineDbEntities();
            Customer_Details customer = db.Customer_Details.Where(addresstxt => addresstxt.Id == id).FirstOrDefault();
            customer.Name = nametxt.Text;
            customer.FatherName = fathertxt.Text;
            customer.BirthDate = birthdate.Value;
            customer.Email = emailtxt.Text;
            customer.Phone = phonetxt.Text;
            customer.Address = addresstxt.Text;
            db.SaveChanges();
            MessageBox.Show("Record Updated");
        }
    }
}
