using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CIMS.BO;

namespace CIMS.DL
{
    public class UserDL
    {
        #region Constructor
        public UserDL()
        {
        }
        #endregion
 
        //Change the Connection String as per your System
        private static SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLExpress;Initial Catalog=CIMS;Integrated Security=true");
        #region Methods
        #region FetchLoginDetails
        public static UserBO FetchLoginDetails(UserBO objUserBO)
        {
            string sUname = objUserBO.Username;
            string sPwd = objUserBO.Password;
 
            UserBO objUserBOReturn = new UserBO();
 
            try
            {
 
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM user_details WHERE Username = @Uname AND Password = @Pwd", conn);
 
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@Uname";
                param1.Value = sUname;
 
                cmd.Parameters.Add(param1);
 
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@Pwd";
                param2.Value = sPwd;
 
                cmd.Parameters.Add(param2);
 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objUserBOReturn.Username = reader["Username"].ToString();
                    objUserBOReturn.Password = reader["Password"].ToString();
 
                }
 
                conn.Close();
                return objUserBOReturn;
 
            }
            catch (Exception e)
            {
                throw e;
            }
 
        }
        #endregion
 
        #region StoreNewUserDetails Method
 
        public static int StoreNewUserDetails(UserBO objUserBO)
        {
            string sUname = objUserBO.Username;
            string sPwd = objUserBO.Password;
 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO user_details (Username, Password) VALUES (@Uname, @Pwd)", conn);
 
                cmd.Parameters.Add(new SqlParameter("@Uname", sUname));
                cmd.Parameters.Add(new SqlParameter("@Pwd", sPwd));
 
                int result = cmd.ExecuteNonQuery();
 
                conn.Close();
 
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
 
        }
 
        #endregion
 
        #endregion
    }
}
