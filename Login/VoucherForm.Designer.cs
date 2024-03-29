﻿namespace BarmanStoreProject
{
    partial class VoucherForm
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
            System.Windows.Forms.Label voucher_typeLabel;
            System.Windows.Forms.Label party_nameLabel;
            System.Windows.Forms.Label voucher_noLabel;
            System.Windows.Forms.Label voucher_dateLabel;
            System.Windows.Forms.Label voucher_amountLabel;
            System.Windows.Forms.Label amount_pandingLabel;
            this.vouchergridPanel = new System.Windows.Forms.TableLayoutPanel();
            this.voucherDataGridView = new System.Windows.Forms.DataGridView();
            this.partynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vouchernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucheramountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountpandingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vouchertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bARMANSTOREDATABASEDataSet = new BarmanStoreProject.BARMANSTOREDATABASEDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPartyNameButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.amount_pandingTextBox = new System.Windows.Forms.TextBox();
            this.voucher_amountTextBox = new System.Windows.Forms.TextBox();
            this.voucher_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.voucher_noTextBox = new System.Windows.Forms.TextBox();
            this.party_nameComboBox = new System.Windows.Forms.ComboBox();
            this.voucher_typeComboBox = new System.Windows.Forms.ComboBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager();
            this.transactionTableAdapter = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.transactionTableAdapter();
            this.voucher1TableAdapter = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter();
            voucher_typeLabel = new System.Windows.Forms.Label();
            party_nameLabel = new System.Windows.Forms.Label();
            voucher_noLabel = new System.Windows.Forms.Label();
            voucher_dateLabel = new System.Windows.Forms.Label();
            voucher_amountLabel = new System.Windows.Forms.Label();
            amount_pandingLabel = new System.Windows.Forms.Label();
            this.vouchergridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voucherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucher1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARMANSTOREDATABASEDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // voucher_typeLabel
            // 
            voucher_typeLabel.AutoSize = true;
            voucher_typeLabel.Location = new System.Drawing.Point(23, 12);
            voucher_typeLabel.Name = "voucher_typeLabel";
            voucher_typeLabel.Size = new System.Drawing.Size(97, 17);
            voucher_typeLabel.TabIndex = 1;
            voucher_typeLabel.Text = "Voucher Type";
            // 
            // party_nameLabel
            // 
            party_nameLabel.AutoSize = true;
            party_nameLabel.Location = new System.Drawing.Point(23, 51);
            party_nameLabel.Name = "party_nameLabel";
            party_nameLabel.Size = new System.Drawing.Size(82, 17);
            party_nameLabel.TabIndex = 3;
            party_nameLabel.Text = "Party Name";
            // 
            // voucher_noLabel
            // 
            voucher_noLabel.AutoSize = true;
            voucher_noLabel.Location = new System.Drawing.Point(23, 90);
            voucher_noLabel.Name = "voucher_noLabel";
            voucher_noLabel.Size = new System.Drawing.Size(48, 17);
            voucher_noLabel.TabIndex = 5;
            voucher_noLabel.Text = "Bill No";
            // 
            // voucher_dateLabel
            // 
            voucher_dateLabel.AutoSize = true;
            voucher_dateLabel.Location = new System.Drawing.Point(22, 132);
            voucher_dateLabel.Name = "voucher_dateLabel";
            voucher_dateLabel.Size = new System.Drawing.Size(60, 17);
            voucher_dateLabel.TabIndex = 7;
            voucher_dateLabel.Text = "Bill Date";
            // 
            // voucher_amountLabel
            // 
            voucher_amountLabel.AutoSize = true;
            voucher_amountLabel.Location = new System.Drawing.Point(22, 172);
            voucher_amountLabel.Name = "voucher_amountLabel";
            voucher_amountLabel.Size = new System.Drawing.Size(78, 17);
            voucher_amountLabel.TabIndex = 9;
            voucher_amountLabel.Text = "Bill Amount";
            // 
            // amount_pandingLabel
            // 
            amount_pandingLabel.AutoSize = true;
            amount_pandingLabel.Location = new System.Drawing.Point(22, 211);
            amount_pandingLabel.Name = "amount_pandingLabel";
            amount_pandingLabel.Size = new System.Drawing.Size(112, 17);
            amount_pandingLabel.TabIndex = 11;
            amount_pandingLabel.Text = "Amount Pending";
            // 
            // vouchergridPanel
            // 
            this.vouchergridPanel.ColumnCount = 1;
            this.vouchergridPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vouchergridPanel.Controls.Add(this.voucherDataGridView, 0, 0);
            this.vouchergridPanel.Controls.Add(this.groupBox1, 0, 1);
            this.vouchergridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vouchergridPanel.Location = new System.Drawing.Point(3, 3);
            this.vouchergridPanel.Name = "vouchergridPanel";
            this.vouchergridPanel.RowCount = 2;
            this.vouchergridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vouchergridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.vouchergridPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.vouchergridPanel.Size = new System.Drawing.Size(519, 519);
            this.vouchergridPanel.TabIndex = 0;
            // 
            // voucherDataGridView
            // 
            this.voucherDataGridView.AutoGenerateColumns = false;
            this.voucherDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.voucherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voucherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partynameDataGridViewTextBoxColumn,
            this.vouchernoDataGridViewTextBoxColumn,
            this.voucherdateDataGridViewTextBoxColumn,
            this.voucheramountDataGridViewTextBoxColumn,
            this.amountpandingDataGridViewTextBoxColumn,
            this.vouchertypeDataGridViewTextBoxColumn});
            this.voucherDataGridView.DataSource = this.voucher1BindingSource;
            this.voucherDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voucherDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.voucherDataGridView.Location = new System.Drawing.Point(3, 3);
            this.voucherDataGridView.MultiSelect = false;
            this.voucherDataGridView.Name = "voucherDataGridView";
            this.voucherDataGridView.ReadOnly = true;
            this.voucherDataGridView.RowHeadersVisible = false;
            this.voucherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.voucherDataGridView.Size = new System.Drawing.Size(513, 263);
            this.voucherDataGridView.TabIndex = 0;
            this.voucherDataGridView.SelectionChanged += new System.EventHandler(this.voucherDataGridView_SelectionChanged);
            // 
            // partynameDataGridViewTextBoxColumn
            // 
            this.partynameDataGridViewTextBoxColumn.DataPropertyName = "party_name";
            this.partynameDataGridViewTextBoxColumn.HeaderText = "PARTY NAME";
            this.partynameDataGridViewTextBoxColumn.Name = "partynameDataGridViewTextBoxColumn";
            this.partynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partynameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vouchernoDataGridViewTextBoxColumn
            // 
            this.vouchernoDataGridViewTextBoxColumn.DataPropertyName = "voucher_no";
            this.vouchernoDataGridViewTextBoxColumn.HeaderText = "BILL NO";
            this.vouchernoDataGridViewTextBoxColumn.Name = "vouchernoDataGridViewTextBoxColumn";
            this.vouchernoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vouchernoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // voucherdateDataGridViewTextBoxColumn
            // 
            this.voucherdateDataGridViewTextBoxColumn.DataPropertyName = "voucher_date";
            this.voucherdateDataGridViewTextBoxColumn.HeaderText = "BILL DATE";
            this.voucherdateDataGridViewTextBoxColumn.Name = "voucherdateDataGridViewTextBoxColumn";
            this.voucherdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucherdateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // voucheramountDataGridViewTextBoxColumn
            // 
            this.voucheramountDataGridViewTextBoxColumn.DataPropertyName = "voucher_amount";
            this.voucheramountDataGridViewTextBoxColumn.HeaderText = "BILL  AMOUNT";
            this.voucheramountDataGridViewTextBoxColumn.Name = "voucheramountDataGridViewTextBoxColumn";
            this.voucheramountDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucheramountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // amountpandingDataGridViewTextBoxColumn
            // 
            this.amountpandingDataGridViewTextBoxColumn.DataPropertyName = "amount_panding";
            this.amountpandingDataGridViewTextBoxColumn.HeaderText = "AMOUNT PENDING";
            this.amountpandingDataGridViewTextBoxColumn.Name = "amountpandingDataGridViewTextBoxColumn";
            this.amountpandingDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountpandingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // vouchertypeDataGridViewTextBoxColumn
            // 
            this.vouchertypeDataGridViewTextBoxColumn.DataPropertyName = "voucher_type";
            this.vouchertypeDataGridViewTextBoxColumn.HeaderText = "VOUCHER TYPE";
            this.vouchertypeDataGridViewTextBoxColumn.Name = "vouchertypeDataGridViewTextBoxColumn";
            this.vouchertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vouchertypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // voucher1BindingSource
            // 
            this.voucher1BindingSource.DataMember = "voucher1";
            this.voucher1BindingSource.DataSource = this.bARMANSTOREDATABASEDataSet;
            // 
            // bARMANSTOREDATABASEDataSet
            // 
            this.bARMANSTOREDATABASEDataSet.DataSetName = "BARMANSTOREDATABASEDataSet";
            this.bARMANSTOREDATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.addPartyNameButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.modifyButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(amount_pandingLabel);
            this.groupBox1.Controls.Add(this.amount_pandingTextBox);
            this.groupBox1.Controls.Add(voucher_amountLabel);
            this.groupBox1.Controls.Add(this.voucher_amountTextBox);
            this.groupBox1.Controls.Add(voucher_dateLabel);
            this.groupBox1.Controls.Add(this.voucher_dateDateTimePicker);
            this.groupBox1.Controls.Add(voucher_noLabel);
            this.groupBox1.Controls.Add(this.voucher_noTextBox);
            this.groupBox1.Controls.Add(party_nameLabel);
            this.groupBox1.Controls.Add(this.party_nameComboBox);
            this.groupBox1.Controls.Add(voucher_typeLabel);
            this.groupBox1.Controls.Add(this.voucher_typeComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(3, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(410, 208);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 30);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addPartyNameButton
            // 
            this.addPartyNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPartyNameButton.Location = new System.Drawing.Point(305, 30);
            this.addPartyNameButton.Name = "addPartyNameButton";
            this.addPartyNameButton.Size = new System.Drawing.Size(71, 59);
            this.addPartyNameButton.TabIndex = 18;
            this.addPartyNameButton.Text = "Add Party Name";
            this.addPartyNameButton.UseVisualStyleBackColor = true;
            this.addPartyNameButton.Visible = false;
            this.addPartyNameButton.Click += new System.EventHandler(this.addPartyNameButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(410, 128);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 30);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(410, 168);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 30);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyButton.Location = new System.Drawing.Point(410, 90);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(95, 30);
            this.modifyButton.TabIndex = 15;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(410, 51);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 30);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(410, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 30);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // amount_pandingTextBox
            // 
            this.amount_pandingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amount_pandingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "amount_panding", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.amount_pandingTextBox.Enabled = false;
            this.amount_pandingTextBox.Location = new System.Drawing.Point(138, 208);
            this.amount_pandingTextBox.Name = "amount_pandingTextBox";
            this.amount_pandingTextBox.Size = new System.Drawing.Size(151, 23);
            this.amount_pandingTextBox.TabIndex = 12;
            this.amount_pandingTextBox.TextChanged += new System.EventHandler(this.ValidateMe);
            // 
            // voucher_amountTextBox
            // 
            this.voucher_amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voucher_amountTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.voucher_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "voucher_amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0.00", "C2"));
            this.voucher_amountTextBox.Location = new System.Drawing.Point(138, 169);
            this.voucher_amountTextBox.Name = "voucher_amountTextBox";
            this.voucher_amountTextBox.Size = new System.Drawing.Size(151, 23);
            this.voucher_amountTextBox.TabIndex = 10;
            this.voucher_amountTextBox.TextChanged += new System.EventHandler(this.ValidateMe);
            // 
            // voucher_dateDateTimePicker
            // 
            this.voucher_dateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voucher_dateDateTimePicker.CustomFormat = "";
            this.voucher_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "voucher_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.voucher_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voucher1BindingSource, "voucher_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.voucher_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.voucher_dateDateTimePicker.Location = new System.Drawing.Point(138, 127);
            this.voucher_dateDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.voucher_dateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.voucher_dateDateTimePicker.Name = "voucher_dateDateTimePicker";
            this.voucher_dateDateTimePicker.Size = new System.Drawing.Size(151, 23);
            this.voucher_dateDateTimePicker.TabIndex = 8;
            this.voucher_dateDateTimePicker.Value = new System.DateTime(2022, 11, 23, 0, 0, 0, 0);
            this.voucher_dateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateMe);
            // 
            // voucher_noTextBox
            // 
            this.voucher_noTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voucher_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "voucher_no", true));
            this.voucher_noTextBox.Location = new System.Drawing.Point(138, 87);
            this.voucher_noTextBox.Name = "voucher_noTextBox";
            this.voucher_noTextBox.Size = new System.Drawing.Size(151, 23);
            this.voucher_noTextBox.TabIndex = 6;
            this.voucher_noTextBox.TextChanged += new System.EventHandler(this.ValidateMe);
            // 
            // party_nameComboBox
            // 
            this.party_nameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.party_nameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.party_nameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.party_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "party_name", true));
            this.party_nameComboBox.FormattingEnabled = true;
            this.party_nameComboBox.Items.AddRange(new object[] {
            "britania",
            "bisk farm"});
            this.party_nameComboBox.Location = new System.Drawing.Point(138, 48);
            this.party_nameComboBox.Name = "party_nameComboBox";
            this.party_nameComboBox.Size = new System.Drawing.Size(151, 24);
            this.party_nameComboBox.TabIndex = 4;
            this.party_nameComboBox.TextChanged += new System.EventHandler(this.ValidateMe);
            this.party_nameComboBox.Validated += new System.EventHandler(this.party_nameComboBox_Validated);
            // 
            // voucher_typeComboBox
            // 
            this.voucher_typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voucher_typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.voucher_typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.voucher_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.voucher1BindingSource, "voucher_type", true));
            this.voucher_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voucher1BindingSource, "voucher_type", true));
            this.voucher_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "voucher_type", true));
            this.voucher_typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voucher_typeComboBox.Items.AddRange(new object[] {
            "Payment",
            "Recieved"});
            this.voucher_typeComboBox.Location = new System.Drawing.Point(138, 9);
            this.voucher_typeComboBox.Name = "voucher_typeComboBox";
            this.voucher_typeComboBox.Size = new System.Drawing.Size(151, 24);
            this.voucher_typeComboBox.TabIndex = 2;
            this.voucher_typeComboBox.SelectedIndexChanged += new System.EventHandler(this.ValidateMe);
            // 
            // scanButton
            // 
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanButton.Location = new System.Drawing.Point(79, 0);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(88, 27);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.59375F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.40625F));
            this.mainPanel.Controls.Add(this.vouchergridPanel, 0, 0);
            this.mainPanel.Controls.Add(this.rightPanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 525F));
            this.mainPanel.Size = new System.Drawing.Size(896, 525);
            this.mainPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.AutoScroll = true;
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.imagePictureBox, 0, 2);
            this.rightPanel.Controls.Add(this.transactionDataGridView, 0, 0);
            this.rightPanel.Controls.Add(this.groupBox2, 0, 1);
            this.rightPanel.Controls.Add(this.groupBox3, 0, 3);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(528, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 4;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.rightPanel.Size = new System.Drawing.Size(365, 519);
            this.rightPanel.TabIndex = 1;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.voucher1BindingSource, "image", true));
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureBox.Location = new System.Drawing.Point(3, 125);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(359, 358);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionDataGridView.AutoGenerateColumns = false;
            this.transactionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14});
            this.transactionDataGridView.DataSource = this.transactionBindingSource;
            this.transactionDataGridView.Enabled = false;
            this.transactionDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.transactionDataGridView.Location = new System.Drawing.Point(3, 3);
            this.transactionDataGridView.MultiSelect = false;
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.RowHeadersVisible = false;
            this.transactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDataGridView.Size = new System.Drawing.Size(359, 85);
            this.transactionDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "trans_Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "TRANS ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "trans_amount";
            this.dataGridViewTextBoxColumn9.HeaderText = "AMOUNT";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "trans_date";
            this.dataGridViewTextBoxColumn12.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "trans_mode";
            this.dataGridViewTextBoxColumn14.HeaderText = "MODE";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "transaction";
            this.transactionBindingSource.DataSource = this.bARMANSTOREDATABASEDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.paymentButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(3, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 25);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voucher1BindingSource, "amount_panding", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // paymentButton
            // 
            this.paymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentButton.Location = new System.Drawing.Point(212, -1);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(141, 27);
            this.paymentButton.TabIndex = 0;
            this.paymentButton.Text = "Make Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.scanButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.Location = new System.Drawing.Point(3, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 27);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(263, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 27);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(169, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 27);
            this.button7.TabIndex = 1;
            this.button7.Text = "Browse";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.partyTableAdapter = null;
            this.tableAdapterManager.transactionTableAdapter = this.transactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERACCOUNTTABLETableAdapter = null;
            this.tableAdapterManager.voucher1TableAdapter = this.voucher1TableAdapter;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // voucher1TableAdapter
            // 
            this.voucher1TableAdapter.ClearBeforeFill = true;
            // 
            // VoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 525);
            this.Controls.Add(this.mainPanel);
            this.Name = "VoucherForm";
            this.Text = "VoucherForm";
            this.Load += new System.EventHandler(this.VoucherForm_Load);
            this.vouchergridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voucherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucher1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARMANSTOREDATABASEDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel vouchergridPanel;
        
        private BARMANSTOREDATABASEDataSet bARMANSTOREDATABASEDataSet;
        private BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private BARMANSTOREDATABASEDataSetTableAdapters.transactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.ComboBox voucher_typeComboBox;
        private System.Windows.Forms.ComboBox party_nameComboBox;
        private System.Windows.Forms.TextBox amount_pandingTextBox;
        private System.Windows.Forms.TextBox voucher_amountTextBox;
        private System.Windows.Forms.DateTimePicker voucher_dateDateTimePicker;
        private System.Windows.Forms.TextBox voucher_noTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button addPartyNameButton;
        private System.Windows.Forms.DataGridView voucherDataGridView;
        private System.Windows.Forms.BindingSource voucher1BindingSource;
        private BARMANSTOREDATABASEDataSetTableAdapters.voucher1TableAdapter voucher1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vouchernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucheramountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountpandingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vouchertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
    }
}