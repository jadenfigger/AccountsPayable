
namespace AccountPayable
{
    partial class VendorForm
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
            System.Windows.Forms.Label label10;
            this.label1 = new System.Windows.Forms.Label();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveVendor = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtVendorCode1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVendorName1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSearchVendor = new System.Windows.Forms.Button();
            this.txtVendorCodeSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInvoiceIdReadOnly = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmountPayed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVendorCode2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.txtInvoiceIDSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.invoiceGridView = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSearchVendor2 = new System.Windows.Forms.Button();
            this.txtSearchVendorCode2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnGenerateCS = new System.Windows.Forms.Button();
            this.dtpAfter = new System.Windows.Forms.DateTimePicker();
            this.dtpBefore = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTotAmtDue = new System.Windows.Forms.Label();
            this.lbTotAmtPayed = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridView)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Myanmar Text", 12F);
            label10.Location = new System.Drawing.Point(12, 185);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(124, 36);
            label10.TabIndex = 12;
            label10.Text = "Date Added:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accounts Payable";
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Controls.Add(this.tabPage3);
            this.tabController.Controls.Add(this.tabPage4);
            this.tabController.Location = new System.Drawing.Point(12, 83);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(803, 470);
            this.tabController.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 50);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add/Remove Vendor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 43);
            this.label15.TabIndex = 11;
            this.label15.Text = "Add/Remove Vendor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveVendor);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(label10);
            this.groupBox4.Controls.Add(this.txtVendorCode1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtVendorName1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(394, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 340);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vendor Infomation";
            // 
            // btnRemoveVendor
            // 
            this.btnRemoveVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveVendor.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnRemoveVendor.Location = new System.Drawing.Point(93, 258);
            this.btnRemoveVendor.Name = "btnRemoveVendor";
            this.btnRemoveVendor.Size = new System.Drawing.Size(199, 50);
            this.btnRemoveVendor.TabIndex = 6;
            this.btnRemoveVendor.Text = "Remove Vendor";
            this.btnRemoveVendor.UseVisualStyleBackColor = true;
            this.btnRemoveVendor.Click += new System.EventHandler(this.btnRemoveVendor_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM:dd:yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 45);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // txtVendorCode1
            // 
            this.txtVendorCode1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.txtVendorCode1.Location = new System.Drawing.Point(163, 131);
            this.txtVendorCode1.Name = "txtVendorCode1";
            this.txtVendorCode1.Size = new System.Drawing.Size(215, 45);
            this.txtVendorCode1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label12.Location = new System.Drawing.Point(12, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 36);
            this.label12.TabIndex = 8;
            this.label12.Text = "Vendor Code:";
            // 
            // txtVendorName1
            // 
            this.txtVendorName1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.txtVendorName1.Location = new System.Drawing.Point(163, 80);
            this.txtVendorName1.Name = "txtVendorName1";
            this.txtVendorName1.Size = new System.Drawing.Size(215, 45);
            this.txtVendorName1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label13.Location = new System.Drawing.Point(12, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 36);
            this.label13.TabIndex = 6;
            this.label13.Text = "Vendor Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddVendor);
            this.groupBox5.Location = new System.Drawing.Point(17, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(363, 148);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New Vendor";
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVendor.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnAddVendor.Location = new System.Drawing.Point(80, 66);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(196, 50);
            this.btnAddVendor.TabIndex = 6;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSearchVendor);
            this.groupBox6.Controls.Add(this.txtVendorCodeSearch);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(17, 59);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(363, 191);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Vendor";
            // 
            // btnSearchVendor
            // 
            this.btnSearchVendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchVendor.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnSearchVendor.Location = new System.Drawing.Point(80, 124);
            this.btnSearchVendor.Name = "btnSearchVendor";
            this.btnSearchVendor.Size = new System.Drawing.Size(196, 50);
            this.btnSearchVendor.TabIndex = 5;
            this.btnSearchVendor.Text = "Search Vendor";
            this.btnSearchVendor.UseVisualStyleBackColor = true;
            this.btnSearchVendor.Click += new System.EventHandler(this.btnSearchVendor_Click);
            // 
            // txtVendorCodeSearch
            // 
            this.txtVendorCodeSearch.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.txtVendorCodeSearch.Location = new System.Drawing.Point(124, 55);
            this.txtVendorCodeSearch.Name = "txtVendorCodeSearch";
            this.txtVendorCodeSearch.Size = new System.Drawing.Size(215, 50);
            this.txtVendorCodeSearch.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.label14.Location = new System.Drawing.Point(15, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 43);
            this.label14.TabIndex = 0;
            this.label14.Text = "Enter Code:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 50);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/View Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtInvoiceIdReadOnly);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAmountPayed);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtInvoiceAmount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtVendorCode2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(395, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 335);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice Infomation";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 9F);
            this.button1.Location = new System.Drawing.Point(304, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInvoiceIdReadOnly
            // 
            this.txtInvoiceIdReadOnly.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.txtInvoiceIdReadOnly.Location = new System.Drawing.Point(163, 262);
            this.txtInvoiceIdReadOnly.Name = "txtInvoiceIdReadOnly";
            this.txtInvoiceIdReadOnly.ReadOnly = true;
            this.txtInvoiceIdReadOnly.Size = new System.Drawing.Size(215, 45);
            this.txtInvoiceIdReadOnly.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label8.Location = new System.Drawing.Point(12, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Invoice ID:";
            // 
            // txtAmountPayed
            // 
            this.txtAmountPayed.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.txtAmountPayed.Location = new System.Drawing.Point(169, 180);
            this.txtAmountPayed.Name = "txtAmountPayed";
            this.txtAmountPayed.Size = new System.Drawing.Size(215, 45);
            this.txtAmountPayed.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label5.Location = new System.Drawing.Point(18, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount Payed:";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.txtInvoiceAmount.Location = new System.Drawing.Point(169, 129);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(215, 45);
            this.txtInvoiceAmount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label6.Location = new System.Drawing.Point(18, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Invoice Amount";
            // 
            // txtVendorCode2
            // 
            this.txtVendorCode2.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.txtVendorCode2.Location = new System.Drawing.Point(169, 78);
            this.txtVendorCode2.Name = "txtVendorCode2";
            this.txtVendorCode2.Size = new System.Drawing.Size(215, 45);
            this.txtVendorCode2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vendor Code:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddInvoice);
            this.groupBox2.Location = new System.Drawing.Point(18, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 143);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Invoice";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddInvoice.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnAddInvoice.Location = new System.Drawing.Point(80, 64);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(196, 50);
            this.btnAddInvoice.TabIndex = 6;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchInvoice);
            this.groupBox1.Controls.Add(this.txtInvoiceIDSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Invoice";
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchInvoice.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnSearchInvoice.Location = new System.Drawing.Point(80, 121);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(196, 50);
            this.btnSearchInvoice.TabIndex = 5;
            this.btnSearchInvoice.Text = "Search Invoice";
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // txtInvoiceIDSearch
            // 
            this.txtInvoiceIDSearch.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.txtInvoiceIDSearch.Location = new System.Drawing.Point(124, 55);
            this.txtInvoiceIDSearch.Name = "txtInvoiceIDSearch";
            this.txtInvoiceIDSearch.Size = new System.Drawing.Size(215, 50);
            this.txtInvoiceIDSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add/View Invoice";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 50);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Invoices";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.invoiceGridView);
            this.groupBox8.Location = new System.Drawing.Point(19, 177);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(757, 224);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "All Invoices";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.label16.Location = new System.Drawing.Point(497, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "Double click amount payed";
            // 
            // invoiceGridView
            // 
            this.invoiceGridView.AllowUserToAddRows = false;
            this.invoiceGridView.AllowUserToDeleteRows = false;
            this.invoiceGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.invoiceGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.invoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.VendorCode,
            this.InvoiceAmount,
            this.AmountPayed,
            this.Save});
            this.invoiceGridView.Location = new System.Drawing.Point(6, 34);
            this.invoiceGridView.Name = "invoiceGridView";
            this.invoiceGridView.RowHeadersVisible = false;
            this.invoiceGridView.RowHeadersWidth = 51;
            this.invoiceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.invoiceGridView.RowTemplate.Height = 24;
            this.invoiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.invoiceGridView.Size = new System.Drawing.Size(745, 184);
            this.invoiceGridView.TabIndex = 0;
            this.invoiceGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceGridView_CellClick);
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "ID";
            this.InvoiceID.MinimumWidth = 6;
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            this.InvoiceID.Width = 110;
            // 
            // VendorCode
            // 
            this.VendorCode.HeaderText = "Vendor Code";
            this.VendorCode.MinimumWidth = 6;
            this.VendorCode.Name = "VendorCode";
            this.VendorCode.ReadOnly = true;
            this.VendorCode.Width = 170;
            // 
            // InvoiceAmount
            // 
            this.InvoiceAmount.HeaderText = "Invoice Amount";
            this.InvoiceAmount.MinimumWidth = 6;
            this.InvoiceAmount.Name = "InvoiceAmount";
            this.InvoiceAmount.ReadOnly = true;
            this.InvoiceAmount.Width = 200;
            // 
            // AmountPayed
            // 
            this.AmountPayed.HeaderText = "Amount Payed";
            this.AmountPayed.MinimumWidth = 6;
            this.AmountPayed.Name = "AmountPayed";
            this.AmountPayed.ReadOnly = true;
            this.AmountPayed.Width = 190;
            // 
            // Save
            // 
            this.Save.HeaderText = "Save";
            this.Save.MinimumWidth = 6;
            this.Save.Name = "Save";
            this.Save.ReadOnly = true;
            this.Save.Width = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 43);
            this.label11.TabIndex = 3;
            this.label11.Text = "Show Invoices for Vendor";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearchVendor2);
            this.groupBox7.Controls.Add(this.txtSearchVendorCode2);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(19, 65);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(757, 106);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search Vendor";
            // 
            // btnSearchVendor2
            // 
            this.btnSearchVendor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchVendor2.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnSearchVendor2.Location = new System.Drawing.Point(470, 38);
            this.btnSearchVendor2.Name = "btnSearchVendor2";
            this.btnSearchVendor2.Size = new System.Drawing.Size(196, 50);
            this.btnSearchVendor2.TabIndex = 5;
            this.btnSearchVendor2.Text = "Search Vendor";
            this.btnSearchVendor2.UseVisualStyleBackColor = true;
            this.btnSearchVendor2.Click += new System.EventHandler(this.btnSearchVendor2_Click);
            // 
            // txtSearchVendorCode2
            // 
            this.txtSearchVendorCode2.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.txtSearchVendorCode2.Location = new System.Drawing.Point(161, 38);
            this.txtSearchVendorCode2.Name = "txtSearchVendorCode2";
            this.txtSearchVendorCode2.Size = new System.Drawing.Size(224, 50);
            this.txtSearchVendorCode2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.label9.Location = new System.Drawing.Point(31, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 43);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enter Code:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.treeView);
            this.tabPage4.Controls.Add(this.btnGenerateCS);
            this.tabPage4.Controls.Add(this.dtpAfter);
            this.tabPage4.Controls.Add(this.dtpBefore);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 50);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 416);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Check Stub";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.lbTotAmtPayed);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.lbTotAmtDue);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Font = new System.Drawing.Font("Myanmar Text", 10F);
            this.groupBox9.Location = new System.Drawing.Point(601, 100);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(173, 298);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Amount Due";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(16, 100);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(573, 298);
            this.treeView.TabIndex = 7;
            // 
            // btnGenerateCS
            // 
            this.btnGenerateCS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateCS.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.btnGenerateCS.Location = new System.Drawing.Point(624, 22);
            this.btnGenerateCS.Name = "btnGenerateCS";
            this.btnGenerateCS.Size = new System.Drawing.Size(150, 50);
            this.btnGenerateCS.TabIndex = 6;
            this.btnGenerateCS.Text = "Generate";
            this.btnGenerateCS.UseVisualStyleBackColor = true;
            this.btnGenerateCS.Click += new System.EventHandler(this.btnGenerateCS_Click);
            // 
            // dtpAfter
            // 
            this.dtpAfter.Location = new System.Drawing.Point(402, 29);
            this.dtpAfter.Name = "dtpAfter";
            this.dtpAfter.Size = new System.Drawing.Size(200, 50);
            this.dtpAfter.TabIndex = 5;
            // 
            // dtpBefore
            // 
            this.dtpBefore.CustomFormat = "MMM:DD:YYYY";
            this.dtpBefore.Location = new System.Drawing.Point(162, 29);
            this.dtpBefore.Name = "dtpBefore";
            this.dtpBefore.Size = new System.Drawing.Size(200, 50);
            this.dtpBefore.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 43);
            this.label17.TabIndex = 3;
            this.label17.Text = "Date Range:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 43);
            this.label7.TabIndex = 2;
            this.label7.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 30);
            this.label18.TabIndex = 3;
            this.label18.Text = "Total Amount Due:";
            // 
            // lbTotAmtDue
            // 
            this.lbTotAmtDue.AutoSize = true;
            this.lbTotAmtDue.BackColor = System.Drawing.Color.White;
            this.lbTotAmtDue.Location = new System.Drawing.Point(49, 104);
            this.lbTotAmtDue.Name = "lbTotAmtDue";
            this.lbTotAmtDue.Size = new System.Drawing.Size(80, 30);
            this.lbTotAmtDue.TabIndex = 4;
            this.lbTotAmtDue.Text = "$0000.00";
            // 
            // lbTotAmtPayed
            // 
            this.lbTotAmtPayed.AutoSize = true;
            this.lbTotAmtPayed.BackColor = System.Drawing.Color.White;
            this.lbTotAmtPayed.Location = new System.Drawing.Point(49, 199);
            this.lbTotAmtPayed.Name = "lbTotAmtPayed";
            this.lbTotAmtPayed.Size = new System.Drawing.Size(80, 30);
            this.lbTotAmtPayed.TabIndex = 6;
            this.lbTotAmtPayed.Text = "$0000.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(173, 30);
            this.label20.TabIndex = 5;
            this.label20.Text = "Total Amount Payed:";
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 563);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Myanmar Text", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.Name = "VendorForm";
            this.Text = "VendorForm";
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridView)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvoiceIDSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TextBox txtInvoiceIdReadOnly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountPayed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendorCode2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtVendorCode1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVendorName1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSearchVendor;
        private System.Windows.Forms.TextBox txtVendorCodeSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoveVendor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSearchVendor2;
        private System.Windows.Forms.TextBox txtSearchVendorCode2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView invoiceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayed;
        private System.Windows.Forms.DataGridViewButtonColumn Save;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerateCS;
        private System.Windows.Forms.DateTimePicker dtpAfter;
        private System.Windows.Forms.DateTimePicker dtpBefore;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lbTotAmtPayed;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTotAmtDue;
        private System.Windows.Forms.Label label18;
    }
}