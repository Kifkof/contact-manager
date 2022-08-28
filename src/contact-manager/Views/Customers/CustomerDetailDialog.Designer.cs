﻿namespace contact_manager.Views.Customers
{
    partial class CustomerDetailDialog
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
      this.LblCustomer = new System.Windows.Forms.Label();
      this.GbNotes = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.GrpCustomerData = new System.Windows.Forms.GroupBox();
      this.TxtCompanyContact = new System.Windows.Forms.TextBox();
      this.CmbCustomerType = new System.Windows.Forms.ComboBox();
      this.LblCompanyContact = new System.Windows.Forms.Label();
      this.LblCustomerType = new System.Windows.Forms.Label();
      this.TxtRole = new System.Windows.Forms.TextBox();
      this.LblCompanyName = new System.Windows.Forms.Label();
      this.TxtDeparment = new System.Windows.Forms.TextBox();
      this.LblDepartment = new System.Windows.Forms.Label();
      this.CmdClose = new System.Windows.Forms.Button();
      this.GrpContactData = new System.Windows.Forms.GroupBox();
      this.TxtFaxBusiness = new System.Windows.Forms.TextBox();
      this.LblFaxBusiness = new System.Windows.Forms.Label();
      this.TxtPhoneBusiness = new System.Windows.Forms.TextBox();
      this.LblPhoneBusiness = new System.Windows.Forms.Label();
      this.TxtPhonePrivate = new System.Windows.Forms.TextBox();
      this.LblPhonePrivate = new System.Windows.Forms.Label();
      this.TxtMail = new System.Windows.Forms.TextBox();
      this.LblMail = new System.Windows.Forms.Label();
      this.GrpAddress = new System.Windows.Forms.GroupBox();
      this.LblCity = new System.Windows.Forms.Label();
      this.TxtCity = new System.Windows.Forms.TextBox();
      this.TxtPostalCode = new System.Windows.Forms.TextBox();
      this.LblPostalCode = new System.Windows.Forms.Label();
      this.TxtStreetNumber = new System.Windows.Forms.TextBox();
      this.LblStreetNumber = new System.Windows.Forms.Label();
      this.TxtStreet = new System.Windows.Forms.TextBox();
      this.LblStreet = new System.Windows.Forms.Label();
      this.GrpPersonalData = new System.Windows.Forms.GroupBox();
      this.TxtNationality = new System.Windows.Forms.TextBox();
      this.LblNationality = new System.Windows.Forms.Label();
      this.MTxtSsn = new System.Windows.Forms.MaskedTextBox();
      this.TxtTitle = new System.Windows.Forms.TextBox();
      this.LblTitle = new System.Windows.Forms.Label();
      this.TxtCustomerId = new System.Windows.Forms.TextBox();
      this.LblCustomerId = new System.Windows.Forms.Label();
      this.LblSsn = new System.Windows.Forms.Label();
      this.LblGender = new System.Windows.Forms.Label();
      this.CmbGender = new System.Windows.Forms.ComboBox();
      this.LblSalutation = new System.Windows.Forms.Label();
      this.TxtFirstName = new System.Windows.Forms.TextBox();
      this.LblStatus = new System.Windows.Forms.Label();
      this.CmbStatus = new System.Windows.Forms.ComboBox();
      this.LblFirstName = new System.Windows.Forms.Label();
      this.TxtLastname = new System.Windows.Forms.TextBox();
      this.LblBirthDate = new System.Windows.Forms.Label();
      this.LblLastname = new System.Windows.Forms.Label();
      this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
      this.CmbSalutation = new System.Windows.Forms.ComboBox();
      this.CmdSave = new System.Windows.Forms.Button();
      this.GbNotes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).BeginInit();
      this.GrpCustomerData.SuspendLayout();
      this.GrpContactData.SuspendLayout();
      this.GrpAddress.SuspendLayout();
      this.GrpPersonalData.SuspendLayout();
      this.SuspendLayout();
      // 
      // LblCustomer
      // 
      this.LblCustomer.AutoSize = true;
      this.LblCustomer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LblCustomer.Location = new System.Drawing.Point(12, 9);
      this.LblCustomer.Name = "LblCustomer";
      this.LblCustomer.Size = new System.Drawing.Size(480, 37);
      this.LblCustomer.TabIndex = 3;
      this.LblCustomer.Text = "Kunde (wird noch mit Infos ergänzt)";
      // 
      // GbNotes
      // 
      this.GbNotes.Controls.Add(this.dataGridView1);
      this.GbNotes.Location = new System.Drawing.Point(12, 347);
      this.GbNotes.Name = "GbNotes";
      this.GbNotes.Size = new System.Drawing.Size(699, 202);
      this.GbNotes.TabIndex = 17;
      this.GbNotes.TabStop = false;
      this.GbNotes.Text = "Notizen";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dataGridView1.DataSource = this.customerNoteBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(3, 19);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(693, 180);
      this.dataGridView1.TabIndex = 18;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Text";
      this.dataGridViewTextBoxColumn1.HeaderText = "Text";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 500;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "CreationTime";
      this.dataGridViewTextBoxColumn2.HeaderText = "Erstellungsdatum";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 150;
      // 
      // customerNoteBindingSource
      // 
      this.customerNoteBindingSource.DataSource = typeof(contact_manager.Models.Data.Customer.CustomerNote);
      // 
      // GrpCustomerData
      // 
      this.GrpCustomerData.Controls.Add(this.TxtCompanyContact);
      this.GrpCustomerData.Controls.Add(this.CmbCustomerType);
      this.GrpCustomerData.Controls.Add(this.LblCompanyContact);
      this.GrpCustomerData.Controls.Add(this.LblCustomerType);
      this.GrpCustomerData.Controls.Add(this.TxtRole);
      this.GrpCustomerData.Controls.Add(this.LblCompanyName);
      this.GrpCustomerData.Controls.Add(this.TxtDeparment);
      this.GrpCustomerData.Controls.Add(this.LblDepartment);
      this.GrpCustomerData.Location = new System.Drawing.Point(740, 56);
      this.GrpCustomerData.Name = "GrpCustomerData";
      this.GrpCustomerData.Size = new System.Drawing.Size(360, 150);
      this.GrpCustomerData.TabIndex = 29;
      this.GrpCustomerData.TabStop = false;
      this.GrpCustomerData.Text = "Kunde";
      // 
      // TxtCompanyContact
      // 
      this.TxtCompanyContact.Location = new System.Drawing.Point(151, 103);
      this.TxtCompanyContact.Name = "TxtCompanyContact";
      this.TxtCompanyContact.Size = new System.Drawing.Size(183, 23);
      this.TxtCompanyContact.TabIndex = 17;
      // 
      // CmbCustomerType
      // 
      this.CmbCustomerType.FormattingEnabled = true;
      this.CmbCustomerType.ItemHeight = 15;
      this.CmbCustomerType.Location = new System.Drawing.Point(151, 74);
      this.CmbCustomerType.Name = "CmbCustomerType";
      this.CmbCustomerType.Size = new System.Drawing.Size(183, 23);
      this.CmbCustomerType.TabIndex = 16;
      // 
      // LblCompanyContact
      // 
      this.LblCompanyContact.AutoSize = true;
      this.LblCompanyContact.Location = new System.Drawing.Point(16, 106);
      this.LblCompanyContact.Name = "LblCompanyContact";
      this.LblCompanyContact.Size = new System.Drawing.Size(88, 15);
      this.LblCompanyContact.TabIndex = 28;
      this.LblCompanyContact.Text = "Kundenkontakt";
      // 
      // LblCustomerType
      // 
      this.LblCustomerType.AutoSize = true;
      this.LblCustomerType.Location = new System.Drawing.Point(16, 77);
      this.LblCustomerType.Name = "LblCustomerType";
      this.LblCustomerType.Size = new System.Drawing.Size(65, 15);
      this.LblCustomerType.TabIndex = 26;
      this.LblCustomerType.Text = "Kundentyp";
      // 
      // TxtRole
      // 
      this.TxtRole.Location = new System.Drawing.Point(151, 16);
      this.TxtRole.Name = "TxtRole";
      this.TxtRole.Size = new System.Drawing.Size(183, 23);
      this.TxtRole.TabIndex = 14;
      // 
      // LblCompanyName
      // 
      this.LblCompanyName.AutoSize = true;
      this.LblCompanyName.Location = new System.Drawing.Point(16, 19);
      this.LblCompanyName.Name = "LblCompanyName";
      this.LblCompanyName.Size = new System.Drawing.Size(74, 15);
      this.LblCompanyName.TabIndex = 24;
      this.LblCompanyName.Text = "Firmenname";
      // 
      // TxtDeparment
      // 
      this.TxtDeparment.Location = new System.Drawing.Point(151, 45);
      this.TxtDeparment.Name = "TxtDeparment";
      this.TxtDeparment.Size = new System.Drawing.Size(183, 23);
      this.TxtDeparment.TabIndex = 15;
      // 
      // LblDepartment
      // 
      this.LblDepartment.AutoSize = true;
      this.LblDepartment.Location = new System.Drawing.Point(16, 48);
      this.LblDepartment.Name = "LblDepartment";
      this.LblDepartment.Size = new System.Drawing.Size(59, 15);
      this.LblDepartment.TabIndex = 11;
      this.LblDepartment.Text = "Abteilung";
      // 
      // CmdClose
      // 
      this.CmdClose.Location = new System.Drawing.Point(1064, 682);
      this.CmdClose.Name = "CmdClose";
      this.CmdClose.Size = new System.Drawing.Size(75, 23);
      this.CmdClose.TabIndex = 31;
      this.CmdClose.Text = "Schliessen";
      this.CmdClose.UseVisualStyleBackColor = true;
      this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
      // 
      // GrpContactData
      // 
      this.GrpContactData.Controls.Add(this.TxtFaxBusiness);
      this.GrpContactData.Controls.Add(this.LblFaxBusiness);
      this.GrpContactData.Controls.Add(this.TxtPhoneBusiness);
      this.GrpContactData.Controls.Add(this.LblPhoneBusiness);
      this.GrpContactData.Controls.Add(this.TxtPhonePrivate);
      this.GrpContactData.Controls.Add(this.LblPhonePrivate);
      this.GrpContactData.Controls.Add(this.TxtMail);
      this.GrpContactData.Controls.Add(this.LblMail);
      this.GrpContactData.Location = new System.Drawing.Point(740, 254);
      this.GrpContactData.Name = "GrpContactData";
      this.GrpContactData.Size = new System.Drawing.Size(359, 143);
      this.GrpContactData.TabIndex = 28;
      this.GrpContactData.TabStop = false;
      this.GrpContactData.Text = "Kontaktangaben";
      // 
      // TxtFaxBusiness
      // 
      this.TxtFaxBusiness.Location = new System.Drawing.Point(161, 103);
      this.TxtFaxBusiness.Name = "TxtFaxBusiness";
      this.TxtFaxBusiness.Size = new System.Drawing.Size(183, 23);
      this.TxtFaxBusiness.TabIndex = 21;
      // 
      // LblFaxBusiness
      // 
      this.LblFaxBusiness.AutoSize = true;
      this.LblFaxBusiness.Location = new System.Drawing.Point(6, 106);
      this.LblFaxBusiness.Name = "LblFaxBusiness";
      this.LblFaxBusiness.Size = new System.Drawing.Size(74, 15);
      this.LblFaxBusiness.TabIndex = 32;
      this.LblFaxBusiness.Text = "Fax Geschäft";
      // 
      // TxtPhoneBusiness
      // 
      this.TxtPhoneBusiness.Location = new System.Drawing.Point(161, 74);
      this.TxtPhoneBusiness.Name = "TxtPhoneBusiness";
      this.TxtPhoneBusiness.Size = new System.Drawing.Size(183, 23);
      this.TxtPhoneBusiness.TabIndex = 20;
      // 
      // LblPhoneBusiness
      // 
      this.LblPhoneBusiness.AutoSize = true;
      this.LblPhoneBusiness.Location = new System.Drawing.Point(6, 77);
      this.LblPhoneBusiness.Name = "LblPhoneBusiness";
      this.LblPhoneBusiness.Size = new System.Drawing.Size(73, 15);
      this.LblPhoneBusiness.TabIndex = 30;
      this.LblPhoneBusiness.Text = "Tel. Geschäft";
      // 
      // TxtPhonePrivate
      // 
      this.TxtPhonePrivate.Location = new System.Drawing.Point(161, 45);
      this.TxtPhonePrivate.Name = "TxtPhonePrivate";
      this.TxtPhonePrivate.Size = new System.Drawing.Size(183, 23);
      this.TxtPhonePrivate.TabIndex = 19;
      // 
      // LblPhonePrivate
      // 
      this.LblPhonePrivate.AutoSize = true;
      this.LblPhonePrivate.Location = new System.Drawing.Point(6, 48);
      this.LblPhonePrivate.Name = "LblPhonePrivate";
      this.LblPhonePrivate.Size = new System.Drawing.Size(57, 15);
      this.LblPhonePrivate.TabIndex = 28;
      this.LblPhonePrivate.Text = "Tel. Privat";
      // 
      // TxtMail
      // 
      this.TxtMail.Location = new System.Drawing.Point(161, 16);
      this.TxtMail.Name = "TxtMail";
      this.TxtMail.Size = new System.Drawing.Size(183, 23);
      this.TxtMail.TabIndex = 18;
      // 
      // LblMail
      // 
      this.LblMail.AutoSize = true;
      this.LblMail.Location = new System.Drawing.Point(6, 19);
      this.LblMail.Name = "LblMail";
      this.LblMail.Size = new System.Drawing.Size(41, 15);
      this.LblMail.TabIndex = 26;
      this.LblMail.Text = "E-Mail";
      // 
      // GrpAddress
      // 
      this.GrpAddress.Controls.Add(this.LblCity);
      this.GrpAddress.Controls.Add(this.TxtCity);
      this.GrpAddress.Controls.Add(this.TxtPostalCode);
      this.GrpAddress.Controls.Add(this.LblPostalCode);
      this.GrpAddress.Controls.Add(this.TxtStreetNumber);
      this.GrpAddress.Controls.Add(this.LblStreetNumber);
      this.GrpAddress.Controls.Add(this.TxtStreet);
      this.GrpAddress.Controls.Add(this.LblStreet);
      this.GrpAddress.Location = new System.Drawing.Point(14, 254);
      this.GrpAddress.Name = "GrpAddress";
      this.GrpAddress.Size = new System.Drawing.Size(687, 87);
      this.GrpAddress.TabIndex = 27;
      this.GrpAddress.TabStop = false;
      this.GrpAddress.Text = "Adresse";
      // 
      // LblCity
      // 
      this.LblCity.AutoSize = true;
      this.LblCity.Location = new System.Drawing.Point(406, 45);
      this.LblCity.Name = "LblCity";
      this.LblCity.Size = new System.Drawing.Size(56, 15);
      this.LblCity.TabIndex = 28;
      this.LblCity.Text = "Ortschaft";
      // 
      // TxtCity
      // 
      this.TxtCity.Location = new System.Drawing.Point(492, 45);
      this.TxtCity.Name = "TxtCity";
      this.TxtCity.Size = new System.Drawing.Size(183, 23);
      this.TxtCity.TabIndex = 13;
      // 
      // TxtPostalCode
      // 
      this.TxtPostalCode.Location = new System.Drawing.Point(161, 45);
      this.TxtPostalCode.Name = "TxtPostalCode";
      this.TxtPostalCode.Size = new System.Drawing.Size(183, 23);
      this.TxtPostalCode.TabIndex = 12;
      this.TxtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // LblPostalCode
      // 
      this.LblPostalCode.AutoSize = true;
      this.LblPostalCode.Location = new System.Drawing.Point(6, 45);
      this.LblPostalCode.Name = "LblPostalCode";
      this.LblPostalCode.Size = new System.Drawing.Size(67, 15);
      this.LblPostalCode.TabIndex = 26;
      this.LblPostalCode.Text = "Postleitzahl";
      // 
      // TxtStreetNumber
      // 
      this.TxtStreetNumber.Location = new System.Drawing.Point(492, 16);
      this.TxtStreetNumber.Name = "TxtStreetNumber";
      this.TxtStreetNumber.Size = new System.Drawing.Size(183, 23);
      this.TxtStreetNumber.TabIndex = 11;
      // 
      // LblStreetNumber
      // 
      this.LblStreetNumber.AutoSize = true;
      this.LblStreetNumber.Location = new System.Drawing.Point(406, 19);
      this.LblStreetNumber.Name = "LblStreetNumber";
      this.LblStreetNumber.Size = new System.Drawing.Size(23, 15);
      this.LblStreetNumber.TabIndex = 23;
      this.LblStreetNumber.Text = "Nr.";
      // 
      // TxtStreet
      // 
      this.TxtStreet.Location = new System.Drawing.Point(161, 16);
      this.TxtStreet.Name = "TxtStreet";
      this.TxtStreet.Size = new System.Drawing.Size(183, 23);
      this.TxtStreet.TabIndex = 10;
      // 
      // LblStreet
      // 
      this.LblStreet.AutoSize = true;
      this.LblStreet.Location = new System.Drawing.Point(6, 19);
      this.LblStreet.Name = "LblStreet";
      this.LblStreet.Size = new System.Drawing.Size(43, 15);
      this.LblStreet.TabIndex = 24;
      this.LblStreet.Text = "Strasse";
      // 
      // GrpPersonalData
      // 
      this.GrpPersonalData.Controls.Add(this.TxtNationality);
      this.GrpPersonalData.Controls.Add(this.LblNationality);
      this.GrpPersonalData.Controls.Add(this.MTxtSsn);
      this.GrpPersonalData.Controls.Add(this.TxtTitle);
      this.GrpPersonalData.Controls.Add(this.LblTitle);
      this.GrpPersonalData.Controls.Add(this.TxtCustomerId);
      this.GrpPersonalData.Controls.Add(this.LblCustomerId);
      this.GrpPersonalData.Controls.Add(this.LblSsn);
      this.GrpPersonalData.Controls.Add(this.LblGender);
      this.GrpPersonalData.Controls.Add(this.CmbGender);
      this.GrpPersonalData.Controls.Add(this.LblSalutation);
      this.GrpPersonalData.Controls.Add(this.TxtFirstName);
      this.GrpPersonalData.Controls.Add(this.LblStatus);
      this.GrpPersonalData.Controls.Add(this.CmbStatus);
      this.GrpPersonalData.Controls.Add(this.LblFirstName);
      this.GrpPersonalData.Controls.Add(this.TxtLastname);
      this.GrpPersonalData.Controls.Add(this.LblBirthDate);
      this.GrpPersonalData.Controls.Add(this.LblLastname);
      this.GrpPersonalData.Controls.Add(this.DateTimePickerBirthDate);
      this.GrpPersonalData.Controls.Add(this.CmbSalutation);
      this.GrpPersonalData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.GrpPersonalData.Location = new System.Drawing.Point(14, 56);
      this.GrpPersonalData.Name = "GrpPersonalData";
      this.GrpPersonalData.Size = new System.Drawing.Size(687, 192);
      this.GrpPersonalData.TabIndex = 26;
      this.GrpPersonalData.TabStop = false;
      this.GrpPersonalData.Text = "Person";
      // 
      // TxtNationality
      // 
      this.TxtNationality.Location = new System.Drawing.Point(492, 132);
      this.TxtNationality.Name = "TxtNationality";
      this.TxtNationality.Size = new System.Drawing.Size(183, 23);
      this.TxtNationality.TabIndex = 9;
      // 
      // LblNationality
      // 
      this.LblNationality.AutoSize = true;
      this.LblNationality.Location = new System.Drawing.Point(406, 137);
      this.LblNationality.Name = "LblNationality";
      this.LblNationality.Size = new System.Drawing.Size(69, 15);
      this.LblNationality.TabIndex = 25;
      this.LblNationality.Text = "Nationalität";
      // 
      // MTxtSsn
      // 
      this.MTxtSsn.Location = new System.Drawing.Point(492, 74);
      this.MTxtSsn.Mask = "000.0000.0000.00";
      this.MTxtSsn.Name = "MTxtSsn";
      this.MTxtSsn.Size = new System.Drawing.Size(183, 23);
      this.MTxtSsn.TabIndex = 7;
      // 
      // TxtTitle
      // 
      this.TxtTitle.Location = new System.Drawing.Point(161, 132);
      this.TxtTitle.Name = "TxtTitle";
      this.TxtTitle.Size = new System.Drawing.Size(183, 23);
      this.TxtTitle.TabIndex = 4;
      // 
      // LblTitle
      // 
      this.LblTitle.AutoSize = true;
      this.LblTitle.Location = new System.Drawing.Point(6, 135);
      this.LblTitle.Name = "LblTitle";
      this.LblTitle.Size = new System.Drawing.Size(29, 15);
      this.LblTitle.TabIndex = 22;
      this.LblTitle.Text = "Titel";
      // 
      // TxtCustomerId
      // 
      this.TxtCustomerId.Location = new System.Drawing.Point(161, 16);
      this.TxtCustomerId.Name = "TxtCustomerId";
      this.TxtCustomerId.ReadOnly = true;
      this.TxtCustomerId.Size = new System.Drawing.Size(183, 23);
      this.TxtCustomerId.TabIndex = 0;
      this.TxtCustomerId.TabStop = false;
      this.TxtCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // LblCustomerId
      // 
      this.LblCustomerId.AutoSize = true;
      this.LblCustomerId.Location = new System.Drawing.Point(6, 19);
      this.LblCustomerId.Name = "LblCustomerId";
      this.LblCustomerId.Size = new System.Drawing.Size(66, 15);
      this.LblCustomerId.TabIndex = 19;
      this.LblCustomerId.Text = "Kunden-Nr";
      // 
      // LblSsn
      // 
      this.LblSsn.AutoSize = true;
      this.LblSsn.Location = new System.Drawing.Point(406, 77);
      this.LblSsn.Name = "LblSsn";
      this.LblSsn.Size = new System.Drawing.Size(52, 15);
      this.LblSsn.TabIndex = 17;
      this.LblSsn.Text = "AHV-Nr.";
      // 
      // LblGender
      // 
      this.LblGender.AutoSize = true;
      this.LblGender.Location = new System.Drawing.Point(403, 48);
      this.LblGender.Name = "LblGender";
      this.LblGender.Size = new System.Drawing.Size(65, 15);
      this.LblGender.TabIndex = 15;
      this.LblGender.Text = "Geschlecht";
      // 
      // CmbGender
      // 
      this.CmbGender.FormattingEnabled = true;
      this.CmbGender.Location = new System.Drawing.Point(492, 45);
      this.CmbGender.Name = "CmbGender";
      this.CmbGender.Size = new System.Drawing.Size(183, 23);
      this.CmbGender.TabIndex = 6;
      // 
      // LblSalutation
      // 
      this.LblSalutation.AutoSize = true;
      this.LblSalutation.Location = new System.Drawing.Point(6, 48);
      this.LblSalutation.Name = "LblSalutation";
      this.LblSalutation.Size = new System.Drawing.Size(45, 15);
      this.LblSalutation.TabIndex = 9;
      this.LblSalutation.Text = "Anrede";
      // 
      // TxtFirstName
      // 
      this.TxtFirstName.Location = new System.Drawing.Point(161, 74);
      this.TxtFirstName.Name = "TxtFirstName";
      this.TxtFirstName.Size = new System.Drawing.Size(183, 23);
      this.TxtFirstName.TabIndex = 2;
      // 
      // LblStatus
      // 
      this.LblStatus.AutoSize = true;
      this.LblStatus.Location = new System.Drawing.Point(406, 19);
      this.LblStatus.Name = "LblStatus";
      this.LblStatus.Size = new System.Drawing.Size(39, 15);
      this.LblStatus.TabIndex = 13;
      this.LblStatus.Text = "Status";
      // 
      // CmbStatus
      // 
      this.CmbStatus.FormattingEnabled = true;
      this.CmbStatus.Location = new System.Drawing.Point(492, 16);
      this.CmbStatus.Name = "CmbStatus";
      this.CmbStatus.Size = new System.Drawing.Size(183, 23);
      this.CmbStatus.TabIndex = 5;
      // 
      // LblFirstName
      // 
      this.LblFirstName.AutoSize = true;
      this.LblFirstName.Location = new System.Drawing.Point(6, 77);
      this.LblFirstName.Name = "LblFirstName";
      this.LblFirstName.Size = new System.Drawing.Size(54, 15);
      this.LblFirstName.TabIndex = 2;
      this.LblFirstName.Text = "Vorname";
      // 
      // TxtLastname
      // 
      this.TxtLastname.Location = new System.Drawing.Point(161, 103);
      this.TxtLastname.Name = "TxtLastname";
      this.TxtLastname.Size = new System.Drawing.Size(183, 23);
      this.TxtLastname.TabIndex = 3;
      // 
      // LblBirthDate
      // 
      this.LblBirthDate.AutoSize = true;
      this.LblBirthDate.Location = new System.Drawing.Point(403, 109);
      this.LblBirthDate.Name = "LblBirthDate";
      this.LblBirthDate.Size = new System.Drawing.Size(83, 15);
      this.LblBirthDate.TabIndex = 11;
      this.LblBirthDate.Text = "Geburtsdatum";
      // 
      // LblLastname
      // 
      this.LblLastname.AutoSize = true;
      this.LblLastname.Location = new System.Drawing.Point(6, 106);
      this.LblLastname.Name = "LblLastname";
      this.LblLastname.Size = new System.Drawing.Size(65, 15);
      this.LblLastname.TabIndex = 5;
      this.LblLastname.Text = "Nachname";
      // 
      // DateTimePickerBirthDate
      // 
      this.DateTimePickerBirthDate.CustomFormat = " ";
      this.DateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.DateTimePickerBirthDate.Location = new System.Drawing.Point(492, 103);
      this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
      this.DateTimePickerBirthDate.Size = new System.Drawing.Size(183, 23);
      this.DateTimePickerBirthDate.TabIndex = 8;
      // 
      // CmbSalutation
      // 
      this.CmbSalutation.FormattingEnabled = true;
      this.CmbSalutation.Location = new System.Drawing.Point(161, 45);
      this.CmbSalutation.Name = "CmbSalutation";
      this.CmbSalutation.Size = new System.Drawing.Size(183, 23);
      this.CmbSalutation.TabIndex = 1;
      // 
      // CmdSave
      // 
      this.CmdSave.Location = new System.Drawing.Point(983, 682);
      this.CmdSave.Name = "CmdSave";
      this.CmdSave.Size = new System.Drawing.Size(75, 23);
      this.CmdSave.TabIndex = 30;
      this.CmdSave.Text = "Speichern";
      this.CmdSave.UseVisualStyleBackColor = true;
      this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
      // 
      // CustomerDetailDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1151, 717);
      this.Controls.Add(this.GrpCustomerData);
      this.Controls.Add(this.CmdClose);
      this.Controls.Add(this.GbNotes);
      this.Controls.Add(this.GrpContactData);
      this.Controls.Add(this.GrpAddress);
      this.Controls.Add(this.LblCustomer);
      this.Controls.Add(this.GrpPersonalData);
      this.Controls.Add(this.CmdSave);
      this.Name = "CustomerDetailDialog";
      this.Text = "CustomerDetailDialog";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerDetailDialog_FormClosing);
      this.GbNotes.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerNoteBindingSource)).EndInit();
      this.GrpCustomerData.ResumeLayout(false);
      this.GrpCustomerData.PerformLayout();
      this.GrpContactData.ResumeLayout(false);
      this.GrpContactData.PerformLayout();
      this.GrpAddress.ResumeLayout(false);
      this.GrpAddress.PerformLayout();
      this.GrpPersonalData.ResumeLayout(false);
      this.GrpPersonalData.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
    private Label LblCustomer;
    private GroupBox GbNotes;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private BindingSource customerNoteBindingSource;
        private GroupBox GrpCustomerData;
        private TextBox TxtCompanyContact;
        private ComboBox CmbCustomerType;
        private Label LblCompanyContact;
        private Label LblCustomerType;
        private TextBox TxtRole;
        private Label LblCompanyName;
        private TextBox TxtDeparment;
        private Label LblDepartment;
        private Button CmdClose;
        private GroupBox GrpContactData;
        private TextBox TxtFaxBusiness;
        private Label LblFaxBusiness;
        private TextBox TxtPhoneBusiness;
        private Label LblPhoneBusiness;
        private TextBox TxtPhonePrivate;
        private Label LblPhonePrivate;
        private TextBox TxtMail;
        private Label LblMail;
        private GroupBox GrpAddress;
        private Label LblCity;
        private TextBox TxtCity;
        private TextBox TxtPostalCode;
        private Label LblPostalCode;
        private TextBox TxtStreetNumber;
        private Label LblStreetNumber;
        private TextBox TxtStreet;
        private Label LblStreet;
        private GroupBox GrpPersonalData;
        private TextBox TxtNationality;
        private Label LblNationality;
        private MaskedTextBox MTxtSsn;
        private TextBox TxtTitle;
        private Label LblTitle;
        private TextBox TxtCustomerId;
        private Label LblCustomerId;
        private Label LblSsn;
        private Label LblGender;
        private ComboBox CmbGender;
        private Label LblSalutation;
        private TextBox TxtFirstName;
        private Label LblStatus;
        private ComboBox CmbStatus;
        private Label LblFirstName;
        private TextBox TxtLastname;
        private Label LblBirthDate;
        private Label LblLastname;
        private DateTimePicker DateTimePickerBirthDate;
        private ComboBox CmbSalutation;
        private Button CmdSave;
    }
}