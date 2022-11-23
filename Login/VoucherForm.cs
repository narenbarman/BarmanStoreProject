using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace BarmanStoreProject
{
    public partial class VoucherForm : Form
    {
        public VoucherForm()
        {
            InitializeComponent();
        }

        private void voucherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void VoucherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.bARMANSTOREDATABASEDataSet.transaction);
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.voucher' table. You can move, or remove it, as needed.
            this.voucherTableAdapter.Fill(this.bARMANSTOREDATABASEDataSet.voucher);
            

        }

        private void voucherBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.voucherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }

        private void voucherBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.voucherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }

        private void voucherBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.voucherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }

        private void voucherBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.voucherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpeg;, *.jpg";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName);
            }
        }

       

        private void scanButton_Click(object sender, EventArgs e)
        {
            ScannerDemo.ScannerForm1 form = new ScannerDemo.ScannerForm1();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.voucherBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voucher_typeComboBox.Text = "Payment";
            //this.Validate();
            //this.voucherBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
        }
    }
}
