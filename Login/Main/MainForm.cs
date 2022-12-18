//Namespaces


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace BarmanStoreProject
{
    public partial class MainForm : Form
    {
        //Declaration of static variables which are used by another class
        internal static MainForm mainform;
        internal static ToolStripMenuItem loginmenuitem;
        internal static ToolStripMenuItem profilemenuitem;
        internal static ToolStripMenuItem resetpasswordmenuitem;
        internal static ToolStripMenuItem signupmenuitem;
        internal static ToolStripMenuItem deleteaccountmenuitem;
        internal static ToolStripMenuItem signoutmenuitem;
        internal static ToolStripMenuItem productsmenuitem;
        internal static ToolStripMenuItem customersmenuitem;
        internal static ToolStripMenuItem distributorsmenuitem;
        internal static ToolStripMenuItem salesmenuitem;
        internal static ToolStripMenuItem adminmenuitem;
        internal static ToolStripStatusLabel statuslabel;
        internal static ToolStripProgressBar progressBar;
        internal static ToolStripStatusLabel activeUserstatusLabel;
        internal static string activeUser;


        public MainForm()

            {
            InitializeComponent();

            //Value assignment of static variables
            mainform = this;
            loginmenuitem = this.loginToolStripMenuItem;
            profilemenuitem = this.profileToolStripMenuItem;
            resetpasswordmenuitem = this.resetPasswordToolStripMenuItem;
            signupmenuitem = this.signUpToolStripMenuItem;
            deleteaccountmenuitem = this.deleteAccountToolStripMenuItem;
            signoutmenuitem = this.signOutToolStripMenuItem;
            productsmenuitem = this.productsToolStripMenuItem;
            customersmenuitem = this.customersToolStripMenuItem;
            distributorsmenuitem = this.distributorsToolStripMenuItem;
            salesmenuitem = this.salesToolStripMenuItem;
            adminmenuitem = this.adminToolStripMenuItem;
            statuslabel = this.toolStripStatusLabel;
            progressBar=this.toolStripProgressBar1;
            activeUserstatusLabel = activeUserToolStripStatusLabel;
            
           
            }

        
        

        
        
        public void MainForm_Load(object sender, System.EventArgs e)
        {

            Views.Startview();
         }
       
        
        


        //menu item functions
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new UserAccount.LoginForm());
            
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Views.OpenMdiForm(new UserAccount.ProfileForm());
            UserAccount.ProfileForm.activeUser = activeUser;
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccount.ResetForm.activeUser = activeUser;
            Views.OpenMdiForm(new UserAccount.ResetForm());
            
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new UserAccount.SignUpForm());
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Your account will be parmanently deleted. Are you sure.......", "DELETE ACCOUNT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)//MessageBox.Show("Your account will be parmanently deleted. Are you sure.......","DELETE ACCOUNT",System.Windows.Forms.NotifyIcon,MessageBoxButtons.YesNo,MessageBoxDefaultButton.Button1)=DialogResult.Yes)
            {
                Data.DeleteAccount(activeUser);
                Views.Startview();
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new Others.AboutForm());
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new Others.HelpForm());
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Startview();
            activeUser = "";
            activeUserToolStripStatusLabel.Text = "Active User :  NONE";
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.CloseMdiChild();
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new Login.AdminForm());
        }

        private void catagoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new Distributors.Distributors());
        }

        private void purchaseBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new VoucherForm());
        }

        private void partiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.OpenMdiForm(new PartiesForm());
        }
    }

    
}




   


