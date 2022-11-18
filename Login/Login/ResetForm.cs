using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BarmanStoreProject.UserAccount
{

    public partial class ResetForm : Form
    {
        public static string activeUser;
        public ResetForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Views.clearText(this);
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (newPasswordTextBox.Text == repeatPasswordTextBox.Text && string.IsNullOrEmpty(newPasswordTextBox.Text)==false)
            {
                if (Data.PasswordValidated(userNameTextBox.Text, oldPasswordTextBox.Text))
                    {
                    if (Regex.IsMatch(newPasswordTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,10}$") == true)
                        {
                            if(Data.UpdatePassword(userNameTextBox.Text, newPasswordTextBox.Text)>0)
                            {
                            MessageBox.Show("Password updated");
                            this.Close();
                            }
                        }
                    else errorProvider1.SetError(oldPasswordTextBox, @"Minimum 8 and maximum 10 characters," + Environment.NewLine + "at least one uppercase letter," + Environment.NewLine + " one lowercase letter," + Environment.NewLine + " one number and" + Environment.NewLine + " one special character:");
                }
                else errorProvider1.SetError(oldPasswordTextBox, "Password not correct");
            }
            else errorProvider1.SetError(newPasswordTextBox, "Password and repeat password are not matched or empty");
              
            newPasswordTextBox.Select();
        }

       

        
        private void ResetForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = ResetForm.activeUser;
        }


    }
}
