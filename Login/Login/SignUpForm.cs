using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BarmanStoreProject.UserAccount
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!Data.NewUserNameAvailable(userNameTextBox.Text) && !string.IsNullOrEmpty(userNameTextBox.Text))
            {
                if (passwordTextBox.Text == repeatPasswordTextBox.Text)
                {
                    if (Regex.IsMatch(passwordTextBox.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,10}$") == true)
                    {
                        if (Data.InsertRecord(firstNameTextBox.Text, lastNameTextBox.Text, middleNameTextBox.Text, sexComboBox.Text, dobDateTimePicker.Text, contactNoTextBox.Text, emailTextBox.Text, addressTextBox.Text, userNameTextBox.Text, passwordTextBox.Text) > 0)
                        {
                         MessageBox.Show("Updated")   ;
                            Views.Startview();
                        }
                    }
                    else errorProvider1.SetError(passwordTextBox, @"Minimum 8 and maximum 10 characters,"+ Environment.NewLine + "at least one uppercase letter,"+ Environment.NewLine + " one lowercase letter,"+ Environment.NewLine + " one number and"+ Environment.NewLine + " one special character:");
                }
                else errorProvider1.SetError(passwordTextBox,"Password and repeat password must be same");
            }
            else errorProvider1.SetError(userNameTextBox,"Username is Unavailable");
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            //ToolTip ftoolTip1=new ToolTip();

            if (!Regex.IsMatch(firstNameTextBox.Text, "^[A-Za-z\\s]+$"))
            {
                firstNameTextBox.Text = "";
                toolTip1.Active = true;
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 100;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.SetToolTip(firstNameTextBox, "Alphabetic characters only allowed");
                //ftoolTip1.Show("Alphabetic characters only allowed", firstNameTextBox);
            }
            else { 
                toolTip1.Active=false;
                //ftoolTip1.Dispose();
                }
            
        }
    

       

       
        private void middleNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(middleNameTextBox.Text, "^[A-Za-z\\s]+$"))
            {
                middleNameTextBox.Text = "";
                toolTip1.Active = true;
                toolTip1.AutoPopDelay = 4000;
                toolTip1.InitialDelay = 600;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.SetToolTip(middleNameTextBox, "Alphabetic characters only allowed");
                //toolTip1.Show("Alphabetic characters only allowed", middleNameTextBox);
            }
            else toolTip1.Active = false;
        }

        private void lastNameTextBox_Validating_1(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(lastNameTextBox.Text, "^[A-Za-z\\s]+$"))
            {
                lastNameTextBox.Text = "";
                toolTip1.Active = true;
                toolTip1.AutoPopDelay = 4000;
                toolTip1.InitialDelay = 600;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.SetToolTip(lastNameTextBox, "Alphabetic characters only allowed");
                //toolTip1.Show("Alphabetic characters only allowed", lastNameTextBox);
            }
            else toolTip1.Active = false;
        }

        private void contactNoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(contactNoTextBox.Text, "^[0-9\\s]+$"))
            {
                contactNoTextBox.Text = "";
                toolTip1.Active = true;
                toolTip1.AutoPopDelay = 4000;
                toolTip1.InitialDelay = 600;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.SetToolTip(contactNoTextBox, "Numeric characters only allowed");
                //toolTip1.Show("Numeric characters only allowed", contactNoTextBox);
            }
            else toolTip1.Active = false;
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(emailTextBox.Text, "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"))
            {
                emailTextBox.Text = "";
                toolTip1.Active = true;
                toolTip1.AutoPopDelay = 4000;
                toolTip1.InitialDelay = 600;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipIcon = ToolTipIcon.Info;
                toolTip1.SetToolTip(emailTextBox, "\"Invalid email id\"example@abc.com");
                //toolTip1.Show("Invalid email id", emailTextBox);
            }
            else toolTip1.Active = false;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
