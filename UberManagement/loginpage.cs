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
    public partial class loginpage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=UberManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int count = 0;
        public static string username;
        public  string Username()
        {
            return txtusername.ToString();
        }

        public loginpage()
        {
            InitializeComponent();
        }

        private void gotoregister_Click(object sender, EventArgs e)
        {
            registerpage ob = new registerpage();
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtusername.Text.ToString();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where UserName='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count == 0)
                {
                    MessageBox.Show("UserName and Password does not match");
                }
                else
                {
                    this.Hide();
                    UserDashboard ud = new UserDashboard();
                    ud.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("EMPLOYEE ID SHOULD BE IN NUMBERS ONLE!!");

            }
        }

            private void loginpage_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '*';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

       
    }
}
