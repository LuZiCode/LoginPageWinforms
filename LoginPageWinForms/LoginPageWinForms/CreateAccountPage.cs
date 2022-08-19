using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginPageWinForms
{
    public partial class CreateAccountPage : Form
    {
        private readonly CreateDTO _createDTO;
        public string conString = "Data Source=DESKTOP-E0NHH7P\\LOGINPAGESQL;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string firstNameChar;
        public string lastNameChar;
        public CreateAccountPage()
        {
            InitializeComponent();

            _createDTO = new CreateDTO()
            {
            };
        }

        private void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void invalidLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_MouseEnter(object sender, EventArgs e)
        {
            toolTipUsername.SetToolTip(usernameLabel, "Username must contain both number  & letters, must be min. 8 characters long");
        }

        private void createButton_Click(object sender, EventArgs e)
        { 
            _createDTO.Firstname = firstnameTextBox.Text;
            _createDTO.Lastname = lastnameTextBox.Text;
            _createDTO.Email = emailTextBox.Text;
            _createDTO.User = usernameTextBox.Text;
            _createDTO.Password = passwordTextBox.Text;

            var f = new CreateAccount_Logic(_createDTO);
            var d = f.CheckRequirements();

            if (d != "") MessageBox.Show(d);
            else
            {
                InsertValuesIntoTable();
                MessageBox.Show(String.Format("The account has now been succesfully created"), "Account Created");
                ResetAllTextBoxes();
            }

        }


        private void ResetAllTextBoxes()
        {
            firstnameTextBox.ResetText();
            lastnameTextBox.ResetText();
            emailTextBox.ResetText();
            usernameTextBox.ResetText();
            passwordTextBox.ResetText();

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertValuesIntoTable()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            //insert values into UserDetails Table

            SqlCommand insertValues = new SqlCommand("insert into UserTable values (@Firstname, @Lastname, @Email, @Username, @UserPassword, @DateCreated)", con);
            insertValues.Parameters.AddWithValue("@Firstname", firstNameChar);
            insertValues.Parameters.AddWithValue("@Lastname", _createDTO.Lastname);
            insertValues.Parameters.AddWithValue("@Email", _createDTO.Email);
            insertValues.Parameters.AddWithValue("@Username", _createDTO.User);
            insertValues.Parameters.AddWithValue("@UserPassword", _createDTO.Password);
            insertValues.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            insertValues.ExecuteNonQuery();
            con.Close();

        }

        private void emailLabel_MouseEnter(object sender, EventArgs e)
        {
            toolTipEmail.SetToolTip(emailLabel, "Use your email to make sure that you're able to recover your account - in case of lost username/password");

        }

        private void passwordLabel_MouseEnter(object sender, EventArgs e)
        {
            toolTipPassword.SetToolTip(passwordLabel, "Use a secure password. Must contain number, letters & special characters, must be min. 8 characters long");

        }

        private void hidePasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '\0')
            {
                hidePasswordButton2.BringToFront();
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void hidePasswordButton2_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                hidePasswordButton.BringToFront();
                passwordTextBox.PasswordChar = '\0';
            }
        }
    }
}
