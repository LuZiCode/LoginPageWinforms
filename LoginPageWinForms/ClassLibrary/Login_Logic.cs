using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Login_Logic
    {
        public string conString = "Data Source=DESKTOP-E0NHH7P\\LOGINPAGESQL;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        StringBuilder sb = new StringBuilder();
        public string username;
        public string passsword;
        public string CheckLogin(string usernameInput, string passwordInput)
        {
            username = usernameInput;
            passsword = passwordInput;

            if (username.Contains("@")) LoginWithEmail();
            else LoginWithUser();
            return sb.ToString();
        }


        private void LoginWithEmail()
        {
            SqlConnection con = new SqlConnection(conString);

            string querry = "SELECT * FROM UserTable WHERE Email = '" + username + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND UserPassword = '" + passsword + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count <= 0)
            {
                sb.AppendLine("Username/Email or Password does not exist");
            }
        }

        private void LoginWithUser()
        {
            SqlConnection con = new SqlConnection(conString);

            string querry = "SELECT * FROM UserTable WHERE Username = '" + username + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND UserPassword = '" + passsword + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count <= 0)
            {
                sb.AppendLine("Username/Email or Password does not exist");
            }
        }

    }
}
