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
    public partial class Flight_Details : Form
    {
        AirlineDbEntities db;
        public Flight_Details()
        {
            InitializeComponent();
            db = new AirlineDbEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight_Details fd = new Flight_Details();
            fd.Flight_Name = flightnametxt.Text;
            fd.Source = sourcetxt.Text;
            fd.Destination = destinationtxt.Text;
            fd.Departure = departuretxt.Text;
            fd.Arrival_Time = arrivaltimetxt.Text;
            fd.Flight_Class = flightclasstxt.Text;
            fd.Flight_Charges = Convert.ToDecimal(flightchargestxt.Text);
            fd.Seats = Convert.ToInt16(seatstxt.Text);
            db.Flight_Details.Add(fd);
            db.SaveChanges();
            MessageBox.Show("One Flight Detail Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
