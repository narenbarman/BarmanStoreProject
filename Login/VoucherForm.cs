using BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

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
            voucher1TableAdapter.Dispose();
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
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter partyTableAdapter = new partyTableAdapter();
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
                BARMANSTOREDATABASEDataSet.voucher1DataTable _voucher1 = new BARMANSTOREDATABASEDataSet.voucher1DataTable();
                BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter _voucher1TableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter();
                _voucher1TableAdapter.FillByVoucherNo(_voucher1, voucher_noTextBox.Text);
                if ((_voucher1.Rows.Count > 0))
                {
                    _voucher1TableAdapter.Dispose();
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
                        //BARMANSTOREDATABASEDataSet.voucher1DataTable myTable = new BARMANSTOREDATABASEDataSet.voucher1DataTable();
                        _voucher1.Clear();
                        _voucher1TableAdapter.FillByVoucherNo(_voucher1, voucher_noTextBox.Text);
                        _voucher1TableAdapter.Dispose();
                        string voucher_type_org = (string)_voucher1.Rows[0]["voucher_type"];
                        string party_name_org = (string)_voucher1.Rows[0]["party_name"];
                        string voucher_no_org = (string)_voucher1.Rows[0]["voucher_no"];
                        DateTime voucher_date_org = (DateTime)_voucher1.Rows[0]["voucher_date"];
                        Decimal voucher_amount_org = CurrencyToDec(_voucher1.Rows[0]["voucher_amount"] + "");
                        Decimal amount_panding_org = CurrencyToDec(_voucher1.Rows[0]["amount_panding"] + "");
                        System.Drawing.Image image_org = null;
                        if (_voucher1.Rows[0]["image"] != DBNull.Value)
                        {
                            var ms = new MemoryStream((byte[])_voucher1.Rows[0]["image"]);
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

        private void voucher_typeComboBox_Validating(object sender, EventArgs e)
        {
            FormStatus();
        }

        private void voucher_noTextBox_Validating(object sender, EventArgs e)
        {
            FormStatus();
        }

        private void voucher_dateDateTimePicker_Validating(object sender, EventArgs e)
        {
            FormStatus();
        }

        
        private void voucher_amountTextBox_Validating(object sender, EventArgs e)
        {
            BARMANSTOREDATABASEDataSet.voucher1DataTable _voucher1 = new BARMANSTOREDATABASEDataSet.voucher1DataTable();
            BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter _voucher1TableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter();
            _voucher1TableAdapter.FillByVoucherNo(_voucher1, voucher_noTextBox.Text);
            if (_voucher1.Rows.Count > 0)
            {
               if (CurrencyToDec(voucher_amountTextBox.Text) < CurrencyToDec(amount_pandingTextBox.Text))
                {
                   voucher_amountTextBox.Text = "";
                 }
            }
            else
            {
                amount_pandingTextBox.Text = voucher_amountTextBox.Text;
            }
            _voucher1TableAdapter.Dispose();
            FormStatus();
        }

        private void amount_pandingTextBox_Validated(object sender, EventArgs e)
        {
            FormStatus();
        }

        private void party_nameComboBox_Validating(object sender, EventArgs e)
        {
            addPartyNameButton.Visible = true;
            foreach (string partyName in party_nameComboBox.Items)
            {
                if (party_nameComboBox.Text==partyName) addPartyNameButton.Visible=false;
            }
            FormStatus();
        }

        //
        // Summary:
        //     
        //Converts Currency value to decimal value
        //
        //
        //
        //parameter currency value
        //
        //returns decimal value
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
            partyTableAdapter.Dispose();
            if (partyTable.Rows.Count > 0)
            {
                party_nameComboBox.Items.Clear();
                for (int n = 0; n < partyTable.Rows.Count; n++)
                {
                    party_nameComboBox.Items.Add(partyTable.Rows[n][0]);
                }
            }
        }
    
        private void paymentButton_Click(object sender, EventArgs e)
        {
            TransactionForm form = new TransactionForm();
            form.Show();
            form.VoucherMode("Payment", party_nameComboBox.Text, voucher_noTextBox.Text, amount_pandingTextBox.Text);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            voucher1BindingSource.RemoveCurrent();
        }

        private void voucherDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            paymentButton.Visible = false;
            try
            {
               string voucher_no = ((string)voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[1].Value);
               transactionTableAdapter.FillByBillNo(bARMANSTOREDATABASEDataSet.transaction, voucher_no);
                if ((decimal)voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[4].Value > 0)
                {
                    paymentButton.Visible = true;
                    transactionDataGridView.Visible = groupBox2.Visible = true;
                }
            }
            catch {
                transactionDataGridView.Visible = groupBox2.Visible = false;

            }

        }
    }
}
