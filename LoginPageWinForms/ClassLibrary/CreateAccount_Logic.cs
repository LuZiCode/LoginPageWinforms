
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class CreateAccount_Logic
    {
        private readonly CreateDTO _createDTO;
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Username;
        public string Password;

        public string conString = "Data Source=DESKTOP-E0NHH7P\\LOGINPAGESQL;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        StringBuilder sb = new StringBuilder();
        
        public CreateAccount_Logic(CreateDTO createDTO)
        {
            _createDTO = createDTO;
            Firstname = createDTO.Firstname;
            Lastname = createDTO.Lastname;
            Email = createDTO.Email;
            Username = createDTO.User;
            Password = createDTO.Password;
        }
        public string CheckRequirements()
        {
            CheckFirstName();
            CheckLastName();
            CheckEmail();
            CheckUsername();
            CheckPassword();
            return sb.ToString();
        }

        private void CheckFirstName()
        {
            if (string.IsNullOrEmpty(Firstname)) sb.AppendLine("Enter a firstname");
            else
            {
                if (Firstname.Any(char.IsDigit)) sb.AppendLine("Please enter a valid firstname");
                else
                {
                    Firstname.ToLower();
                    string nameChar = char.ToUpper(Firstname[0]) + Firstname.Substring(1);
                    nameChar = Firstname;
                }
            }
        }

        private void CheckLastName()
        {
            if (string.IsNullOrEmpty(Lastname)) sb.AppendLine("Enter a lastname");
            else
            {
                if (Firstname.Any(char.IsDigit)) sb.AppendLine("Please enter a valid lastname");
            }
        }

        private void CheckEmail()
        {
            if (string.IsNullOrEmpty(Email)) sb.AppendLine("Enter en email");
            else
            {
                var check = IsValidEmail(Email);

                if (check == false) sb.AppendLine("Enter a valid email");

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    bool exists = false;
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [UserTable] where Email = @Email", con))
                    {
                        cmd.Parameters.AddWithValue("Email", Email);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    if (exists) sb.AppendLine("This email already exist");
                }
            }
        }

        private void CheckUsername()
        {
            if (string.IsNullOrEmpty(Username)) sb.AppendLine("Enter a username");
            else
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    bool exists = false;
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [UserTable] where Username = @Username", con))
                    {
                        cmd.Parameters.AddWithValue("Username", Username);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    if (exists) sb.AppendLine("This user already exist");
                    if (!exists)
                    {
                        if (Username.Length < 8) sb.AppendLine("Username must be min. 8 characters long");
                        if (!Username.Any(char.IsDigit) || !Username.Any(char.IsLetter)) sb.AppendLine("Username must contain letters and numbers");
                        if (!Username.Any(char.IsUpper) || !Username.Any(char.IsLower)) sb.AppendLine("Username must contain CAPITAL and lower letters");
                        var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

                        if (!regexItem.IsMatch(Username)) sb.AppendLine("Username can't contain specialcharacters");
                    }
                }
            }
        }

        private void CheckPassword()
        {
            if (string.IsNullOrEmpty(Password)) sb.AppendLine("Enter a password");
            else
            {
                //check requirements for password
                if (Password.Length < 8) sb.AppendLine("Password must be min. 8 characters long");
                if (!Password.Any(char.IsDigit) || !Password.Any(char.IsLetter)) sb.AppendLine("Password must contain letters and numbers");
                if (!Password.Any(char.IsUpper) || !Password.Any(char.IsLower)) sb.AppendLine("Password must contain CAPITAL and lower letters");

                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

                if (regexItem.IsMatch(Password)) sb.AppendLine("Password must contain min. 1 specialcharacter");
            }
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

    }
}
