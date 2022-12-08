using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BarmanStoreProject
{
    public partial class TransactionForm : Form
    {
        
        public TransactionForm()
        {
            InitializeComponent();
            
        }

        private void transactionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.bARMANSTOREDATABASEDataSet.transaction);
            trans_modeComboBox.Enabled = false;
            submitButton.Enabled = false;
        }

        private void trans_modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chq_amountTextBox.Enabled=false;
            upi_amountTextBox.Enabled = false;
            submitButton.Enabled = false;
            switch (trans_modeComboBox.SelectedIndex)
            {
                case 0:
                    clearTab();
                    tabControl1.Visible = false;
                    submitButton.Enabled = (VoucherForm.CurrencyToDec(trans_amountTextBox.Text) > 0 && VoucherForm.CurrencyToDec(trans_amountTextBox.Text) <= VoucherForm.CurrencyToDec(amount_pendingTextBox.Text));
                    
                    break;
                case 1:
                    clearTab();
                    tabControl1.Visible = true;
                    tabControl1.SelectTab(0);
                    chq_amountTextBox.Text = trans_amountTextBox.Text;
                    submitButton.Enabled = false;
                    break;
                case 2:
                    clearTab();
                    tabControl1.Visible = true;
                    tabControl1.SelectTab(1);
                    submitButton.Enabled = false;
                    upi_amountTextBox.Text = trans_amountTextBox.Text;
                    
                    break;
                
            }
        }

        private void clearTab()
        {
            chq_partyTextBox.Text = "";
            chq_bankTextBox.Text = "";
            chq_noTextBox.Text = "";
            chq_amountTextBox.Text = "";
            chq_dateDateTimePicker.Value= DateTime.Today;
            upi_idTextBox.Text = "";
            upi_phonenoTextBox.Text = "";
            upi_trnoTextBox.Text = "";
            upi_amountTextBox.Text = "";
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    trans_modeComboBox.SelectedIndex = 1;
                    break;
                case 1:
                    trans_modeComboBox.SelectedIndex = 2;
                    break;
            }
        }

        public void VoucherMode(string mode,string party_name="",string bill_no="",string amount_pending="")
        {
            
            trans_modeComboBox.SelectedIndex = 0;
            switch (mode)
            {
                
                case "Payment":
                    this.transactionTableAdapter.FillByBillNo(this.bARMANSTOREDATABASEDataSet.transaction,bill_no);

                    this.transactionBindingSource.AddNew();
                    trans_typeComboBox.Text = "Payment";
                    trans_typeComboBox.Enabled=false;
                    party_nameTextBox.Text = party_name;
                    party_nameTextBox.Enabled=false;
                    trans_billnoTextBox.Text = bill_no;
                    trans_billnoTextBox.Enabled = false;
                    amount_pendingTextBox.Text = amount_pending;
                    amount_pendingTextBox.Enabled=false;
                    
                    break;

            }
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                trans_amountTextBox.Text = amount_pendingTextBox.Text; 
            }
        }

        private void trans_amountTextBox_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = (VoucherForm.CurrencyToDec(amount_pendingTextBox.Text) == VoucherForm.CurrencyToDec(trans_amountTextBox.Text));
           
            if (VoucherForm.CurrencyToDec(trans_amountTextBox.Text) > 0 && VoucherForm.CurrencyToDec(trans_amountTextBox.Text) <= VoucherForm.CurrencyToDec(amount_pendingTextBox.Text))
            {
                trans_modeComboBox.SelectedIndex = 0;
                tabControl1.Visible = false;
                trans_modeComboBox.Enabled = true;
                submitButton.Enabled = true;
                errorProvider1.SetError(trans_amountTextBox, null);
            }
            else
            {
                trans_modeComboBox.SelectedIndex = 0;
                tabControl1.Visible = false;
                trans_modeComboBox.Enabled = false;
                submitButton.Enabled = false;
                errorProvider1.SetError(trans_amountTextBox, "Transaction Amount must currency value and" + Environment.NewLine + " less or equel than Amount Pending " + Environment.NewLine + "and greater than 0.00");

            }
        }

        private void ChequeValidate(object sender, EventArgs e)
        {
            submitButton.Enabled = (chq_partyTextBox.Text != ""
                                    && chq_noTextBox.Text!=""
                                    && chq_bankTextBox.Text!=""
                                    && chq_amountTextBox.Text!=""
                                    );
        }

        private void UpiValidating(object sender, EventArgs e)
        {
            submitButton.Enabled = (upi_amountTextBox.Text != "" && upi_phonenoTextBox.Text != "");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter voucher1TableAdapter = 
                new BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter();
            voucher1TableAdapter.UpdateAmountPendingQuery((
                VoucherForm.CurrencyToDec(amount_pendingTextBox.Text) -
                VoucherForm.CurrencyToDec(trans_amountTextBox.Text)),
                trans_billnoTextBox.Text);

            
            this.Validate();
            this.transactionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);
            MessageBox.Show("Transaction Recorded");
            this.Close();
        }
    }
}
