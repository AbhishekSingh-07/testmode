using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UberManagement
{
    public partial class registerpage : Form
    {
        SqlConnection conn;

        public object txtid { get; private set; }

        public registerpage()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            
            user.UserName = txtusername.Text;
            user.FullName = txtfullname.Text;
            user.Email = txtemail.Text;
            user.ContactNumber = txtconnum.Text;
            user.Password = txtpassword.Text;

           

            string sql = String.Format("insert into users values('{0}','{1}','{2}','{3}','{4}')", user.UserName,user.FullName,user.Email,user.ContactNumber,user.Password  );
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Regitration Successfull.");
                conn.Close();
                loginpage ob = new loginpage();
                ob.Show();
                this.Hide();

            }
            catch (Exception ob)
            {
                MessageBox.Show("data cannot be inserted \n" + ob.Message);
              
            }
            clearall();
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

        private void clearall()
        {
            txtusername.Text = "";
            txtfullname.Text = "";
            txtemail.Text = "";
            txtconnum.Text = "";
            txtpassword.Text = "";
           
        }

        private void btnclear_click(object sender, EventArgs e)
        {
            clearall();
        }


        private void backtologin_Click(object sender, EventArgs e)
        {
            loginpage ob = new loginpage();
            ob.Show();
            this.Hide();
        }


        private void registerpage_Load(object sender, EventArgs e)
        {

        }

       

        private void txtconnum_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtconnum.Text, "[^0-9]"))
            {
                MessageBox.Show("do not enter non numeric values");
                txtconnum.Text = "";
            }
        }

      
    }
 }
