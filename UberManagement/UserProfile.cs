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

namespace UberManagement
{
    public partial class UserProfile : Form
    {
        SqlConnection conn;
       
        public UserProfile()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Userprofiledetails u = new Userprofiledetails();

            Users p = new Users();
            p = u.GetUsersDetails();

            username.Text = p.UserName;
            fullname.Text = p.FullName;
            email.Text = p.Email;
            connum.Text = p.ContactNumber;
            password.Text = p.Password;
            updateme(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard();
            ud.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updateme(Users p)
        {
            
            fullname.Text = p.FullName;
            email.Text = p.Email;
            connum.Text = p.ContactNumber;
            password.Text = p.Password;
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query;
            query = String.Format("update users set  FullName = '{0}', Email = '{1}',ContactNumber = '{2}',Password = '{3}' where UserName =  '{4}' ", username.Text, fullname.Text, email.Text, connum.Text, password.Text);

            MessageBox.Show(query);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("profile details updated");
                conn.Close();
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
            }
        }
    }
}
