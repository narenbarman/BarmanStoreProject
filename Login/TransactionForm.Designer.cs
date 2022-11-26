namespace BarmanStoreProject
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label trans_amountLabel;
            System.Windows.Forms.Label trans_typeLabel;
            System.Windows.Forms.Label trans_billnoLabel;
            System.Windows.Forms.Label trans_dateLabel;
            System.Windows.Forms.Label party_nameLabel;
            System.Windows.Forms.Label trans_modeLabel;
            System.Windows.Forms.Label chq_partyLabel;
            System.Windows.Forms.Label chq_bankLabel;
            System.Windows.Forms.Label chq_noLabel;
            System.Windows.Forms.Label chq_amountLabel;
            System.Windows.Forms.Label chq_dateLabel;
            System.Windows.Forms.Label upi_idLabel;
            System.Windows.Forms.Label upi_phonenoLabel;
            System.Windows.Forms.Label upi_trnoLabel;
            System.Windows.Forms.Label upi_amountLabel;
            System.Windows.Forms.Label label1;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amount_pendingTextBox = new System.Windows.Forms.TextBox();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bARMANSTOREDATABASEDataSet = new BarmanStoreProject.BARMANSTOREDATABASEDataSet();
            this.trans_amountTextBox = new System.Windows.Forms.TextBox();
            this.trans_typeComboBox = new System.Windows.Forms.ComboBox();
            this.trans_billnoTextBox = new System.Windows.Forms.TextBox();
            this.trans_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.party_nameTextBox = new System.Windows.Forms.TextBox();
            this.trans_modeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chqTab = new System.Windows.Forms.TabPage();
            this.chq_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chq_amountTextBox = new System.Windows.Forms.TextBox();
            this.chq_noTextBox = new System.Windows.Forms.TextBox();
            this.chq_bankTextBox = new System.Windows.Forms.TextBox();
            this.chq_partyTextBox = new System.Windows.Forms.TextBox();
            this.upiTab = new System.Windows.Forms.TabPage();
            this.upi_amountTextBox = new System.Windows.Forms.TextBox();
            this.upi_trnoTextBox = new System.Windows.Forms.TextBox();
            this.upi_phonenoTextBox = new System.Windows.Forms.TextBox();
            this.upi_idTextBox = new System.Windows.Forms.TextBox();
            this.transactionTableAdapter = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.transactionTableAdapter();
            this.tableAdapterManager = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            trans_amountLabel = new System.Windows.Forms.Label();
            trans_typeLabel = new System.Windows.Forms.Label();
            trans_billnoLabel = new System.Windows.Forms.Label();
            trans_dateLabel = new System.Windows.Forms.Label();
            party_nameLabel = new System.Windows.Forms.Label();
            trans_modeLabel = new System.Windows.Forms.Label();
            chq_partyLabel = new System.Windows.Forms.Label();
            chq_bankLabel = new System.Windows.Forms.Label();
            chq_noLabel = new System.Windows.Forms.Label();
            chq_amountLabel = new System.Windows.Forms.Label();
            chq_dateLabel = new System.Windows.Forms.Label();
            upi_idLabel = new System.Windows.Forms.Label();
            upi_phonenoLabel = new System.Windows.Forms.Label();
            upi_trnoLabel = new System.Windows.Forms.Label();
            upi_amountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARMANSTOREDATABASEDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.chqTab.SuspendLayout();
            this.upiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // trans_amountLabel
            // 
            trans_amountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            trans_amountLabel.AutoSize = true;
            trans_amountLabel.Location = new System.Drawing.Point(388, 61);
            trans_amountLabel.Name = "trans_amountLabel";
            trans_amountLabel.Size = new System.Drawing.Size(135, 17);
            trans_amountLabel.TabIndex = 2;
            trans_amountLabel.Text = "Transaction Amount";
            // 
            // trans_typeLabel
            // 
            trans_typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            trans_typeLabel.AutoSize = true;
            trans_typeLabel.Location = new System.Drawing.Point(21, 61);
            trans_typeLabel.Name = "trans_typeLabel";
            trans_typeLabel.Size = new System.Drawing.Size(119, 17);
            trans_typeLabel.TabIndex = 4;
            trans_typeLabel.Text = "Transaction Type";
            // 
            // trans_billnoLabel
            // 
            trans_billnoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            trans_billnoLabel.AutoSize = true;
            trans_billnoLabel.Location = new System.Drawing.Point(21, 111);
            trans_billnoLabel.Name = "trans_billnoLabel";
            trans_billnoLabel.Size = new System.Drawing.Size(48, 17);
            trans_billnoLabel.TabIndex = 6;
            trans_billnoLabel.Text = "Bill No";
            // 
            // trans_dateLabel
            // 
            trans_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            trans_dateLabel.AutoSize = true;
            trans_dateLabel.Location = new System.Drawing.Point(388, 111);
            trans_dateLabel.Name = "trans_dateLabel";
            trans_dateLabel.Size = new System.Drawing.Size(117, 17);
            trans_dateLabel.TabIndex = 8;
            trans_dateLabel.Text = "Transaction Date";
            // 
            // party_nameLabel
            // 
            party_nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            party_nameLabel.AutoSize = true;
            party_nameLabel.Location = new System.Drawing.Point(21, 13);
            party_nameLabel.Name = "party_nameLabel";
            party_nameLabel.Size = new System.Drawing.Size(82, 17);
            party_nameLabel.TabIndex = 10;
            party_nameLabel.Text = "Party Name";
            // 
            // trans_modeLabel
            // 
            trans_modeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            trans_modeLabel.AutoSize = true;
            trans_modeLabel.Location = new System.Drawing.Point(21, 161);
            trans_modeLabel.Name = "trans_modeLabel";
            trans_modeLabel.Size = new System.Drawing.Size(122, 17);
            trans_modeLabel.TabIndex = 12;
            trans_modeLabel.Text = "Transaction Mode";
            // 
            // chq_partyLabel
            // 
            chq_partyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            chq_partyLabel.AutoSize = true;
            chq_partyLabel.Location = new System.Drawing.Point(28, 19);
            chq_partyLabel.Name = "chq_partyLabel";
            chq_partyLabel.Size = new System.Drawing.Size(227, 17);
            chq_partyLabel.TabIndex = 14;
            chq_partyLabel.Text = "Party Name (as per Bank Account)";
            // 
            // chq_bankLabel
            // 
            chq_bankLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            chq_bankLabel.AutoSize = true;
            chq_bankLabel.Location = new System.Drawing.Point(29, 67);
            chq_bankLabel.Name = "chq_bankLabel";
            chq_bankLabel.Size = new System.Drawing.Size(81, 17);
            chq_bankLabel.TabIndex = 16;
            chq_bankLabel.Text = "Bank Name";
            // 
            // chq_noLabel
            // 
            chq_noLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            chq_noLabel.AutoSize = true;
            chq_noLabel.Location = new System.Drawing.Point(396, 67);
            chq_noLabel.Name = "chq_noLabel";
            chq_noLabel.Size = new System.Drawing.Size(79, 17);
            chq_noLabel.TabIndex = 18;
            chq_noLabel.Text = "Cheque No";
            // 
            // chq_amountLabel
            // 
            chq_amountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            chq_amountLabel.AutoSize = true;
            chq_amountLabel.Location = new System.Drawing.Point(29, 119);
            chq_amountLabel.Name = "chq_amountLabel";
            chq_amountLabel.Size = new System.Drawing.Size(109, 17);
            chq_amountLabel.TabIndex = 20;
            chq_amountLabel.Text = "Cheque Amount";
            // 
            // chq_dateLabel
            // 
            chq_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            chq_dateLabel.AutoSize = true;
            chq_dateLabel.Location = new System.Drawing.Point(396, 119);
            chq_dateLabel.Name = "chq_dateLabel";
            chq_dateLabel.Size = new System.Drawing.Size(91, 17);
            chq_dateLabel.TabIndex = 22;
            chq_dateLabel.Text = "Cheque Date";
            // 
            // upi_idLabel
            // 
            upi_idLabel.AutoSize = true;
            upi_idLabel.Location = new System.Drawing.Point(19, 44);
            upi_idLabel.Name = "upi_idLabel";
            upi_idLabel.Size = new System.Drawing.Size(47, 17);
            upi_idLabel.TabIndex = 24;
            upi_idLabel.Text = "UPI ID";
            // 
            // upi_phonenoLabel
            // 
            upi_phonenoLabel.AutoSize = true;
            upi_phonenoLabel.Location = new System.Drawing.Point(19, 99);
            upi_phonenoLabel.Name = "upi_phonenoLabel";
            upi_phonenoLabel.Size = new System.Drawing.Size(71, 17);
            upi_phonenoLabel.TabIndex = 26;
            upi_phonenoLabel.Text = "Phone No";
            // 
            // upi_trnoLabel
            // 
            upi_trnoLabel.AutoSize = true;
            upi_trnoLabel.Location = new System.Drawing.Point(374, 44);
            upi_trnoLabel.Name = "upi_trnoLabel";
            upi_trnoLabel.Size = new System.Drawing.Size(157, 17);
            upi_trnoLabel.TabIndex = 28;
            upi_trnoLabel.Text = "UPI TRANSACTION NO";
            // 
            // upi_amountLabel
            // 
            upi_amountLabel.AutoSize = true;
            upi_amountLabel.Location = new System.Drawing.Point(439, 99);
            upi_amountLabel.Name = "upi_amountLabel";
            upi_amountLabel.Size = new System.Drawing.Size(56, 17);
            upi_amountLabel.TabIndex = 30;
            upi_amountLabel.Text = "Amount";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(388, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 17);
            label1.TabIndex = 14;
            label1.Text = "Amount Pending";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.amount_pendingTextBox);
            this.groupBox1.Controls.Add(trans_amountLabel);
            this.groupBox1.Controls.Add(this.trans_amountTextBox);
            this.groupBox1.Controls.Add(trans_typeLabel);
            this.groupBox1.Controls.Add(this.trans_typeComboBox);
            this.groupBox1.Controls.Add(trans_billnoLabel);
            this.groupBox1.Controls.Add(this.trans_billnoTextBox);
            this.groupBox1.Controls.Add(trans_dateLabel);
            this.groupBox1.Controls.Add(this.trans_dateDateTimePicker);
            this.groupBox1.Controls.Add(party_nameLabel);
            this.groupBox1.Controls.Add(this.party_nameTextBox);
            this.groupBox1.Controls.Add(trans_modeLabel);
            this.groupBox1.Controls.Add(this.trans_modeComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // amount_pendingTextBox
            // 
            this.amount_pendingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amount_pendingTextBox.Location = new System.Drawing.Point(531, 10);
            this.amount_pendingTextBox.Name = "amount_pendingTextBox";
            this.amount_pendingTextBox.Size = new System.Drawing.Size(200, 23);
            this.amount_pendingTextBox.TabIndex = 15;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "transaction";
            this.transactionBindingSource.DataSource = this.bARMANSTOREDATABASEDataSet;
            // 
            // bARMANSTOREDATABASEDataSet
            // 
            this.bARMANSTOREDATABASEDataSet.DataSetName = "BARMANSTOREDATABASEDataSet";
            this.bARMANSTOREDATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trans_amountTextBox
            // 
            this.trans_amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trans_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "trans_amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.trans_amountTextBox.Location = new System.Drawing.Point(531, 58);
            this.trans_amountTextBox.Name = "trans_amountTextBox";
            this.trans_amountTextBox.Size = new System.Drawing.Size(200, 23);
            this.trans_amountTextBox.TabIndex = 3;
            this.trans_amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.trans_amountTextBox_Validating);
            // 
            // trans_typeComboBox
            // 
            this.trans_typeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trans_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "trans_type", true));
            this.trans_typeComboBox.FormattingEnabled = true;
            this.trans_typeComboBox.Items.AddRange(new object[] {
            "Payment",
            "Recieved"});
            this.trans_typeComboBox.Location = new System.Drawing.Point(153, 58);
            this.trans_typeComboBox.Name = "trans_typeComboBox";
            this.trans_typeComboBox.Size = new System.Drawing.Size(200, 24);
            this.trans_typeComboBox.TabIndex = 5;
            // 
            // trans_billnoTextBox
            // 
            this.trans_billnoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trans_billnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "trans_billno", true));
            this.trans_billnoTextBox.Location = new System.Drawing.Point(153, 108);
            this.trans_billnoTextBox.Name = "trans_billnoTextBox";
            this.trans_billnoTextBox.Size = new System.Drawing.Size(200, 23);
            this.trans_billnoTextBox.TabIndex = 7;
            // 
            // trans_dateDateTimePicker
            // 
            this.trans_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trans_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "trans_date", true));
            this.trans_dateDateTimePicker.Location = new System.Drawing.Point(531, 106);
            this.trans_dateDateTimePicker.Name = "trans_dateDateTimePicker";
            this.trans_dateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.trans_dateDateTimePicker.TabIndex = 9;
            // 
            // party_nameTextBox
            // 
            this.party_nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.party_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "party_name", true));
            this.party_nameTextBox.Location = new System.Drawing.Point(153, 10);
            this.party_nameTextBox.Name = "party_nameTextBox";
            this.party_nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.party_nameTextBox.TabIndex = 11;
            // 
            // trans_modeComboBox
            // 
            this.trans_modeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trans_modeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "trans_mode", true));
            this.trans_modeComboBox.FormattingEnabled = true;
            this.trans_modeComboBox.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "UPI"});
            this.trans_modeComboBox.Location = new System.Drawing.Point(153, 158);
            this.trans_modeComboBox.Name = "trans_modeComboBox";
            this.trans_modeComboBox.Size = new System.Drawing.Size(200, 24);
            this.trans_modeComboBox.TabIndex = 13;
            this.trans_modeComboBox.SelectedIndexChanged += new System.EventHandler(this.trans_modeComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.submitButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 30);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(656, -1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(560, -1);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 28);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.chqTab);
            this.tabControl1.Controls.Add(this.upiTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 209);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 200);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // chqTab
            // 
            this.chqTab.Controls.Add(chq_noLabel);
            this.chqTab.Controls.Add(this.chq_dateDateTimePicker);
            this.chqTab.Controls.Add(chq_dateLabel);
            this.chqTab.Controls.Add(this.chq_amountTextBox);
            this.chqTab.Controls.Add(chq_amountLabel);
            this.chqTab.Controls.Add(this.chq_noTextBox);
            this.chqTab.Controls.Add(chq_partyLabel);
            this.chqTab.Controls.Add(this.chq_bankTextBox);
            this.chqTab.Controls.Add(chq_bankLabel);
            this.chqTab.Controls.Add(this.chq_partyTextBox);
            this.chqTab.Location = new System.Drawing.Point(4, 25);
            this.chqTab.Name = "chqTab";
            this.chqTab.Padding = new System.Windows.Forms.Padding(3);
            this.chqTab.Size = new System.Drawing.Size(782, 171);
            this.chqTab.TabIndex = 0;
            this.chqTab.Text = "CHEQUE";
            this.chqTab.UseVisualStyleBackColor = true;
            // 
            // chq_dateDateTimePicker
            // 
            this.chq_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chq_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "chq_date", true));
            this.chq_dateDateTimePicker.Location = new System.Drawing.Point(399, 139);
            this.chq_dateDateTimePicker.Name = "chq_dateDateTimePicker";
            this.chq_dateDateTimePicker.Size = new System.Drawing.Size(328, 23);
            this.chq_dateDateTimePicker.TabIndex = 23;
            // 
            // chq_amountTextBox
            // 
            this.chq_amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chq_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "chq_amount", true));
            this.chq_amountTextBox.Location = new System.Drawing.Point(31, 139);
            this.chq_amountTextBox.Name = "chq_amountTextBox";
            this.chq_amountTextBox.Size = new System.Drawing.Size(339, 23);
            this.chq_amountTextBox.TabIndex = 21;
            // 
            // chq_noTextBox
            // 
            this.chq_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chq_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "chq_no", true));
            this.chq_noTextBox.Location = new System.Drawing.Point(399, 87);
            this.chq_noTextBox.Name = "chq_noTextBox";
            this.chq_noTextBox.Size = new System.Drawing.Size(328, 23);
            this.chq_noTextBox.TabIndex = 19;
            // 
            // chq_bankTextBox
            // 
            this.chq_bankTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chq_bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "chq_bank", true));
            this.chq_bankTextBox.Location = new System.Drawing.Point(32, 87);
            this.chq_bankTextBox.Name = "chq_bankTextBox";
            this.chq_bankTextBox.Size = new System.Drawing.Size(338, 23);
            this.chq_bankTextBox.TabIndex = 17;
            // 
            // chq_partyTextBox
            // 
            this.chq_partyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chq_partyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "chq_party", true));
            this.chq_partyTextBox.Location = new System.Drawing.Point(32, 39);
            this.chq_partyTextBox.Name = "chq_partyTextBox";
            this.chq_partyTextBox.Size = new System.Drawing.Size(695, 23);
            this.chq_partyTextBox.TabIndex = 15;
            // 
            // upiTab
            // 
            this.upiTab.Controls.Add(upi_idLabel);
            this.upiTab.Controls.Add(this.upi_amountTextBox);
            this.upiTab.Controls.Add(upi_amountLabel);
            this.upiTab.Controls.Add(this.upi_trnoTextBox);
            this.upiTab.Controls.Add(upi_trnoLabel);
            this.upiTab.Controls.Add(this.upi_phonenoTextBox);
            this.upiTab.Controls.Add(upi_phonenoLabel);
            this.upiTab.Controls.Add(this.upi_idTextBox);
            this.upiTab.Location = new System.Drawing.Point(4, 25);
            this.upiTab.Name = "upiTab";
            this.upiTab.Padding = new System.Windows.Forms.Padding(3);
            this.upiTab.Size = new System.Drawing.Size(782, 171);
            this.upiTab.TabIndex = 1;
            this.upiTab.Text = "UPI";
            this.upiTab.UseVisualStyleBackColor = true;
            // 
            // upi_amountTextBox
            // 
            this.upi_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "upi_amount", true));
            this.upi_amountTextBox.Location = new System.Drawing.Point(536, 96);
            this.upi_amountTextBox.Name = "upi_amountTextBox";
            this.upi_amountTextBox.Size = new System.Drawing.Size(200, 23);
            this.upi_amountTextBox.TabIndex = 31;
            // 
            // upi_trnoTextBox
            // 
            this.upi_trnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "upi_trno", true));
            this.upi_trnoTextBox.Location = new System.Drawing.Point(536, 41);
            this.upi_trnoTextBox.Name = "upi_trnoTextBox";
            this.upi_trnoTextBox.Size = new System.Drawing.Size(200, 23);
            this.upi_trnoTextBox.TabIndex = 29;
            // 
            // upi_phonenoTextBox
            // 
            this.upi_phonenoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "upi_phoneno", true));
            this.upi_phonenoTextBox.Location = new System.Drawing.Point(116, 96);
            this.upi_phonenoTextBox.Name = "upi_phonenoTextBox";
            this.upi_phonenoTextBox.Size = new System.Drawing.Size(200, 23);
            this.upi_phonenoTextBox.TabIndex = 27;
            // 
            // upi_idTextBox
            // 
            this.upi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "upi_id", true));
            this.upi_idTextBox.Location = new System.Drawing.Point(116, 41);
            this.upi_idTextBox.Name = "upi_idTextBox";
            this.upi_idTextBox.Size = new System.Drawing.Size(200, 23);
            this.upi_idTextBox.TabIndex = 25;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.partyTableAdapter = null;
            this.tableAdapterManager.transactionTableAdapter = this.transactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERACCOUNTTABLETableAdapter = null;
            this.tableAdapterManager.voucher1TableAdapter = null;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(624, 83);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Full Payment";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARMANSTOREDATABASEDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.chqTab.ResumeLayout(false);
            this.chqTab.PerformLayout();
            this.upiTab.ResumeLayout(false);
            this.upiTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chqTab;
        private System.Windows.Forms.TabPage upiTab;
        private BARMANSTOREDATABASEDataSet bARMANSTOREDATABASEDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private BARMANSTOREDATABASEDataSetTableAdapters.transactionTableAdapter transactionTableAdapter;
        private BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox amount_pendingTextBox;
        private System.Windows.Forms.TextBox trans_amountTextBox;
        private System.Windows.Forms.ComboBox trans_typeComboBox;
        private System.Windows.Forms.TextBox trans_billnoTextBox;
        private System.Windows.Forms.DateTimePicker trans_dateDateTimePicker;
        private System.Windows.Forms.TextBox party_nameTextBox;
        private System.Windows.Forms.ComboBox trans_modeComboBox;
        private System.Windows.Forms.DateTimePicker chq_dateDateTimePicker;
        private System.Windows.Forms.TextBox chq_amountTextBox;
        private System.Windows.Forms.TextBox chq_noTextBox;
        private System.Windows.Forms.TextBox chq_bankTextBox;
        private System.Windows.Forms.TextBox chq_partyTextBox;
        private System.Windows.Forms.TextBox upi_amountTextBox;
        private System.Windows.Forms.TextBox upi_trnoTextBox;
        private System.Windows.Forms.TextBox upi_phonenoTextBox;
        private System.Windows.Forms.TextBox upi_idTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}