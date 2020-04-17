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
    public partial class Ticket_Reservation : Form
    {
        AirlineDbEntities db;
        public Ticket_Reservation()
        {
            InitializeComponent();
            db = new AirlineDbEntities();
            BlindSource();
            BlindDestination();
        }

        private void BlindSource()
        {
            var items = db.Flight_Details.ToList();
            SourceCombo.DataSource = items;
            SourceCombo.DisplayMember = "Source";

           //hrow new NotImplementedException();
        }

        private void BlindDestination()
        {
            var items = db.Flight_Details.ToList();
            DestinationCombo.DataSource = items;
            DestinationCombo.DisplayMember = "Destination";
            //hrow new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(SourceCombo.Text!= DestinationCombo.Text)
            {
                dataGridView1.DataSource = db.Flight_Details.Where(a => a.Source.Equals(SourceCombo.Text) &&a.Destination.Equals(DestinationCombo.Text)).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(customeridtxt.Text); 
            var item = db.Customer_Details.Where(a => a.Id == id).FirstOrDefault();
            custnametxt.Text = item.Name;
            fathertxt.Text = item.FatherName;
            dateTimePicker1.Value = (DateTime)item.BirthDate;
            emailtxt.Text = item.Email;
            phonetxt.Text = item.Phone;
            addresstxt.Text = item.Address;
  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var flightid = dataGridView1.SelectedRows[0].Cells[0].Value;
            flightidtxt.Text = flightid.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(seatnotxt.Text) <= 120)
            {
                if (AvailableSeat() == true)
                {
                    Booking booking = new Booking();
                    booking.CustomerId = Convert.ToInt32(customeridtxt.Text);
                    booking.DateofJourny = dateTimePicker2.Value;
                    booking.FlightId = Convert.ToInt32(flightidtxt.Text);
                    booking.Seatno = Convert.ToInt32(seatnotxt.Text);
                    db.Bookings.Add(booking);
                    db.SaveChanges();
                    MessageBox.Show("Add Ticket");
                }
                else
                {
                    MessageBox.Show("Seat is already booked");
                }
            }
            else
            {
                MessageBox.Show("Seat Number is less than 120 or equal to 120");
            }



        }

        private bool AvailableSeat()
        {
            int flightid = Convert.ToInt32(flightidtxt.Text);
            int seatno = Convert.ToInt32(seatnotxt.Text);
            string dateofjourney = dateTimePicker2.Value.ToString("dd/mm/yyyy");
            var item = db.Bookings.Where(a => a.FlightId == flightid && a.Seatno == seatno).FirstOrDefault();
            if (item != null)
            {
                string existsdate = ((DateTime)item.DateofJourny).ToString("dd/mm/yyyy");
                if (existsdate == dateofjourney)

                    return false;

                else

                    return true;

            }
            else
            {
                return true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
