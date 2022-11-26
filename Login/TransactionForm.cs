﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }

        private void trans_modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (trans_modeComboBox.SelectedIndex)
            {
                case 0:
                    tabControl1.Visible = false;
                    break;
                case 1:
                    tabControl1.Visible = true;
                    tabControl1.SelectTab(0);
                    break;
                case 2:
                    tabControl1.Visible = true;
                    tabControl1.SelectTab(1);
                    break;
            }
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
    }
}