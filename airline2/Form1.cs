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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlineDbEntities db = new AirlineDbEntities();
            if (usrtxt.Text != string.Empty && passtxt.Text != string.Empty)
            {
                var user = db.Admins.Where(a => a.Username.Equals(usrtxt.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(passtxt.Text))
                    {
                        Main frm = new Main();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username");
                }
            }
            else
            {
                MessageBox.Show("please Fill Username & Password");
            }
        }
    }
}
