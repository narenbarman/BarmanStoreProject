namespace BarmanStoreProject
{
    partial class PartiesForm
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
            System.Windows.Forms.Label party_nameLabel;
            System.Windows.Forms.Label distributor_nameLabel;
            System.Windows.Forms.Label company_nameLabel;
            System.Windows.Forms.Label visiting_dayLabel;
            System.Windows.Forms.Label delivery_dayLabel;
            System.Windows.Forms.Label salesman_nameLabel;
            System.Windows.Forms.Label salesman_contactLabel;
            System.Windows.Forms.Label salesman_emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartiesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.delivery_dayTextBox = new System.Windows.Forms.ComboBox();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bARMANSTOREDATABASEDataSet = new BarmanStoreProject.BARMANSTOREDATABASEDataSet();
            this.visiting_dayTextBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addCompanyButton = new System.Windows.Forms.Button();
            this.addDistributorButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.distributorsComboBox = new System.Windows.Forms.ComboBox();
            this.partyComboBox = new System.Windows.Forms.ComboBox();
            this.salesman_nameTextBox = new System.Windows.Forms.TextBox();
            this.salesman_contactTextBox = new System.Windows.Forms.TextBox();
            this.salesman_emailTextBox = new System.Windows.Forms.TextBox();
            this.partyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.partyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partyTableAdapter = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter();
            this.tableAdapterManager = new BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager();
            party_nameLabel = new System.Windows.Forms.Label();
            distributor_nameLabel = new System.Windows.Forms.Label();
            company_nameLabel = new System.Windows.Forms.Label();
            visiting_dayLabel = new System.Windows.Forms.Label();
            delivery_dayLabel = new System.Windows.Forms.Label();
            salesman_nameLabel = new System.Windows.Forms.Label();
            salesman_contactLabel = new System.Windows.Forms.Label();
            salesman_emailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARMANSTOREDATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingNavigator)).BeginInit();
            this.partyBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // party_nameLabel
            // 
            party_nameLabel.AutoSize = true;
            party_nameLabel.Location = new System.Drawing.Point(13, 49);
            party_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            party_nameLabel.Name = "party_nameLabel";
            party_nameLabel.Size = new System.Drawing.Size(97, 17);
            party_nameLabel.TabIndex = 0;
            party_nameLabel.Text = "PARTY NAME";
            // 
            // distributor_nameLabel
            // 
            distributor_nameLabel.AutoSize = true;
            distributor_nameLabel.Location = new System.Drawing.Point(13, 81);
            distributor_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            distributor_nameLabel.Name = "distributor_nameLabel";
            distributor_nameLabel.Size = new System.Drawing.Size(144, 17);
            distributor_nameLabel.TabIndex = 2;
            distributor_nameLabel.Text = "DISTRIBUTOR NAME";
            // 
            // company_nameLabel
            // 
            company_nameLabel.AutoSize = true;
            company_nameLabel.Location = new System.Drawing.Point(13, 113);
            company_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            company_nameLabel.Name = "company_nameLabel";
            company_nameLabel.Size = new System.Drawing.Size(119, 17);
            company_nameLabel.TabIndex = 4;
            company_nameLabel.Text = "COMPANY NAME";
            // 
            // visiting_dayLabel
            // 
            visiting_dayLabel.AutoSize = true;
            visiting_dayLabel.Location = new System.Drawing.Point(13, 145);
            visiting_dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            visiting_dayLabel.Name = "visiting_dayLabel";
            visiting_dayLabel.Size = new System.Drawing.Size(97, 17);
            visiting_dayLabel.TabIndex = 6;
            visiting_dayLabel.Text = "VISITING DAY";
            // 
            // delivery_dayLabel
            // 
            delivery_dayLabel.AutoSize = true;
            delivery_dayLabel.Location = new System.Drawing.Point(13, 177);
            delivery_dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            delivery_dayLabel.Name = "delivery_dayLabel";
            delivery_dayLabel.Size = new System.Drawing.Size(107, 17);
            delivery_dayLabel.TabIndex = 8;
            delivery_dayLabel.Text = "DELIVERY DAY";
            // 
            // salesman_nameLabel
            // 
            salesman_nameLabel.AutoSize = true;
            salesman_nameLabel.Location = new System.Drawing.Point(13, 209);
            salesman_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salesman_nameLabel.Name = "salesman_nameLabel";
            salesman_nameLabel.Size = new System.Drawing.Size(125, 17);
            salesman_nameLabel.TabIndex = 10;
            salesman_nameLabel.Text = "SALESMAN NAME";
            // 
            // salesman_contactLabel
            // 
            salesman_contactLabel.AutoSize = true;
            salesman_contactLabel.Location = new System.Drawing.Point(13, 241);
            salesman_contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salesman_contactLabel.Name = "salesman_contactLabel";
            salesman_contactLabel.Size = new System.Drawing.Size(177, 17);
            salesman_contactLabel.TabIndex = 12;
            salesman_contactLabel.Text = "SALESMAN CONTACT NO";
            // 
            // salesman_emailLabel
            // 
            salesman_emailLabel.AutoSize = true;
            salesman_emailLabel.Location = new System.Drawing.Point(13, 273);
            salesman_emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salesman_emailLabel.Name = "salesman_emailLabel";
            salesman_emailLabel.Size = new System.Drawing.Size(126, 17);
            salesman_emailLabel.TabIndex = 14;
            salesman_emailLabel.Text = "SALESMAN EMAIL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delivery_dayTextBox);
            this.panel1.Controls.Add(this.visiting_dayTextBox);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.addCompanyButton);
            this.panel1.Controls.Add(this.addDistributorButton);
            this.panel1.Controls.Add(this.companyComboBox);
            this.panel1.Controls.Add(this.distributorsComboBox);
            this.panel1.Controls.Add(this.partyComboBox);
            this.panel1.Controls.Add(party_nameLabel);
            this.panel1.Controls.Add(distributor_nameLabel);
            this.panel1.Controls.Add(company_nameLabel);
            this.panel1.Controls.Add(visiting_dayLabel);
            this.panel1.Controls.Add(delivery_dayLabel);
            this.panel1.Controls.Add(salesman_nameLabel);
            this.panel1.Controls.Add(this.salesman_nameTextBox);
            this.panel1.Controls.Add(salesman_contactLabel);
            this.panel1.Controls.Add(this.salesman_contactTextBox);
            this.panel1.Controls.Add(salesman_emailLabel);
            this.panel1.Controls.Add(this.salesman_emailTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 405);
            this.panel1.TabIndex = 0;
            // 
            // delivery_dayTextBox
            // 
            this.delivery_dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "delivery_day", true));
            this.delivery_dayTextBox.FormattingEnabled = true;
            this.delivery_dayTextBox.Location = new System.Drawing.Point(199, 173);
            this.delivery_dayTextBox.Name = "delivery_dayTextBox";
            this.delivery_dayTextBox.Size = new System.Drawing.Size(365, 24);
            this.delivery_dayTextBox.TabIndex = 25;
            this.delivery_dayTextBox.TextChanged += new System.EventHandler(this.FormValidate);
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "party";
            this.partyBindingSource.DataSource = this.bARMANSTOREDATABASEDataSet;
            // 
            // bARMANSTOREDATABASEDataSet
            // 
            this.bARMANSTOREDATABASEDataSet.DataSetName = "BARMANSTOREDATABASEDataSet";
            this.bARMANSTOREDATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visiting_dayTextBox
            // 
            this.visiting_dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "visiting_day", true));
            this.visiting_dayTextBox.FormattingEnabled = true;
            this.visiting_dayTextBox.Location = new System.Drawing.Point(199, 141);
            this.visiting_dayTextBox.Name = "visiting_dayTextBox";
            this.visiting_dayTextBox.Size = new System.Drawing.Size(365, 24);
            this.visiting_dayTextBox.TabIndex = 24;
            this.visiting_dayTextBox.TextChanged += new System.EventHandler(this.FormValidate);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(448, 327);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(343, 327);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(245, 327);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 29);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // addCompanyButton
            // 
            this.addCompanyButton.Location = new System.Drawing.Point(570, 107);
            this.addCompanyButton.Name = "addCompanyButton";
            this.addCompanyButton.Size = new System.Drawing.Size(120, 29);
            this.addCompanyButton.TabIndex = 20;
            this.addCompanyButton.Text = "Add Company";
            this.addCompanyButton.UseVisualStyleBackColor = true;
            this.addCompanyButton.Visible = false;
            this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
            // 
            // addDistributorButton
            // 
            this.addDistributorButton.Location = new System.Drawing.Point(570, 74);
            this.addDistributorButton.Name = "addDistributorButton";
            this.addDistributorButton.Size = new System.Drawing.Size(120, 29);
            this.addDistributorButton.TabIndex = 19;
            this.addDistributorButton.Text = "Add Distributor";
            this.addDistributorButton.UseVisualStyleBackColor = true;
            this.addDistributorButton.Visible = false;
            this.addDistributorButton.Click += new System.EventHandler(this.addDistributorButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.companyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.partyBindingSource, "company_name", true));
            this.companyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partyBindingSource, "company_name", true));
            this.companyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "company_name", true));
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(199, 109);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(365, 24);
            this.companyComboBox.TabIndex = 18;
            this.companyComboBox.TextChanged += new System.EventHandler(this.companyComboBox_TextChanged);
            // 
            // distributorsComboBox
            // 
            this.distributorsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.distributorsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.distributorsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.partyBindingSource, "distributor_name", true));
            this.distributorsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partyBindingSource, "distributor_name", true));
            this.distributorsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "distributor_name", true));
            this.distributorsComboBox.FormattingEnabled = true;
            this.distributorsComboBox.Location = new System.Drawing.Point(199, 77);
            this.distributorsComboBox.Name = "distributorsComboBox";
            this.distributorsComboBox.Size = new System.Drawing.Size(365, 24);
            this.distributorsComboBox.TabIndex = 17;
            this.distributorsComboBox.TextChanged += new System.EventHandler(this.distributorsComboBox_TextChanged);
            // 
            // partyComboBox
            // 
            this.partyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.partyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.partyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "party_name", true));
            this.partyComboBox.FormattingEnabled = true;
            this.partyComboBox.Location = new System.Drawing.Point(199, 45);
            this.partyComboBox.Name = "partyComboBox";
            this.partyComboBox.Size = new System.Drawing.Size(365, 24);
            this.partyComboBox.TabIndex = 16;
            this.partyComboBox.TextChanged += new System.EventHandler(this.partyComboBox_SelectedIndexChanged);
            // 
            // salesman_nameTextBox
            // 
            this.salesman_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "salesman_name", true));
            this.salesman_nameTextBox.Location = new System.Drawing.Point(199, 205);
            this.salesman_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesman_nameTextBox.Name = "salesman_nameTextBox";
            this.salesman_nameTextBox.Size = new System.Drawing.Size(365, 23);
            this.salesman_nameTextBox.TabIndex = 11;
            this.salesman_nameTextBox.TextChanged += new System.EventHandler(this.FormValidate);
            // 
            // salesman_contactTextBox
            // 
            this.salesman_contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "salesman_contact", true));
            this.salesman_contactTextBox.Location = new System.Drawing.Point(199, 237);
            this.salesman_contactTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesman_contactTextBox.Name = "salesman_contactTextBox";
            this.salesman_contactTextBox.Size = new System.Drawing.Size(365, 23);
            this.salesman_contactTextBox.TabIndex = 13;
            this.salesman_contactTextBox.TextChanged += new System.EventHandler(this.FormValidate);
            // 
            // salesman_emailTextBox
            // 
            this.salesman_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partyBindingSource, "salesman_email", true));
            this.salesman_emailTextBox.Location = new System.Drawing.Point(199, 269);
            this.salesman_emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesman_emailTextBox.Name = "salesman_emailTextBox";
            this.salesman_emailTextBox.Size = new System.Drawing.Size(365, 23);
            this.salesman_emailTextBox.TabIndex = 15;
            this.salesman_emailTextBox.TextChanged += new System.EventHandler(this.FormValidate);
            // 
            // partyBindingNavigator
            // 
            this.partyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partyBindingNavigator.BindingSource = this.partyBindingSource;
            this.partyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.partyBindingNavigatorSaveItem});
            this.partyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partyBindingNavigator.Name = "partyBindingNavigator";
            this.partyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partyBindingNavigator.Size = new System.Drawing.Size(955, 25);
            this.partyBindingNavigator.TabIndex = 1;
            this.partyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // partyBindingNavigatorSaveItem
            // 
            this.partyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partyBindingNavigatorSaveItem.Image")));
            this.partyBindingNavigatorSaveItem.Name = "partyBindingNavigatorSaveItem";
            this.partyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partyBindingNavigatorSaveItem.Text = "Save Data";
            this.partyBindingNavigatorSaveItem.Click += new System.EventHandler(this.partyBindingNavigatorSaveItem_Click);
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.companyTableAdapter = null;
            this.tableAdapterManager.distributorTableAdapter = null;
            this.tableAdapterManager.party1TableAdapter = null;
            this.tableAdapterManager.partyTableAdapter = this.partyTableAdapter;
            this.tableAdapterManager.transactionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERACCOUNTTABLETableAdapter = null;
            this.tableAdapterManager.voucher1TableAdapter = null;
            // 
            // PartiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 405);
            this.Controls.Add(this.partyBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartiesForm";
            this.Text = "PartiesForm";
            this.Load += new System.EventHandler(this.PartiesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bARMANSTOREDATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingNavigator)).EndInit();
            this.partyBindingNavigator.ResumeLayout(false);
            this.partyBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BARMANSTOREDATABASEDataSet bARMANSTOREDATABASEDataSet;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private BARMANSTOREDATABASEDataSetTableAdapters.partyTableAdapter partyTableAdapter;
        private BARMANSTOREDATABASEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton partyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox salesman_nameTextBox;
        private System.Windows.Forms.TextBox salesman_contactTextBox;
        private System.Windows.Forms.TextBox salesman_emailTextBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox distributorsComboBox;
        private System.Windows.Forms.ComboBox partyComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addCompanyButton;
        private System.Windows.Forms.Button addDistributorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox delivery_dayTextBox;
        private System.Windows.Forms.ComboBox visiting_dayTextBox;
    }
}