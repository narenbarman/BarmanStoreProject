using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BarmanStoreProject.UserAccount
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.LoginValidated(usernameTextBox.Text,passwordTextBox.Text))
            {
                
                MainForm.activeUser = usernameTextBox.Text;
                MainForm.activeUserstatusLabel.Text = @"Active User : " + usernameTextBox.Text;
                this.Close();
            }
            else

                MessageBox.Show("USER NAME OR PASSWORD INVALID");


        }

       

        private void resetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                if (Data.NewUserNameAvailable(usernameTextBox.Text))
                {
                    UserAccount.ResetForm.activeUser = usernameTextBox.Text;
                    Views.OpenMdiForm(new UserAccount.ResetForm());
                }

            
            else MessageBox.Show("User name is invalid");
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views.OpenMdiForm(new UserAccount.SignUpForm());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Views.clearText(this);
            this.Close();

        }




    }
}
