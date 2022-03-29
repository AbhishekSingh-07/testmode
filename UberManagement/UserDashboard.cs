using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberManagement
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer_tick.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnbookurride_Click(object sender, EventArgs e)
        {
            RideBookingfrm ob = new RideBookingfrm();
            ob.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstpage ob = new firstpage();
            ob.Show();
            this.Hide();
        }

        private void timer_tick_Click(object sender, EventArgs e)
        {

        }

        private void viewprofile_Click(object sender, EventArgs e)
        {
            UserProfile ob = new UserProfile();
            ob.Show();
            this.Hide();
        }
    }
}
