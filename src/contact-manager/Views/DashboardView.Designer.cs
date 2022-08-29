﻿namespace contact_manager.Views
{
    partial class DashboardView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdCreateNewEmployee = new System.Windows.Forms.Button();
            this.CmdCreateNewCustomer = new System.Windows.Forms.Button();
            this.TcPerson = new System.Windows.Forms.TabControl();
            this.TpCustomer = new System.Windows.Forms.TabPage();
            this.PnlSearchCustomer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TpEmployee = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtSearchEmployee = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TcPerson.SuspendLayout();
            this.TpCustomer.SuspendLayout();
            this.PnlSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.TpEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCreateNewEmployee
            // 
            this.CmdCreateNewEmployee.Location = new System.Drawing.Point(15, 16);
            this.CmdCreateNewEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdCreateNewEmployee.Name = "CmdCreateNewEmployee";
            this.CmdCreateNewEmployee.Size = new System.Drawing.Size(160, 63);
            this.CmdCreateNewEmployee.TabIndex = 0;
            this.CmdCreateNewEmployee.Text = "Neu";
            this.CmdCreateNewEmployee.UseVisualStyleBackColor = true;
            this.CmdCreateNewEmployee.Click += new System.EventHandler(this.CmdCreateNewEmployee_Click);
            // 
            // CmdCreateNewCustomer
            // 
            this.CmdCreateNewCustomer.Location = new System.Drawing.Point(19, 14);
            this.CmdCreateNewCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CmdCreateNewCustomer.Name = "CmdCreateNewCustomer";
            this.CmdCreateNewCustomer.Size = new System.Drawing.Size(168, 63);
            this.CmdCreateNewCustomer.TabIndex = 1;
            this.CmdCreateNewCustomer.Text = "Neu";
            this.CmdCreateNewCustomer.UseVisualStyleBackColor = true;
            this.CmdCreateNewCustomer.Click += new System.EventHandler(this.CmdCreateNewCustomer_Click);
            // 
            // TcPerson
            // 
            this.TcPerson.Controls.Add(this.TpCustomer);
            this.TcPerson.Controls.Add(this.TpEmployee);
            this.TcPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcPerson.Location = new System.Drawing.Point(0, 0);
            this.TcPerson.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TcPerson.Multiline = true;
            this.TcPerson.Name = "TcPerson";
            this.TcPerson.SelectedIndex = 0;
            this.TcPerson.Size = new System.Drawing.Size(3347, 1462);
            this.TcPerson.TabIndex = 19;
            this.TcPerson.Selected += new System.Windows.Forms.TabControlEventHandler(this.TcPerson_Selected);
            // 
            // TpCustomer
            // 
            this.TpCustomer.Controls.Add(this.PnlSearchCustomer);
            this.TpCustomer.Controls.Add(this.dataGridViewCustomer);
            this.TpCustomer.Controls.Add(this.CmdCreateNewCustomer);
            this.TpCustomer.Location = new System.Drawing.Point(10, 58);
            this.TpCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpCustomer.Name = "TpCustomer";
            this.TpCustomer.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpCustomer.Size = new System.Drawing.Size(3327, 1394);
            this.TpCustomer.TabIndex = 0;
            this.TpCustomer.Text = "Kunden";
            this.TpCustomer.UseVisualStyleBackColor = true;
            // 
            // PnlSearchCustomer
            // 
            this.PnlSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlSearchCustomer.Controls.Add(this.pictureBox1);
            this.PnlSearchCustomer.Controls.Add(this.TxtSearchCustomer);
            this.PnlSearchCustomer.Location = new System.Drawing.Point(2623, 8);
            this.PnlSearchCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PnlSearchCustomer.Name = "PnlSearchCustomer";
            this.PnlSearchCustomer.Size = new System.Drawing.Size(685, 82);
            this.PnlSearchCustomer.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::contact_manager.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(619, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.Location = new System.Drawing.Point(7, 11);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.PlaceholderText = "Seach text";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(597, 47);
            this.TxtSearchCustomer.TabIndex = 2;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.streetNameDataGridViewTextBoxColumn,
            this.streetNumberDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(19, 96);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 102;
            this.dataGridViewCustomer.RowTemplate.Height = 25;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(3288, 1268);
            this.dataGridViewCustomer.TabIndex = 3;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            this.dataGridViewCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentDoubleClick);
            // 
            // customerNumberDataGridViewTextBoxColumn
            // 
            this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
            this.customerNumberDataGridViewTextBoxColumn.HeaderText = "Kunden-Nr.";
            this.customerNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
            this.customerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Status";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 250;
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.HeaderText = "Kundentyp";
            this.customerTypeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            this.customerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerTypeDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 250;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 250;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.streetNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            this.streetNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "Nr.";
            this.streetNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            this.streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "PLZ";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.zipCodeDataGridViewTextBoxColumn.Width = 250;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 250;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::contact_manager.Properties.Resources.Edit;
            this.EditColumn.MinimumWidth = 12;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Width = 250;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::contact_manager.Properties.Resources.Delete;
            this.DeleteColumn.MinimumWidth = 12;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 250;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(contact_manager.Models.Data.Customer.Customer);
            // 
            // TpEmployee
            // 
            this.TpEmployee.Controls.Add(this.panel1);
            this.TpEmployee.Controls.Add(this.dataGridViewEmployee);
            this.TpEmployee.Controls.Add(this.CmdCreateNewEmployee);
            this.TpEmployee.Location = new System.Drawing.Point(10, 58);
            this.TpEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpEmployee.Name = "TpEmployee";
            this.TpEmployee.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TpEmployee.Size = new System.Drawing.Size(3327, 1394);
            this.TpEmployee.TabIndex = 1;
            this.TpEmployee.Text = "Mitarbeiter";
            this.TpEmployee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TxtSearchEmployee);
            this.panel1.Location = new System.Drawing.Point(2623, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 82);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::contact_manager.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(619, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Location = new System.Drawing.Point(7, 11);
            this.TxtSearchEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.PlaceholderText = "Seach text";
            this.TxtSearchEmployee.Size = new System.Drawing.Size(597, 47);
            this.TxtSearchEmployee.TabIndex = 2;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.stateDataGridViewTextBoxColumn1,
            this.dateOfBirthDataGridViewTextBoxColumn1,
            this.sexDataGridViewTextBoxColumn1,
            this.streetNameDataGridViewTextBoxColumn1,
            this.streetNumberDataGridViewTextBoxColumn1,
            this.zipCodeDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.dataGridViewEmployee.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(15, 98);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 102;
            this.dataGridViewEmployee.RowTemplate.Height = 25;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(3293, 1268);
            this.dataGridViewEmployee.TabIndex = 5;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            this.dataGridViewEmployee.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentDoubleClick);
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Mitarbeiter-Nr.";
            this.employeeNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            this.employeeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.stateDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            this.stateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn1.Width = 250;
            // 
            // dateOfBirthDataGridViewTextBoxColumn1
            // 
            this.dateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn1.HeaderText = "Geburtstag";
            this.dateOfBirthDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dateOfBirthDataGridViewTextBoxColumn1.Name = "dateOfBirthDataGridViewTextBoxColumn1";
            this.dateOfBirthDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn1.Width = 250;
            // 
            // sexDataGridViewTextBoxColumn1
            // 
            this.sexDataGridViewTextBoxColumn1.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn1.HeaderText = "Geschlecht";
            this.sexDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.sexDataGridViewTextBoxColumn1.Name = "sexDataGridViewTextBoxColumn1";
            this.sexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn1.Width = 250;
            // 
            // streetNameDataGridViewTextBoxColumn1
            // 
            this.streetNameDataGridViewTextBoxColumn1.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn1.HeaderText = "Strasse";
            this.streetNameDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.streetNameDataGridViewTextBoxColumn1.Name = "streetNameDataGridViewTextBoxColumn1";
            this.streetNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.streetNameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // streetNumberDataGridViewTextBoxColumn1
            // 
            this.streetNumberDataGridViewTextBoxColumn1.DataPropertyName = "StreetNumber";
            this.streetNumberDataGridViewTextBoxColumn1.HeaderText = "Nr.";
            this.streetNumberDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.streetNumberDataGridViewTextBoxColumn1.Name = "streetNumberDataGridViewTextBoxColumn1";
            this.streetNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.streetNumberDataGridViewTextBoxColumn1.Width = 250;
            // 
            // zipCodeDataGridViewTextBoxColumn1
            // 
            this.zipCodeDataGridViewTextBoxColumn1.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn1.HeaderText = "PLZ";
            this.zipCodeDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.zipCodeDataGridViewTextBoxColumn1.Name = "zipCodeDataGridViewTextBoxColumn1";
            this.zipCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zipCodeDataGridViewTextBoxColumn1.Width = 250;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "Ort";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::contact_manager.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.MinimumWidth = 12;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 250;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::contact_manager.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.MinimumWidth = 12;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 250;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(contact_manager.Models.Data.Employee.Employee);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3347, 1462);
            this.Controls.Add(this.TcPerson);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardView";
            this.Text = "DashboardView";
            this.TcPerson.ResumeLayout(false);
            this.TpCustomer.ResumeLayout(false);
            this.PnlSearchCustomer.ResumeLayout(false);
            this.PnlSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.TpEmployee.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CmdCreateNewEmployee;
        private Button CmdCreateNewCustomer;
    private TabControl TcPerson;
    private TabPage TpCustomer;
    private TabPage TpEmployee;
    private DataGridView dataGridViewCustomer;
    private TextBox TxtSearchCustomer;
    private DataGridView dataGridViewEmployee;
        private BindingSource customerBindingSource;
        private DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewImageColumn EditColumn;
        private DataGridViewImageColumn DeleteColumn;
        private DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private BindingSource employeeBindingSource;
        private Panel PnlSearchCustomer;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox TxtSearchEmployee;
    }
}
