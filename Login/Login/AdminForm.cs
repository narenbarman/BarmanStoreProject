using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarmanStoreProject.Login
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void uSERACCOUNTTABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            uSERACCOUNTTABLEBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(bARMANSTOREDATABASEDataSet);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.USERACCOUNTTABLE' table. You can move, or remove it, as needed.
            uSERACCOUNTTABLETableAdapter.Fill(bARMANSTOREDATABASEDataSet.USERACCOUNTTABLE);
            // TODO: This line of code loads data into the 'bARMANSTOREDATABASEDataSet.USERACCOUNTTABLE' table. You can move, or remove it, as needed.
            uSERACCOUNTTABLETableAdapter.Fill(bARMANSTOREDATABASEDataSet.USERACCOUNTTABLE);

        }

        private void uSERACCOUNTTABLEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            uSERACCOUNTTABLEBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(bARMANSTOREDATABASEDataSet);

        }
    }
}
