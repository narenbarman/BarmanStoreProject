using BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace BarmanStoreProject
{
    public partial class VoucherForm : Form
    {
        private static VoucherForm voucherForm;

        public VoucherForm()
        {
            voucherForm = this;
            InitializeComponent();
            Party_nameComboLoad();         
        }

        private void VoucherForm_Load(object sender, EventArgs e)
        {
            this.RefreshMe();   
        }

        #region image function
        private void imagePictureBox_Click(object sender, EventArgs e)
        {
           System.Drawing.Image image=imagePictureBox.Image;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpeg;, *.jpg;,*.png;";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName);
            }
            updateButton.Enabled = !(imagePictureBox.Image == image);
            
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            ScannerDemo.ScannerForm1 form = new ScannerDemo.ScannerForm1();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Show();
            }
        }
        #endregion

        private void addButton_Click(object sender, EventArgs e)
        {
            this.voucher1BindingSource.AddNew();
            addButton.Enabled = false;
            voucher_noTextBox.Enabled = true;
            deleteButton.Enabled = false;
            this.voucherDataGridView.Enabled = false;
            //FormStatus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                amount_pandingTextBox.Text=voucher_amountTextBox.Text;
                this.Validate();
                this.voucher1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
                saveButton.Enabled=false;
                addButton.Enabled = true;
                voucherDataGridView.Enabled = true;
                MessageBox.Show("Record saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                BARMANSTOREDATABASEDataSet.transactionDataTable _transactions = new BARMANSTOREDATABASEDataSet.transactionDataTable();
                BARMANSTOREDATABASEDataSetTableAdapters.transactionTableAdapter _transactionTableAdapter = new transactionTableAdapter();
                _transactionTableAdapter.FillByBillNo(_transactions, voucher_noTextBox.Text);
                decimal anount_pending = CurrencyToDec(voucher_amountTextBox.Text);
                if (_transactions.Rows.Count>0)
                {
                    for (int i=0;i< _transactions.Rows.Count;i++)
                    {
                        anount_pending = anount_pending - (decimal)_transactions.Rows[i]["trans_amount"];
                    }
                }
                amount_pandingTextBox.Text = anount_pending + "";
                this.Validate();
                this.voucher1BindingSource.EndEdit();
                
                modifyButton.Enabled = false;
                addButton.Enabled = true;
                voucherDataGridView.Enabled = true;
                MessageBox.Show("Record Modified successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        }

        private void addPartyNameButton_Click(object sender, EventArgs e)
        {
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter partyTableAdapter = new partyTableAdapter();
            partyTableAdapter.InsertPartyName(party_nameComboBox.Text.ToUpper());
            addPartyNameButton.Visible = false;
            Party_nameComboLoad();
            party_nameComboBox_Validated(sender,e);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                voucher1BindingSource.RemoveCurrent();
                this.Validate();
                this.voucher1BindingSource.EndEdit();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
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

        private void voucherDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            paymentButton.Visible = false;
            try
            {
                if (voucherDataGridView.CurrentRow !=null)
                {
                    string voucher_no = ((string)voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[1].Value);
                    transactionTableAdapter.FillByBillNo(bARMANSTOREDATABASEDataSet.transaction, voucher_no);
                    if ((decimal)voucherDataGridView.Rows[voucherDataGridView.CurrentRow.Index].Cells[4].Value > 0)
                    {
                        paymentButton.Visible = true;
                        transactionDataGridView.Visible = groupBox2.Visible = true;
                    }
                }
            }
            catch {
                transactionDataGridView.Visible = groupBox2.Visible = false;

            }

        }

        private void ValidateMe(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            modifyButton.Enabled= false;
            if (!addPartyNameButton.Visible)
            { 
               if (!string.IsNullOrEmpty(voucher_typeComboBox.Text)
                  && !string.IsNullOrEmpty(party_nameComboBox.Text)
                  && !string.IsNullOrEmpty(voucher_noTextBox.Text)
                  && !string.IsNullOrEmpty(voucher_dateDateTimePicker.Text)
                  && !string.IsNullOrEmpty(voucher_amountTextBox.Text)
                  && !string.IsNullOrEmpty(amount_pandingTextBox.Text)
                  && CurrencyToDec(voucher_amountTextBox.Text) >= 0
                  && CurrencyToDec(amount_pandingTextBox.Text) <= CurrencyToDec(voucher_amountTextBox.Text)
                  )
                {
                    BARMANSTOREDATABASEDataSet.voucher1DataTable _vouchers =new BARMANSTOREDATABASEDataSet.voucher1DataTable();
                    BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter _voucher1TableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter();
                    _voucher1TableAdapter.FillByVoucherNo(_vouchers, voucher_noTextBox.Text);
                    if (_vouchers.Rows.Count>0)
                    {
                        deleteButton.Enabled = true;
                        addButton.Enabled = true;
                        voucher_noTextBox.Enabled = false;
                        string voucher_type_org = ((string)_vouchers.Rows[0]["voucher_type"]).ToUpper();
                        string party_name_org = ((string)_vouchers.Rows[0]["party_name"]).ToUpper();
                        string voucher_no_org = ((string)_vouchers.Rows[0]["voucher_no"]).ToUpper();
                        DateTime voucher_date_org = (DateTime)_vouchers.Rows[0]["voucher_date"];
                        Decimal voucher_amount_org = (decimal)_vouchers.Rows[0]["voucher_amount"];
                        Decimal amount_panding_org = (decimal)_vouchers.Rows[0]["amount_panding"];

                        string voucher_type = (string)voucher_typeComboBox.Text.ToUpper();
                        string party_name = (string)party_nameComboBox.Text.ToUpper();
                        string voucher_no = (string)voucher_noTextBox.Text.ToUpper();
                        DateTime voucher_date = voucher_dateDateTimePicker.Value;
                        decimal voucher_amount = CurrencyToDec(voucher_amountTextBox.Text);
                        decimal amount_panding = CurrencyToDec(amount_pandingTextBox.Text);
                      /*  MessageBox.Show(voucher_type + "==" + voucher_type_org + "==" + (voucher_type == voucher_type_org)
                                + Environment.NewLine + party_name + "==" + party_name_org + "==" + (party_name == party_name_org)
                                + Environment.NewLine + voucher_no + "==" + voucher_no_org + "==" + (voucher_no == voucher_no_org)
                                + Environment.NewLine + voucher_date + "==" + voucher_date_org + "==" + (voucher_date == voucher_date_org)
                                + Environment.NewLine + voucher_amount + "==" + voucher_amount_org + "==" + (voucher_amount == voucher_amount_org)
                                + Environment.NewLine + amount_panding + "==" + amount_panding_org + "==" + (amount_panding == amount_panding_org)
                                );*/
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
                        else
                        {
                            modifyButton.Enabled = true;
                        }
                    }
                    else
                    {
                        deleteButton.Enabled = false;
                        addButton.Enabled= false;
                        voucher_noTextBox.Enabled= true;
                        saveButton.Enabled= !(_vouchers.Rows.Count > 0);
                    }
                }
               else
                {
                    saveButton.Enabled = false;
                    modifyButton.Enabled = false;
                }    
                
            }
        }

        private void party_nameComboBox_Validated(object sender, EventArgs e)
        {
            BARMANSTOREDATABASEDataSet.partyDataTable parties=new BARMANSTOREDATABASEDataSet.partyDataTable();
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter partyTableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter();
            partyTableAdapter.FillByPartyName(parties,party_nameComboBox.Text);
            addPartyNameButton.Visible = !(parties.Rows.Count>0);
            addButton.Visible=saveButton.Visible=modifyButton.Visible=clearButton.Visible=deleteButton.Visible= (parties.Rows.Count > 0);
            ValidateMe(sender, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.RefreshMe();
        }

        internal static void RefreshVoucherForm()
        {
            voucherForm.RefreshMe();
        }

        private void RefreshMe()
        {
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.voucher1' table. You can move, or remove it, as needed.
            this.voucher1TableAdapter.FillByVoucherType(this.bARMANSTOREDATABASEDataSet.voucher1, "payment");
            voucherDataGridView.Rows[0].Selected= true;
            voucher1TableAdapter.Dispose();
            addButton.Enabled = true;
            voucherDataGridView.Enabled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.voucher1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
                updateButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
