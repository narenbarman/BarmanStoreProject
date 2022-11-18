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
    public partial class ProfileForm : Form
    {
        public static string activeUser = "";
        public ProfileForm()
        {
            InitializeComponent();
        }

        private bool FormValidate()
        {
            bool ans = true;

            return ans;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.uSERACCOUNTTABLEBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
                MessageBox.Show("Profile updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
            uSERACCOUNTTABLETableAdapter.Dispose();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
             this.uSERACCOUNTTABLETableAdapter.FillByUserName(this.bARMANSTOREDATABASEDataSet.USERACCOUNTTABLE,MainForm.activeUser);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName);
            }
        }
    }
}
