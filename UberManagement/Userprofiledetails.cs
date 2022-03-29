using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace UberManagement
{
    class Userprofiledetails
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
       public Users GetUsersDetails( )
        {
            try
            {
                Users user = new Users();
                conn.Open();
                string sql = "select * from users where username='" + loginpage.username  + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user.UserName = reader[0].ToString();
                    user.FullName = reader[1].ToString();
                    user.Email = reader[2].ToString();
                    user.ContactNumber = reader[3].ToString();
                    user.Password = reader[4].ToString();
                   
                   
                }
                return user;
            }
            catch (Exception )
            {
                return null;
            }
        }
    }
}
