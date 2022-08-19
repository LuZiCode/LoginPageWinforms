using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace LoginPageWinForms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountPage createAccountPage = new CreateAccountPage();
            createAccountPage.Show();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var f = new Login_Logic();
            var d = f.CheckLogin(usernameTextBox.Text, passwordTextBox.Text);

            if (d != "") MessageBox.Show(d);
            else
            {
                MessageBox.Show("Logget ind");
            }
        }
    }
}
