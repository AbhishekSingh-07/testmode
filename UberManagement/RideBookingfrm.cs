using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace UberManagement
{
    public partial class RideBookingfrm : Form
    {
        SqlConnection conn;
        

        public RideBookingfrm()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDashboard ob = new UserDashboard();
            ob.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void clearall()
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtconum.Text = "";
            txtpuadd.Text = "";
            txtdtadd.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingRide ride = new BookingRide();
           
            ride.Name = txtname.Text;
            ride.Email = txtemail.Text;
            ride.ContactNumber = txtconum.Text;
            ride.PickUpAdd = txtpuadd.Text;
            ride.DestinationAdd = txtdtadd.Text;

            string sql = String.Format("insert into Booked_ride values('{0}','{1}','{2}','{3}','{4}')", ride.Name, ride.Email,ride.ContactNumber, ride.PickUpAdd, ride.DestinationAdd);
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Successfull Enjoy Your Ride. Check your registered mail for driver and cab detail.");
                conn.Close();
            }
            catch (Exception ob)
            {
                MessageBox.Show("data cannot be inserted \n" + ob.Message);

            }
            clearall();
        }

        private void RideBookingfrm_Load(object sender, EventArgs e)
        {

        }

        private void txtdtadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtname.Text, "[^a-z]"))
            {
                MessageBox.Show("do not enter numeric vals");
                txtname.Text = "";
            }
        }

        private void txtadnum_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtconum_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
