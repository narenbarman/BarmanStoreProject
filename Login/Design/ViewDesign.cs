using BarmanStoreProject.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarmanStoreProject
{
    internal class Views
    {

        public static void Startview()
        {
            MainForm.mainform.IsMdiContainer = true;
            MainForm.loginmenuitem.Enabled = true;
            MainForm.profilemenuitem.Enabled = false;
            MainForm.resetpasswordmenuitem.Enabled = false;
            MainForm.signupmenuitem.Enabled = true;
            MainForm.adminmenuitem.Visible = false;
            MainForm.deleteaccountmenuitem.Enabled = false;
            MainForm.signoutmenuitem.Enabled = false;
            MainForm.productsmenuitem.Visible = false;
            MainForm.customersmenuitem.Visible = false;
            MainForm.distributorsmenuitem.Visible = false;
            MainForm.salesmenuitem.Visible = false;
            OpenMdiForm(new UserAccount.LoginForm());
            MainForm.activeUserstatusLabel.Text = "Active User :  NONE";
        }
        public static void Usernview()
        {
            MainForm.loginmenuitem.Enabled = false;
            MainForm.profilemenuitem.Enabled = true;
            MainForm.resetpasswordmenuitem.Enabled = true;
            MainForm.signupmenuitem.Enabled = false;
            MainForm.adminmenuitem.Visible = false;
            MainForm.deleteaccountmenuitem.Enabled = true;
            MainForm.signoutmenuitem.Enabled = true;
            MainForm.signoutmenuitem.Enabled = true;
            MainForm.productsmenuitem.Visible = true;
            MainForm.customersmenuitem.Visible = true;
            MainForm.distributorsmenuitem.Visible = true;
            MainForm.salesmenuitem.Visible = true;
        }
        public static void Adminview()
        {
            MainForm.loginmenuitem.Enabled = false;
            MainForm.profilemenuitem.Enabled = true;
            MainForm.resetpasswordmenuitem.Enabled = true;
            MainForm.signupmenuitem.Enabled = false;
            MainForm.adminmenuitem.Visible = true;
            MainForm.deleteaccountmenuitem.Enabled = true;
            MainForm.signoutmenuitem.Enabled = true;
            MainForm.productsmenuitem.Visible = true;
            MainForm.customersmenuitem.Visible = true;
            MainForm.distributorsmenuitem.Visible = true;
            MainForm.salesmenuitem.Visible = true;
        }
        internal static void OpenMdiForm(Form MdiChildForm)
        {
            CloseMdiChild();
            MdiChildForm.MdiParent =MainForm.mainform;
            MdiChildForm.Dock = DockStyle.Fill;
            MdiChildForm.FormBorderStyle = FormBorderStyle.None;
            MdiChildForm.Show();
            MainForm.statuslabel.Text = MdiChildForm.Text;
            for (int i = 0; i < 101; i++) MainForm.progressBar.Value = i;
        }


        //code to close all mdichild forms
        public static void CloseMdiChild()
        {
            foreach (Form frm in MainForm.mainform.MdiChildren)
            {
                frm.Close();
            }
        }
        internal static void clearText(Control container)
        {
            try
            {
                //'for each txt as control in this(object).control
                foreach (Control txt in container.Controls)
                {
                    //conditioning the txt as control by getting it's type.
                    //the type of txt as control must be textbox.
                    if (txt is TextBox)
                    {
                        //if the object(textbox) is present. The result is, the textbox will be cleared.
                        txt.Text = "";
                    }
                    if (txt is RichTextBox)
                    {
                        txt.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

       
    }
}
