//using System;

//namespace StudentRegistrationSystem
//{
//    partial class FormRegistration
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        private System.Windows.Forms.Label labelTitle;
//        private System.Windows.Forms.LinkLabel linkLogout;
//        private System.Windows.Forms.GroupBox groupBoxStudentRegistration;
//        private System.Windows.Forms.ComboBox comboRegNo;
//        private System.Windows.Forms.Label labelRegNo;
//        private System.Windows.Forms.GroupBox groupBoxBasicDetails;
//        private System.Windows.Forms.Label labelFirstName;
//        private System.Windows.Forms.Label labelLastName;
//        private System.Windows.Forms.TextBox txtFirstName;
//        private System.Windows.Forms.TextBox txtLastName;
//        private System.Windows.Forms.Label labeldtpdateOfBirth;
//        private System.Windows.Forms.DateTimePicker dtpdateOfBirth;
//        private System.Windows.Forms.Label labelGender;
//        private System.Windows.Forms.RadioButton radioMale;
//        private System.Windows.Forms.RadioButton radioFemale;
//        private System.Windows.Forms.GroupBox groupBoxContactDetails;
//        private System.Windows.Forms.Label labelAddress;
//        private System.Windows.Forms.TextBox txtAddress;
//        private System.Windows.Forms.Label labelEmail;
//        private System.Windows.Forms.TextBox txtEmail;
//        private System.Windows.Forms.Label labelMobile;
//        private System.Windows.Forms.TextBox txtMobile;
//        private System.Windows.Forms.Label labelHomePhone;
//        private System.Windows.Forms.TextBox txtHomePhone;
//        private System.Windows.Forms.GroupBox groupBoxParentDetails;
//        private System.Windows.Forms.Label labelParentName;
//        private System.Windows.Forms.TextBox txtParentName;
//        private System.Windows.Forms.Label labelNIC;
//        private System.Windows.Forms.TextBox txtNIC;
//        private System.Windows.Forms.Label labelContactNo;
//        private System.Windows.Forms.TextBox txtContactNo;
//        private System.Windows.Forms.Button btnRegister;
//        private System.Windows.Forms.Button btnUpdate;
//        private System.Windows.Forms.Button btnClear;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.LinkLabel linkExit;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.labelTitle = new System.Windows.Forms.Label();
//            this.linkLogout = new System.Windows.Forms.LinkLabel();
//            this.groupBoxStudentRegistration = new System.Windows.Forms.GroupBox();
//            this.labelRegNo = new System.Windows.Forms.Label();
//            this.comboRegNo = new System.Windows.Forms.ComboBox();
//            this.groupBoxBasicDetails = new System.Windows.Forms.GroupBox();
//            this.labelFirstName = new System.Windows.Forms.Label();
//            this.labelLastName = new System.Windows.Forms.Label();
//            this.txtFirstName = new System.Windows.Forms.TextBox();
//            this.txtLastName = new System.Windows.Forms.TextBox();
//            this.labeldtpdateOfBirth = new System.Windows.Forms.Label();
//            this.dtpdateOfBirth = new System.Windows.Forms.DateTimePicker();
//            this.labelGender = new System.Windows.Forms.Label();
//            this.radioMale = new System.Windows.Forms.RadioButton();
//            this.radioFemale = new System.Windows.Forms.RadioButton();
//            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
//            this.labelAddress = new System.Windows.Forms.Label();
//            this.txtAddress = new System.Windows.Forms.TextBox();
//            this.labelEmail = new System.Windows.Forms.Label();
//            this.txtEmail = new System.Windows.Forms.TextBox();
//            this.labelMobile = new System.Windows.Forms.Label();
//            this.txtMobile = new System.Windows.Forms.TextBox();
//            this.labelHomePhone = new System.Windows.Forms.Label();
//            this.txtHomePhone = new System.Windows.Forms.TextBox();
//            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
//            this.labelParentName = new System.Windows.Forms.Label();
//            this.txtParentName = new System.Windows.Forms.TextBox();
//            this.labelNIC = new System.Windows.Forms.Label();
//            this.txtNIC = new System.Windows.Forms.TextBox();
//            this.labelContactNo = new System.Windows.Forms.Label();
//            this.txtContactNo = new System.Windows.Forms.TextBox();
//            this.btnRegister = new System.Windows.Forms.Button();
//            this.btnUpdate = new System.Windows.Forms.Button();
//            this.btnClear = new System.Windows.Forms.Button();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.linkExit = new System.Windows.Forms.LinkLabel();
//            this.groupBoxStudentRegistration.SuspendLayout();
//            this.groupBoxBasicDetails.SuspendLayout();
//            this.groupBoxContactDetails.SuspendLayout();
//            this.groupBoxParentDetails.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // FormRegistration
//            // 
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(700, 640);
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Student Registration - Skills International";
//            // 
//            // linkLogout
//            // 
//            this.linkLogout.AutoSize = true;
//            this.linkLogout.Location = new System.Drawing.Point(12, 12);
//            this.linkLogout.Name = "linkLogout";
//            this.linkLogout.Size = new System.Drawing.Size(45, 13);
//            this.linkLogout.TabIndex = 0;
//            this.linkLogout.TabStop = true;
//            this.linkLogout.Text = "Logout";
//            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
//            // 
//            // labelTitle
//            // 
//            this.labelTitle.AutoSize = true;
//            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
//            this.labelTitle.Location = new System.Drawing.Point(190, 6);
//            this.labelTitle.Name = "labelTitle";
//            this.labelTitle.Size = new System.Drawing.Size(320, 37);
//            this.labelTitle.TabIndex = 1;
//            this.labelTitle.Text = "Skills International";
//            // 
//            // groupBoxStudentRegistration
//            // 
//            this.groupBoxStudentRegistration.Controls.Add(this.labelRegNo);
//            this.groupBoxStudentRegistration.Controls.Add(this.comboRegNo);
//            this.groupBoxStudentRegistration.Location = new System.Drawing.Point(12, 50);
//            this.groupBoxStudentRegistration.Name = "groupBoxStudentRegistration";
//            this.groupBoxStudentRegistration.Size = new System.Drawing.Size(676, 60);
//            this.groupBoxStudentRegistration.TabIndex = 2;
//            this.groupBoxStudentRegistration.TabStop = false;
//            this.groupBoxStudentRegistration.Text = "Student Registration";
//            // 
//            // labelRegNo
//            // 
//            this.labelRegNo.AutoSize = true;
//            this.labelRegNo.Location = new System.Drawing.Point(16, 28);
//            this.labelRegNo.Name = "labelRegNo";
//            this.labelRegNo.Size = new System.Drawing.Size(40, 13);
//            this.labelRegNo.TabIndex = 0;
//            this.labelRegNo.Text = "Reg No";
//            // 
//            // comboRegNo
//            // 
//            this.comboRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
//            this.comboRegNo.FormattingEnabled = true;
//            this.comboRegNo.Location = new System.Drawing.Point(90, 24);
//            this.comboRegNo.Name = "comboRegNo";
//            this.comboRegNo.Size = new System.Drawing.Size(150, 21);
//            this.comboRegNo.TabIndex = 1;
//            this.comboRegNo.DropDown += new System.EventHandler(this.comboRegNo_DropDown);
//            this.comboRegNo.SelectedIndexChanged += new System.EventHandler(this.comboRegNo_SelectedIndexChanged);
//            this.comboRegNo.TextChanged += new System.EventHandler(this.comboRegNo_TextChanged);
//            // 
//            // groupBoxBasicDetails
//            // 
//            this.groupBoxBasicDetails.Controls.Add(this.labelFirstName);
//            this.groupBoxBasicDetails.Controls.Add(this.txtFirstName);
//            this.groupBoxBasicDetails.Controls.Add(this.labelLastName);
//            this.groupBoxBasicDetails.Controls.Add(this.txtLastName);
//            this.groupBoxBasicDetails.Controls.Add(this.labeldtpdateOfBirth);
//            this.dtpdateOfBirth = new System.Windows.Forms.DateTimePicker();
//            this.groupBoxBasicDetails.Controls.Add(this.labelGender);
//            this.groupBoxBasicDetails.Controls.Add(this.radioMale);
//            this.groupBoxBasicDetails.Controls.Add(this.radioFemale);
//            this.groupBoxBasicDetails.Location = new System.Drawing.Point(12, 120);
//            this.groupBoxBasicDetails.Name = "groupBoxBasicDetails";
//            this.groupBoxBasicDetails.Size = new System.Drawing.Size(676, 150);
//            this.groupBoxBasicDetails.TabIndex = 3;
//            this.groupBoxBasicDetails.TabStop = false;
//            this.groupBoxBasicDetails.Text = "Basic Details";
//            // 
//            // labelFirstName
//            // 
//            this.labelFirstName.AutoSize = true;
//            this.labelFirstName.Location = new System.Drawing.Point(16, 30);
//            this.labelFirstName.Name = "labelFirstName";
//            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
//            this.labelFirstName.TabIndex = 0;
//            this.labelFirstName.Text = "First Name";
//            // 
//            // txtFirstName
//            // 
//            this.txtFirstName.Location = new System.Drawing.Point(120, 26);
//            this.txtFirstName.Name = "txtFirstName";
//            this.txtFirstName.Size = new System.Drawing.Size(520, 20);
//            this.txtFirstName.TabIndex = 1;
//            // 
//            // labelLastName
//            // 
//            this.labelLastName.AutoSize = true;
//            this.labelLastName.Location = new System.Drawing.Point(16, 62);
//            this.labelLastName.Name = "labelLastName";
//            this.labelLastName.Size = new System.Drawing.Size(58, 13);
//            this.labelLastName.TabIndex = 2;
//            this.labelLastName.Text = "Last Name";
//            // 
//            // txtLastName
//            // 
//            this.txtLastName.Location = new System.Drawing.Point(120, 58);
//            this.txtLastName.Name = "txtLastName";
//            this.txtLastName.Size = new System.Drawing.Size(520, 20);
//            this.txtLastName.TabIndex = 3;
//            // 
//            // labelDOB
//            // 
//            this.labeldtpdateOfBirth.AutoSize = true;
//            this.labeldtpdateOfBirth.Location = new System.Drawing.Point(16, 96);
//            this.labeldtpdateOfBirth.Name = "labelDOB";
//            this.labeldtpdateOfBirth.Size = new System.Drawing.Size(68, 13);
//            this.labeldtpdateOfBirth.TabIndex = 4;
//            this.labeldtpdateOfBirth.Text = "Date of Birth";
//            // 
//            // dtpDOB
//            // 
//            this.dtpdateOfBirth.Location = new System.Drawing.Point(120, 92);
//            this.dtpdateOfBirth.Name = "dtpdateOfBirth";
//            this.dtpdateOfBirth.Size = new System.Drawing.Size(200, 20);
//            this.dtpdateOfBirth.TabIndex = 5;
//            // 
//            // labelGender
//            // 
//            this.labelGender.AutoSize = true;
//            this.labelGender.Location = new System.Drawing.Point(360, 96);
//            this.labelGender.Name = "labelGender";
//            this.labelGender.Size = new System.Drawing.Size(42, 13);
//            this.labelGender.TabIndex = 6;
//            this.labelGender.Text = "Gender";
//            // 
//            // radioMale
//            // 
//            this.radioMale.AutoSize = true;
//            this.radioMale.Location = new System.Drawing.Point(420, 94);
//            this.radioMale.Name = "radioMale";
//            this.radioMale.Size = new System.Drawing.Size(48, 17);
//            this.radioMale.TabIndex = 7;
//            this.radioMale.TabStop = true;
//            this.radioMale.Text = "Male";
//            this.radioMale.UseVisualStyleBackColor = true;
//            // 
//            // radioFemale
//            // 
//            this.radioFemale.AutoSize = true;
//            this.radioFemale.Location = new System.Drawing.Point(500, 94);
//            this.radioFemale.Name = "radioFemale";
//            this.radioFemale.Size = new System.Drawing.Size(59, 17);
//            this.radioFemale.TabIndex = 8;
//            this.radioFemale.TabStop = true;
//            this.radioFemale.Text = "Female";
//            this.radioFemale.UseVisualStyleBackColor = true;
//            // 
//            // groupBoxContactDetails
//            // 
//            this.groupBoxContactDetails.Controls.Add(this.labelAddress);
//            this.groupBoxContactDetails.Controls.Add(this.txtAddress);
//            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
//            this.groupBoxContactDetails.Controls.Add(this.txtEmail);
//            this.groupBoxContactDetails.Controls.Add(this.labelMobile);
//            this.groupBoxContactDetails.Controls.Add(this.txtMobile);
//            this.groupBoxContactDetails.Controls.Add(this.labelHomePhone);
//            this.groupBoxContactDetails.Controls.Add(this.txtHomePhone);
//            this.groupBoxContactDetails.Location = new System.Drawing.Point(12, 286);
//            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
//            this.groupBoxContactDetails.Size = new System.Drawing.Size(676, 170);
//            this.groupBoxContactDetails.TabIndex = 4;
//            this.groupBoxContactDetails.TabStop = false;
//            this.groupBoxContactDetails.Text = "Contact Details";
//            // 
//            // labelAddress
//            // 
//            this.labelAddress.AutoSize = true;
//            this.labelAddress.Location = new System.Drawing.Point(16, 28);
//            this.labelAddress.Name = "labelAddress";
//            this.labelAddress.Size = new System.Drawing.Size(45, 13);
//            this.labelAddress.TabIndex = 0;
//            this.labelAddress.Text = "Address";
//            // 
//            // txtAddress
//            // 
//            this.txtAddress.Location = new System.Drawing.Point(120, 24);
//            this.txtAddress.Multiline = true;
//            this.txtAddress.Name = "txtAddress";
//            this.txtAddress.Size = new System.Drawing.Size(520, 60);
//            this.txtAddress.TabIndex = 1;
//            // 
//            // labelEmail
//            // 
//            this.labelEmail.AutoSize = true;
//            this.labelEmail.Location = new System.Drawing.Point(16, 96);
//            this.labelEmail.Name = "labelEmail";
//            this.labelEmail.Size = new System.Drawing.Size(32, 13);
//            this.labelEmail.TabIndex = 2;
//            this.labelEmail.Text = "Email";
//            // 
//            // txtEmail
//            // 
//            this.txtEmail.Location = new System.Drawing.Point(120, 92);
//            this.txtEmail.Name = "txtEmail";
//            this.txtEmail.Size = new System.Drawing.Size(520, 20);
//            this.txtEmail.TabIndex = 3;
//            // 
//            // labelMobile
//            // 
//            this.labelMobile.AutoSize = true;
//            this.labelMobile.Location = new System.Drawing.Point(16, 130);
//            this.labelMobile.Name = "labelMobile";
//            this.labelMobile.Size = new System.Drawing.Size(72, 13);
//            this.labelMobile.TabIndex = 4;
//            this.labelMobile.Text = "Mobile Phone";
//            // 
//            // txtMobile
//            // 
//            this.txtMobile.Location = new System.Drawing.Point(120, 126);
//            this.txtMobile.Name = "txtMobile";
//            this.txtMobile.Size = new System.Drawing.Size(140, 20);
//            this.txtMobile.TabIndex = 5;
//            // 
//            // labelHomePhone
//            // 
//            this.labelHomePhone.AutoSize = true;
//            this.labelHomePhone.Location = new System.Drawing.Point(340, 130);
//            this.labelHomePhone.Name = "labelHomePhone";
//            this.labelHomePhone.Size = new System.Drawing.Size(67, 13);
//            this.labelHomePhone.TabIndex = 6;
//            this.labelHomePhone.Text = "Home Phone";
//            // 
//            // txtHomePhone
//            // 
//            this.txtHomePhone.Location = new System.Drawing.Point(420, 126);
//            this.txtHomePhone.Name = "txtHomePhone";
//            this.txtHomePhone.Size = new System.Drawing.Size(220, 20);
//            this.txtHomePhone.TabIndex = 7;
//            // 
//            // groupBoxParentDetails
//            // 
//            this.groupBoxParentDetails.Controls.Add(this.labelParentName);
//            this.groupBoxParentDetails.Controls.Add(this.txtParentName);
//            this.groupBoxParentDetails.Controls.Add(this.labelNIC);
//            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
//            this.groupBoxParentDetails.Controls.Add(this.labelContactNo);
//            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
//            this.groupBoxParentDetails.Location = new System.Drawing.Point(12, 470);
//            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
//            this.groupBoxParentDetails.Size = new System.Drawing.Size(676, 110);
//            this.groupBoxParentDetails.TabIndex = 5;
//            this.groupBoxParentDetails.TabStop = false;
//            this.groupBoxParentDetails.Text = "Parent Details";
//            // 
//            // labelParentName
//            // 
//            this.labelParentName.AutoSize = true;
//            this.labelParentName.Location = new System.Drawing.Point(16, 26);
//            this.labelParentName.Name = "labelParentName";
//            this.labelParentName.Size = new System.Drawing.Size(69, 13);
//            this.labelParentName.TabIndex = 0;
//            this.labelParentName.Text = "Parent Name";
//            // 
//            // txtParentName
//            // 
//            this.txtParentName.Location = new System.Drawing.Point(120, 22);
//            this.txtParentName.Name = "txtParentName";
//            this.txtParentName.Size = new System.Drawing.Size(520, 20);
//            this.txtParentName.TabIndex = 1;
//            // 
//            // labelNIC
//            // 
//            this.labelNIC.AutoSize = true;
//            this.labelNIC.Location = new System.Drawing.Point(16, 56);
//            this.labelNIC.Name = "labelNIC";
//            this.labelNIC.Size = new System.Drawing.Size(25, 13);
//            this.labelNIC.TabIndex = 2;
//            this.labelNIC.Text = "NIC";
//            // 
//            // txtNIC
//            // 
//            this.txtNIC.Location = new System.Drawing.Point(120, 52);
//            this.txtNIC.Name = "txtNIC";
//            this.txtNIC.Size = new System.Drawing.Size(200, 20);
//            this.txtNIC.TabIndex = 3;
//            // 
//            // labelContactNo
//            // 
//            this.labelContactNo.AutoSize = true;
//            this.labelContactNo.Location = new System.Drawing.Point(340, 56);
//            this.labelContactNo.Name = "labelContactNo";
//            this.labelContactNo.Size = new System.Drawing.Size(82, 13);
//            this.labelContactNo.TabIndex = 4;
//            this.labelContactNo.Text = "Contact Number";
//            // 
//            // txtContactNo
//            // 
//            this.txtContactNo.Location = new System.Drawing.Point(420, 52);
//            this.txtContactNo.Name = "txtContactNo";
//            this.txtContactNo.Size = new System.Drawing.Size(220, 20);
//            this.txtContactNo.TabIndex = 5;
//            // 
//            // btnRegister
//            // 
//            this.btnRegister.Location = new System.Drawing.Point(20, 590);
//            this.btnRegister.Name = "btnRegister";
//            this.btnRegister.Size = new System.Drawing.Size(90, 30);
//            this.btnRegister.TabIndex = 6;
//            this.btnRegister.Text = "Register";
//            this.btnRegister.UseVisualStyleBackColor = true;
//            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
//            // 
//            // btnUpdate
//            // 
//            this.btnUpdate.Location = new System.Drawing.Point(120, 590);
//            this.btnUpdate.Name = "btnUpdate";
//            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
//            this.btnUpdate.TabIndex = 7;
//            this.btnUpdate.Text = "Update";
//            this.btnUpdate.UseVisualStyleBackColor = true;
//            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
//            // 
//            // btnClear
//            // 
//            this.btnClear.Location = new System.Drawing.Point(480, 590);
//            this.btnClear.Name = "btnClear";
//            this.btnClear.Size = new System.Drawing.Size(90, 30);
//            this.btnClear.TabIndex = 8;
//            this.btnClear.Text = "Clear";
//            this.btnClear.UseVisualStyleBackColor = true;
//            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
//            // 
//            // btnDelete
//            // 
//            this.btnDelete.Location = new System.Drawing.Point(580, 590);
//            this.btnDelete.Name = "btnDelete";
//            this.btnDelete.Size = new System.Drawing.Size(90, 30);
//            this.btnDelete.TabIndex = 9;
//            this.btnDelete.Text = "Delete";
//            this.btnDelete.UseVisualStyleBackColor = true;
//            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//            // 
//            // linkExit
//            // 
//            this.linkExit.AutoSize = true;
//            this.linkExit.Location = new System.Drawing.Point(660, 622);
//            this.linkExit.Name = "linkExit";
//            this.linkExit.Size = new System.Drawing.Size(24, 13);
//            this.linkExit.TabIndex = 10;
//            this.linkExit.TabStop = true;
//            this.linkExit.Text = "Exit";
//            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
//            // 
//            // add controls to form
//            // 
//            this.Controls.Add(this.labelTitle);
//            this.Controls.Add(this.linkLogout);
//            this.Controls.Add(this.groupBoxStudentRegistration);
//            this.Controls.Add(this.groupBoxBasicDetails);
//            this.Controls.Add(this.groupBoxContactDetails);
//            this.Controls.Add(this.groupBoxParentDetails);
//            this.Controls.Add(this.btnRegister);
//            this.Controls.Add(this.btnUpdate);
//            this.Controls.Add(this.btnClear);
//            this.Controls.Add(this.btnDelete);
//            this.Controls.Add(this.linkExit);
//            // 
//            // finalize layout
//            // 
//            this.groupBoxStudentRegistration.ResumeLayout(false);
//            this.groupBoxStudentRegistration.PerformLayout();
//            this.groupBoxBasicDetails.ResumeLayout(false);
//            this.groupBoxBasicDetails.PerformLayout();
//            this.groupBoxContactDetails.ResumeLayout(false);
//            this.groupBoxContactDetails.PerformLayout();
//            this.groupBoxParentDetails.ResumeLayout(false);
//            this.groupBoxParentDetails.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }

//        #endregion
//    }
//}


using System;

namespace StudentRegistrationSystem
{
    partial class FormRegistration
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picHeaderBanner;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.LinkLabel linkLogout;

        // Body (scrollable)
        private System.Windows.Forms.Panel pnlBody;

        // Section: Reg No
        private System.Windows.Forms.Panel pnlRegNo;
        private System.Windows.Forms.Label lblRegNoTitle;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.ComboBox comboRegNo;

        // Section: Basic Details
        private System.Windows.Forms.Panel pnlBasic;
        private System.Windows.Forms.Label lblBasicTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labeldtpdateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpdateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;

        // Section: Contact
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;

        // Section: Parent
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.Label lblParentTitle;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.TextBox txtContactNo;

        // Footer / action bar
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel linkExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Header
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picHeaderBanner = new System.Windows.Forms.PictureBox();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();

            // Body
            this.pnlBody = new System.Windows.Forms.Panel();

            // Reg No section
            this.pnlRegNo = new System.Windows.Forms.Panel();
            this.lblRegNoTitle = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.comboRegNo = new System.Windows.Forms.ComboBox();

            // Basic section
            this.pnlBasic = new System.Windows.Forms.Panel();
            this.lblBasicTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labeldtpdateOfBirth = new System.Windows.Forms.Label();
            this.dtpdateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();

            // Contact section
            this.pnlContact = new System.Windows.Forms.Panel();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();

            // Parent section
            this.pnlParent = new System.Windows.Forms.Panel();
            this.lblParentTitle = new System.Windows.Forms.Label();
            this.labelParentName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.labelNIC = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();

            // Footer
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.linkExit = new System.Windows.Forms.LinkLabel();

            ((System.ComponentModel.ISupportInitialize)(this.picHeaderBanner)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlRegNo.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.pnlContact.SuspendLayout();
            this.pnlParent.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── FORM ─────────────────────────────────────────────────
            this.Text = "Student Registration — Skills International";
            this.ClientSize = new System.Drawing.Size(820, 740);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(237, 241, 245);

            // ════════════════════════════════════════════════════════
            //  HEADER PANEL
            // ════════════════════════════════════════════════════════
            this.pnlHeader.Size = new System.Drawing.Size(820, 80);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 58, 92);

            // header_banner.jpg — wide banner photo (820x80 px)
            // A blurred or abstract campus photo works well here.
            // Free source: https://unsplash.com/s/photos/university-building
            this.picHeaderBanner.Location = new System.Drawing.Point(0, 0);
            this.picHeaderBanner.Size = new System.Drawing.Size(820, 80);
            this.picHeaderBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeaderBanner.BackColor = System.Drawing.Color.FromArgb(27, 58, 92);
            ImageUtil.LoadImage(this.picHeaderBanner, "header_banner.jpg");

            // Text labels drawn ON TOP of the image (BringToFront)
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 14);
            this.lblHeaderTitle.Text = "Skills International  —  Student Registration";
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;

            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Location = new System.Drawing.Point(18, 48);
            this.lblHeaderSub.Text = "Manage student records securely";
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(180, 210, 240);
            this.lblHeaderSub.BackColor = System.Drawing.Color.Transparent;

            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(742, 30);
            this.linkLogout.Text = "Logout";
            this.linkLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.linkLogout.LinkColor = System.Drawing.Color.FromArgb(160, 200, 240);
            this.linkLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);

            this.pnlHeader.Controls.Add(this.picHeaderBanner);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.linkLogout);
            // labels must be above the image
            this.lblHeaderTitle.BringToFront();
            this.lblHeaderSub.BringToFront();
            this.linkLogout.BringToFront();

            // ════════════════════════════════════════════════════════
            //  SCROLLABLE BODY
            // ════════════════════════════════════════════════════════
            this.pnlBody.Location = new System.Drawing.Point(0, 80);
            this.pnlBody.Size = new System.Drawing.Size(820, 600);
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(237, 241, 245);
            this.pnlBody.AutoScroll = true;

            int margin = 16;
            int pw = 788;   // panel width inside body
            int top = 16;

            // ─── Reg No Section ──────────────────────────────────────
            BuildSectionPanel(this.pnlRegNo, margin, top, pw, 62, "  \u25a0  Student Registration", this.lblRegNoTitle);

            MkLabel(this.lblRegNo, "Reg No :", 16, 32);
            this.comboRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboRegNo.Location = new System.Drawing.Point(90, 28);
            this.comboRegNo.Size = new System.Drawing.Size(180, 24);
            this.comboRegNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboRegNo.BackColor = System.Drawing.Color.White;
            this.comboRegNo.DropDown += new System.EventHandler(this.comboRegNo_DropDown);
            this.comboRegNo.SelectedIndexChanged += new System.EventHandler(this.comboRegNo_SelectedIndexChanged);
            this.comboRegNo.TextChanged += new System.EventHandler(this.comboRegNo_TextChanged);

            this.pnlRegNo.Controls.Add(this.lblRegNo);
            this.pnlRegNo.Controls.Add(this.comboRegNo);
            top += 62 + 10;

            // ─── Basic Details ───────────────────────────────────────
            BuildSectionPanel(this.pnlBasic, margin, top, pw, 160, "  \u25a0  Basic Details", this.lblBasicTitle);

            MkLabel(this.labelFirstName, "First Name :", 16, 38); MkInput(this.txtFirstName, 110, 34, 280);
            MkLabel(this.labelLastName, "Last Name :", 420, 38); MkInput(this.txtLastName, 510, 34, 262);
            MkLabel(this.labeldtpdateOfBirth, "Date of Birth :", 16, 80);
            this.dtpdateOfBirth.Location = new System.Drawing.Point(110, 76);
            this.dtpdateOfBirth.Size = new System.Drawing.Size(200, 24);
            this.dtpdateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            MkLabel(this.labelGender, "Gender :", 340, 80);
            MkRadio(this.radioMale, "Male", 420, 78);
            MkRadio(this.radioFemale, "Female", 500, 78);

            this.pnlBasic.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.labelFirstName, this.txtFirstName,
                this.labelLastName,  this.txtLastName,
                this.labeldtpdateOfBirth, this.dtpdateOfBirth,
                this.labelGender, this.radioMale, this.radioFemale
            });
            top += 160 + 10;

            // ─── Contact Details ─────────────────────────────────────
            BuildSectionPanel(this.pnlContact, margin, top, pw, 190, "  \u25a0  Contact Details", this.lblContactTitle);

            MkLabel(this.labelAddress, "Address :", 16, 38);
            this.txtAddress.Location = new System.Drawing.Point(110, 34);
            this.txtAddress.Size = new System.Drawing.Size(662, 58);
            this.txtAddress.Multiline = true;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.BackColor = System.Drawing.Color.White;

            MkLabel(this.labelEmail, "Email :", 16, 110); MkInput(this.txtEmail, 110, 106, 662);
            MkLabel(this.labelMobile, "Mobile :", 16, 148); MkInput(this.txtMobile, 110, 144, 260);
            MkLabel(this.labelHomePhone, "Home Phone :", 400, 148); MkInput(this.txtHomePhone, 500, 144, 272);

            this.pnlContact.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.labelAddress, this.txtAddress,
                this.labelEmail,   this.txtEmail,
                this.labelMobile,  this.txtMobile,
                this.labelHomePhone, this.txtHomePhone
            });
            top += 190 + 10;

            // ─── Parent Details ──────────────────────────────────────
            BuildSectionPanel(this.pnlParent, margin, top, pw, 120, "  \u25a0  Parent / Guardian Details", this.lblParentTitle);

            MkLabel(this.labelParentName, "Parent Name :", 16, 38); MkInput(this.txtParentName, 110, 34, 662);
            MkLabel(this.labelNIC, "NIC :", 16, 80); MkInput(this.txtNIC, 110, 76, 220);
            MkLabel(this.labelContactNo, "Contact No :", 360, 80); MkInput(this.txtContactNo, 460, 76, 312);

            this.pnlParent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.labelParentName, this.txtParentName,
                this.labelNIC, this.txtNIC,
                this.labelContactNo, this.txtContactNo
            });
            top += 120 + 10;

            // add sections to body
            this.pnlBody.Controls.Add(this.pnlRegNo);
            this.pnlBody.Controls.Add(this.pnlBasic);
            this.pnlBody.Controls.Add(this.pnlContact);
            this.pnlBody.Controls.Add(this.pnlParent);

            // ════════════════════════════════════════════════════════
            //  FOOTER ACTION BAR
            // ════════════════════════════════════════════════════════
            this.pnlFooter.Location = new System.Drawing.Point(0, 680);
            this.pnlFooter.Size = new System.Drawing.Size(820, 60);
            this.pnlFooter.BackColor = System.Drawing.Color.White;

            // left-aligned action buttons
            MkBtn(this.btnRegister, "Register", 16, 12, 110, 36,
                  System.Drawing.Color.FromArgb(15, 110, 86), System.Drawing.Color.White);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            MkBtn(this.btnUpdate, "Update", 136, 12, 110, 36,
                  System.Drawing.Color.FromArgb(27, 58, 92), System.Drawing.Color.White);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // right-aligned
            MkBtn(this.btnClear, "Clear", 564, 12, 100, 36,
                  System.Drawing.Color.FromArgb(235, 238, 242), System.Drawing.Color.FromArgb(70, 80, 100));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            MkBtn(this.btnDelete, "Delete", 674, 12, 100, 36,
                  System.Drawing.Color.FromArgb(163, 45, 45), System.Drawing.Color.White);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(784, 42);
            this.linkExit.Text = "Exit";
            this.linkExit.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.linkExit.LinkColor = System.Drawing.Color.FromArgb(130, 140, 160);
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);

            this.pnlFooter.Controls.Add(this.btnRegister);
            this.pnlFooter.Controls.Add(this.btnUpdate);
            this.pnlFooter.Controls.Add(this.btnClear);
            this.pnlFooter.Controls.Add(this.btnDelete);
            this.pnlFooter.Controls.Add(this.linkExit);

            // ── ADD ALL TO FORM ───────────────────────────────────────
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlRegNo.ResumeLayout(false);
            this.pnlRegNo.PerformLayout();
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.pnlParent.ResumeLayout(false);
            this.pnlParent.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderBanner)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Helpers ────────────────────────────────────────────────────
        private static readonly System.Drawing.Color NavyAccent = System.Drawing.Color.FromArgb(27, 58, 92);

        private static void BuildSectionPanel(
            System.Windows.Forms.Panel pnl, int x, int y, int w, int h,
            string titleText, System.Windows.Forms.Label titleLabel)
        {
            pnl.Location = new System.Drawing.Point(x, y);
            pnl.Size = new System.Drawing.Size(w, h);
            pnl.BackColor = System.Drawing.Color.White;
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // coloured top stripe
            var stripe = new System.Windows.Forms.Panel();
            stripe.Location = new System.Drawing.Point(0, 0);
            stripe.Size = new System.Drawing.Size(w, 4);
            stripe.BackColor = NavyAccent;
            pnl.Controls.Add(stripe);

            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(8, 8);
            titleLabel.Text = titleText;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            titleLabel.ForeColor = NavyAccent;
            pnl.Controls.Add(titleLabel);
        }

        private static void MkLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 92, 115);
        }

        private static void MkInput(System.Windows.Forms.TextBox tb, int x, int y, int w)
        {
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(w, 24);
            tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tb.BackColor = System.Drawing.Color.White;
            tb.ForeColor = System.Drawing.Color.FromArgb(30, 30, 40);
        }

        private static void MkRadio(System.Windows.Forms.RadioButton rb, string text, int x, int y)
        {
            rb.AutoSize = true;
            rb.Location = new System.Drawing.Point(x, y);
            rb.Text = text;
            rb.Font = new System.Drawing.Font("Segoe UI", 9F);
            rb.ForeColor = System.Drawing.Color.FromArgb(30, 30, 40);
        }

        private static void MkBtn(System.Windows.Forms.Button btn, string text,
            int x, int y, int w, int h,
            System.Drawing.Color back, System.Drawing.Color fore)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.BackColor = back;
            btn.ForeColor = fore;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        private static void LoadImage(System.Windows.Forms.PictureBox pb, string filename)
        {
            try
            {
                string path = System.IO.Path.Combine(
                    System.AppDomain.CurrentDomain.BaseDirectory, filename);
                if (System.IO.File.Exists(path))
                    pb.Image = System.Drawing.Image.FromFile(path);
            }
            catch { }
        }

        #endregion
    }
}