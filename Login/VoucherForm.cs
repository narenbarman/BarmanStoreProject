using BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using static System.Net.Mime.MediaTypeNames;

namespace BarmanStoreProject
{
    public partial class VoucherForm : Form
    {
        public VoucherForm()
        {
            InitializeComponent();
            Party_nameComboLoad();
        }

        private void VoucherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.voucher1' table. You can move, or remove it, as needed.
            this.voucher1TableAdapter.FillByVoucherType(this.bARMANSTOREDATABASEDataSet.voucher1, "payment");
            FormStatus();

        }

        private void voucherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voucher1BindingSource.EndEdit();
            //this.voucher1TableAdapter.Update(this.bARMANSTOREDATABASEDataSet.voucher1);
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }
   
        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            FormStatus();
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpeg;, *.jpg;,*.png;";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName);
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

        private void addButton_Click(object sender, EventArgs e)
        {
            this.voucher1BindingSource.AddNew();
            addButton.Enabled = false;
            FormStatus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.voucher1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
            FormStatus();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voucher1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
            FormStatus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            voucher_typeComboBox.SelectedIndex = 0;
            party_nameComboBox.SelectedIndex = 0;
            voucher_noTextBox.Text = "";
            voucher_dateDateTimePicker.Value = DateTime.Now;
            voucher_amountTextBox.Text = "0";
            amount_pandingTextBox.Text = "0";
            addPartyNameButton.Visible = false;
            FormStatus();
        }

        private void addPartyNameButton_Click(object sender, EventArgs e)
        {
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter partyTableAdapter=new partyTableAdapter();
            partyTableAdapter.InsertPartyName(party_nameComboBox.Text);
            //party_nameComboBox.Items.Add(party_nameComboBox.Text);
            //party_nameComboBox.Text = party_nameComboBox.Text;
            addPartyNameButton.Visible = false;
            Party_nameComboLoad();

        }

        private void FormStatus()
        {
            if (addPartyNameButton.Visible == false)

            {
                addButton.Enabled = true;
                modifyButton.Enabled = true;
                saveButton.Enabled = true;
                deleteButton.Enabled = true;
                if ((voucher1TableAdapter.GetDataByVoucherNo(voucher_noTextBox.Text).Rows.Count > 0))
                {
                    addButton.Enabled = true;
                    modifyButton.Enabled = false;
                    saveButton.Enabled = false;
                    deleteButton.Enabled = true;
                    if (!string.IsNullOrEmpty(voucher_typeComboBox.Text)
                        && !string.IsNullOrEmpty(party_nameComboBox.Text)
                        && !string.IsNullOrEmpty(voucher_noTextBox.Text)
                        && !string.IsNullOrEmpty(voucher_dateDateTimePicker.Text)
                        && !string.IsNullOrEmpty(voucher_amountTextBox.Text)
                        && !string.IsNullOrEmpty(amount_pandingTextBox.Text)
                        && CurrencyToDec(voucher_amountTextBox.Text) != 0
                        && CurrencyToDec(amount_pandingTextBox.Text) <= CurrencyToDec(voucher_amountTextBox.Text)
                        )
                    {
                        BARMANSTOREDATABASEDataSet.voucher1DataTable myTable = new BARMANSTOREDATABASEDataSet.voucher1DataTable();
                        voucher1TableAdapter.FillByVoucherNo(myTable, voucher_noTextBox.Text);
                        string voucher_type_org = (string)myTable.Rows[0]["voucher_type"];
                        string party_name_org = (string)myTable.Rows[0]["party_name"];
                        string voucher_no_org = (string)myTable.Rows[0]["voucher_no"];
                        DateTime voucher_date_org = (DateTime)myTable.Rows[0]["voucher_date"];
                        Decimal voucher_amount_org = CurrencyToDec(myTable.Rows[0]["voucher_amount"] + "");
                        Decimal amount_panding_org = CurrencyToDec(myTable.Rows[0]["amount_panding"] + "");
                        System.Drawing.Image image_org = null;
                        if (myTable.Rows[0]["image"] != DBNull.Value)
                        {
                            var ms = new MemoryStream((byte[])myTable.Rows[0]["image"]);
                            image_org = System.Drawing.Image.FromStream(ms);
                        }
                        string voucher_type = (string)voucher_typeComboBox.Text;
                        string party_name = (string)party_nameComboBox.Text;
                        string voucher_no = (string)voucher_noTextBox.Text;
                        DateTime voucher_date = voucher_dateDateTimePicker.Value;
                        decimal voucher_amount = CurrencyToDec(voucher_amountTextBox.Text);
                        decimal amount_panding = CurrencyToDec(amount_pandingTextBox.Text);
                        System.Drawing.Image image = (System.Drawing.Image)imagePictureBox.Image;
                        if (voucher_type == voucher_type_org
                            && party_name == party_name_org
                            && voucher_no == voucher_no_org
                            && voucher_date == voucher_date_org
                            && voucher_amount == voucher_amount_org
                            && amount_panding == amount_panding_org
                            )
                        {
                            modifyButton.Enabled = false;
                        }
                        else modifyButton.Enabled = true;
                    }
                }
                else
                {
                    modifyButton.Enabled = false;
                    saveButton.Enabled = true;
                    deleteButton.Enabled = false;
                    if (string.IsNullOrEmpty(voucher_typeComboBox.Text)
                        || string.IsNullOrEmpty(party_nameComboBox.Text)
                        || string.IsNullOrEmpty(voucher_noTextBox.Text)
                        || string.IsNullOrEmpty(voucher_dateDateTimePicker.Text)
                        || string.IsNullOrEmpty(voucher_amountTextBox.Text)
                        || string.IsNullOrEmpty(amount_pandingTextBox.Text)
                        || CurrencyToDec(voucher_amountTextBox.Text) == 0
                        || CurrencyToDec(amount_pandingTextBox.Text) == 0
                        || CurrencyToDec(amount_pandingTextBox.Text) > CurrencyToDec(voucher_amountTextBox.Text)
                        )
                    {
                        saveButton.Enabled = false;
                    }
                }
            }
            else
            {
                addButton.Enabled = false;
                modifyButton.Enabled = false;
                saveButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void voucher_typeComboBox_Validating(object sender, CancelEventArgs e)
        {
            FormStatus();
        }

        private void voucher_noTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormStatus();
        }

        private void voucher_dateDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            FormStatus();
        }

        private void voucher_amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (voucher1TableAdapter.GetDataByVoucherNo(voucher_noTextBox.Text).Rows.Count > 0)
            {
                if (CurrencyToDec(voucher_amountTextBox.Text) < CurrencyToDec(amount_pandingTextBox.Text))
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                amount_pandingTextBox.Text = voucher_amountTextBox.Text;
            }
            FormStatus();
        }

        private void amount_pandingTextBox_Validated(object sender, EventArgs e)
        {
            FormStatus();
        }


        private void party_nameComboBox_Validating(object sender, CancelEventArgs e)
        {
            addPartyNameButton.Visible = !((string)party_nameComboBox.SelectedItem == party_nameComboBox.Text);
            FormStatus();
        }
        
        internal static decimal CurrencyToDec(string cCurrency)
        {
            string str = cCurrency;
            decimal decval;
            bool convt = decimal.TryParse(str, NumberStyles.Currency,
            CultureInfo.CurrentCulture.NumberFormat, out decval);

            return (decval);

        }

        private void Party_nameComboLoad()
        {
            BARMANSTOREDATABASEDataSet.partyDataTable partyTable = new BARMANSTOREDATABASEDataSet.partyDataTable();
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter partyTableAdapter = new partyTableAdapter();
            partyTableAdapter.Fill(partyTable);
            if(partyTable.Rows.Count>0)
            {
                party_nameComboBox.Items.Clear();
                for (int n=0; n < partyTable.Rows.Count; n++)
                {
                    party_nameComboBox.Items.Add(partyTable.Rows[n][0]);
                }
            }
        }

        private void voucherDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            paymentButton.Visible = false;
            if (voucherDataGridView.SelectedRows.Count > 0)
            {
               string voucher_no=((string)voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[2].Value);
               transactionTableAdapter.FillByBillNo(bARMANSTOREDATABASEDataSet.transaction,voucher_no);
               if ((decimal)voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[5].Value > 0) { paymentButton.Visible = true; }
            }
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            TransactionForm form = new TransactionForm();
                 form.Show();
            form.VoucherMode("Payment", party_nameComboBox.Text, "" + voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[5].Value, amount_pandingTextBox.Text);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            voucher1BindingSource.RemoveCurrent();
        }
    }
}
