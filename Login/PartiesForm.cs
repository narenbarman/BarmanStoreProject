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
    public partial class PartiesForm : Form
    {
        public PartiesForm()
        {
            InitializeComponent();
        }

        private void partyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bARMANSTOREDATABASEDataSet);

        }

        private void PartiesForm_Load(object sender, EventArgs e)
        {
            this.partyTableAdapter.Fill(this.bARMANSTOREDATABASEDataSet.party);

            DistributorComboLoad();
            CompanyComboLoad();
            PartyComboLoad();
        }
        private void DistributorComboLoad()
        {
            BARMANSTOREDATABASEDataSet.distributorDataTable _distributor = new BARMANSTOREDATABASEDataSet.distributorDataTable();
            BARMANSTOREDATABASEDataSetTableAdapters.distributorTableAdapter _distributorAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.distributorTableAdapter();
            _distributorAdapter.Fill(_distributor);
            foreach (DataRow row in _distributor.Rows)
            {
                distributorsComboBox.Items.Add(row[0]);
            }
            _distributorAdapter.Dispose();
            _distributor.Dispose();
        }
        private void CompanyComboLoad()
        {
            BARMANSTOREDATABASEDataSet.companyDataTable _company = new BARMANSTOREDATABASEDataSet.companyDataTable();
            BARMANSTOREDATABASEDataSetTableAdapters.companyTableAdapter _companyAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.companyTableAdapter();
            _companyAdapter.Fill(_company);
            foreach (DataRow row in _company.Rows)
            {
                companyComboBox.Items.Add(row[0]);
            }
            _companyAdapter.Dispose();
            _company.Dispose();
        }
        private void PartyComboLoad()
        {
            BARMANSTOREDATABASEDataSet.partyDataTable _party = new BARMANSTOREDATABASEDataSet.partyDataTable();
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter _partyAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter();
            _partyAdapter.Fill(_party);
            foreach (DataRow row in _party.Rows)
            {
                partyComboBox.Items.Add(row[0]);
            }
            _partyAdapter.Dispose();
            _party.Dispose();
        }

        private void addDistributorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(distributorsComboBox.Text))
                {
                    BARMANSTOREDATABASEDataSetTableAdapters.distributorTableAdapter _tableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.distributorTableAdapter();
                    string dist = distributorsComboBox.Text.ToUpper();
                    _tableAdapter.InsertDistributorQuery(dist);
                    DistributorComboLoad();
                    distributorsComboBox.Text = dist;
                    saveButton.Visible = clearButton.Visible = true;
                    _tableAdapter.Dispose();
                    FormValidate(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addCompanyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(companyComboBox.Text))
                {
                    BARMANSTOREDATABASEDataSetTableAdapters.companyTableAdapter _tableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.companyTableAdapter();
                    string comp = companyComboBox.Text.ToUpper();
                    _tableAdapter.InsertCompanyQuery(comp);
                    CompanyComboLoad();
                    companyComboBox.Text = comp;
                    saveButton.Visible = clearButton.Visible = true;
                    _tableAdapter.Dispose();
                    FormValidate(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void distributorsComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(distributorsComboBox.Text))
                {
                    BARMANSTOREDATABASEDataSetTableAdapters.distributorTableAdapter _tableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.distributorTableAdapter();
                    saveButton.Visible = clearButton.Visible = (_tableAdapter.GetDataByDistributor(distributorsComboBox.Text).Rows.Count > 0);
                    addDistributorButton.Visible = !(_tableAdapter.GetDataByDistributor(distributorsComboBox.Text).Rows.Count > 0);
                    _tableAdapter.Dispose();
                    
                }
                else
                {
                    saveButton.Visible = clearButton.Visible = true;
                    addDistributorButton.Visible = false;
                }
                FormValidate(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void companyComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(companyComboBox.Text))
                {
                    BARMANSTOREDATABASEDataSetTableAdapters.companyTableAdapter _tableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.companyTableAdapter();
                    saveButton.Visible = clearButton.Visible = (_tableAdapter.GetDataByCompany(companyComboBox.Text).Rows.Count > 0);
                    addCompanyButton.Visible = !(_tableAdapter.GetDataByCompany(companyComboBox.Text).Rows.Count > 0);
                    _tableAdapter.Dispose();
                }
                else
                {
                    saveButton.Visible = clearButton.Visible = true;
                    addCompanyButton.Visible = false;
                }
                FormValidate(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormValidate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(partyComboBox.Text))
            {
                BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter _tableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter();
                if (_tableAdapter.GetDataByPartyName(partyComboBox.Text).Rows.Count > 0)
                {
                    saveButton.Text = "Update";
                    if(CheackData())
                    {
                        saveButton.Enabled = false;
                    }
                    else
                    {
                        saveButton.Enabled = true;
                    }

                }
                else
                {
                    saveButton.Text = "Save";
                    saveButton.Enabled = true;
                }
            }
            else
            {
                saveButton.Text = "Save";
                saveButton.Enabled = false;
            }
        }
        private bool CheackData()
        {
            BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter _tableAdapter = new BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter();
            BARMANSTOREDATABASEDataSet.partyDataTable _table = new BARMANSTOREDATABASEDataSet.partyDataTable();
            _tableAdapter.FillByPartyName(_table,partyComboBox.Text);
            if (
                distributorsComboBox.Text == (string)_table.Rows[0]["distributor_name"].ToString()
             && companyComboBox.Text == (string)_table.Rows[0]["company_name"].ToString()
             && visiting_dayTextBox.Text == (string)_table.Rows[0]["visiting_day"].ToString()
             && delivery_dayTextBox.Text == (string)_table.Rows[0]["delivery_day"].ToString()
             && salesman_contactTextBox.Text == (string)_table.Rows[0]["salesman_contact"].ToString()
             && salesman_nameTextBox.Text == (string)_table.Rows[0]["salesman_name"].ToString()
             && salesman_emailTextBox.Text == (string)_table.Rows[0]["salesman_email"].ToString()
                )
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void partyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.partyTableAdapter.Fill(this.bARMANSTOREDATABASEDataSet.party);

            partyBindingSource.Position = partyComboBox.SelectedIndex;
        }
    }
    
}
