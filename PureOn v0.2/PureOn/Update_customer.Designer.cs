namespace PureOn
{
    partial class Update_customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_customer));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.FilterDetails = new System.Windows.Forms.GroupBox();
            this.unitSlNo = new System.Windows.Forms.TextBox();
            this.dateOfInstallation = new System.Windows.Forms.DateTimePicker();
            this.filterModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerData = new System.Windows.Forms.GroupBox();
            this.pinCode = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.doorNo = new System.Windows.Forms.TextBox();
            this.phoneAlt = new System.Windows.Forms.TextBox();
            this.phonePrime = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.TextBox();
            this.UserAt = new System.Windows.Forms.GroupBox();
            this.office = new System.Windows.Forms.RadioButton();
            this.residence = new System.Windows.Forms.RadioButton();
            this.both = new System.Windows.Forms.RadioButton();
            this.ContractDetails = new System.Windows.Forms.GroupBox();
            this.acmcGroupBox = new System.Windows.Forms.GroupBox();
            this.acmcCheckList = new System.Windows.Forms.CheckedListBox();
            this.none = new System.Windows.Forms.RadioButton();
            this.amc = new System.Windows.Forms.RadioButton();
            this.acmc = new System.Windows.Forms.RadioButton();
            this.warrantyDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addHistBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterDetails.SuspendLayout();
            this.customerData.SuspendLayout();
            this.UserAt.SuspendLayout();
            this.ContractDetails.SuspendLayout();
            this.acmcGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(91, 663);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 25);
            this.cancelBtn.TabIndex = 42;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 632);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(150, 25);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update Customer";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // FilterDetails
            // 
            this.FilterDetails.Controls.Add(this.unitSlNo);
            this.FilterDetails.Controls.Add(this.dateOfInstallation);
            this.FilterDetails.Controls.Add(this.filterModel);
            this.FilterDetails.Controls.Add(this.label10);
            this.FilterDetails.Controls.Add(this.label9);
            this.FilterDetails.Controls.Add(this.label8);
            this.FilterDetails.Location = new System.Drawing.Point(12, 246);
            this.FilterDetails.Name = "FilterDetails";
            this.FilterDetails.Size = new System.Drawing.Size(322, 107);
            this.FilterDetails.TabIndex = 40;
            this.FilterDetails.TabStop = false;
            this.FilterDetails.Text = "Filter Details";
            // 
            // unitSlNo
            // 
            this.unitSlNo.Location = new System.Drawing.Point(117, 75);
            this.unitSlNo.MaxLength = 20;
            this.unitSlNo.Name = "unitSlNo";
            this.unitSlNo.Size = new System.Drawing.Size(150, 20);
            this.unitSlNo.TabIndex = 22;
            // 
            // dateOfInstallation
            // 
            this.dateOfInstallation.Location = new System.Drawing.Point(113, 45);
            this.dateOfInstallation.Name = "dateOfInstallation";
            this.dateOfInstallation.Size = new System.Drawing.Size(200, 20);
            this.dateOfInstallation.TabIndex = 21;
            // 
            // filterModel
            // 
            this.filterModel.Location = new System.Drawing.Point(117, 15);
            this.filterModel.MaxLength = 50;
            this.filterModel.Name = "filterModel";
            this.filterModel.Size = new System.Drawing.Size(150, 20);
            this.filterModel.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Unit Slno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date of Installation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Filter Model";
            // 
            // customerData
            // 
            this.customerData.Controls.Add(this.pinCode);
            this.customerData.Controls.Add(this.street);
            this.customerData.Controls.Add(this.doorNo);
            this.customerData.Controls.Add(this.phoneAlt);
            this.customerData.Controls.Add(this.phonePrime);
            this.customerData.Controls.Add(this.custName);
            this.customerData.Controls.Add(this.label6);
            this.customerData.Controls.Add(this.label5);
            this.customerData.Controls.Add(this.label4);
            this.customerData.Controls.Add(this.label3);
            this.customerData.Controls.Add(this.label2);
            this.customerData.Controls.Add(this.label7);
            this.customerData.Controls.Add(this.label1);
            this.customerData.Controls.Add(this.custID);
            this.customerData.Location = new System.Drawing.Point(12, 12);
            this.customerData.Name = "customerData";
            this.customerData.Size = new System.Drawing.Size(322, 228);
            this.customerData.TabIndex = 39;
            this.customerData.TabStop = false;
            this.customerData.Text = "Customer Data";
            // 
            // pinCode
            // 
            this.pinCode.Location = new System.Drawing.Point(117, 195);
            this.pinCode.MaxLength = 15;
            this.pinCode.Name = "pinCode";
            this.pinCode.Size = new System.Drawing.Size(150, 20);
            this.pinCode.TabIndex = 19;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(117, 165);
            this.street.MaxLength = 140;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(150, 20);
            this.street.TabIndex = 18;
            // 
            // doorNo
            // 
            this.doorNo.Location = new System.Drawing.Point(117, 135);
            this.doorNo.MaxLength = 10;
            this.doorNo.Name = "doorNo";
            this.doorNo.Size = new System.Drawing.Size(150, 20);
            this.doorNo.TabIndex = 17;
            // 
            // phoneAlt
            // 
            this.phoneAlt.Location = new System.Drawing.Point(117, 105);
            this.phoneAlt.MaxLength = 12;
            this.phoneAlt.Name = "phoneAlt";
            this.phoneAlt.Size = new System.Drawing.Size(150, 20);
            this.phoneAlt.TabIndex = 16;
            // 
            // phonePrime
            // 
            this.phonePrime.Location = new System.Drawing.Point(117, 75);
            this.phonePrime.MaxLength = 12;
            this.phonePrime.Name = "phonePrime";
            this.phonePrime.Size = new System.Drawing.Size(150, 20);
            this.phonePrime.TabIndex = 15;
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(117, 45);
            this.custName.MaxLength = 50;
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(150, 20);
            this.custName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Door No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone (alternate)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone (primary)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pin code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(117, 15);
            this.custID.Name = "custID";
            this.custID.ReadOnly = true;
            this.custID.Size = new System.Drawing.Size(150, 20);
            this.custID.TabIndex = 0;
            // 
            // UserAt
            // 
            this.UserAt.Controls.Add(this.office);
            this.UserAt.Controls.Add(this.residence);
            this.UserAt.Controls.Add(this.both);
            this.UserAt.Location = new System.Drawing.Point(12, 359);
            this.UserAt.Name = "UserAt";
            this.UserAt.Size = new System.Drawing.Size(322, 47);
            this.UserAt.TabIndex = 38;
            this.UserAt.TabStop = false;
            this.UserAt.Text = "Used At";
            // 
            // office
            // 
            this.office.AutoSize = true;
            this.office.Checked = true;
            this.office.Location = new System.Drawing.Point(29, 18);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(53, 17);
            this.office.TabIndex = 24;
            this.office.TabStop = true;
            this.office.Text = "Office";
            this.office.UseVisualStyleBackColor = true;
            // 
            // residence
            // 
            this.residence.AutoSize = true;
            this.residence.Location = new System.Drawing.Point(113, 18);
            this.residence.Name = "residence";
            this.residence.Size = new System.Drawing.Size(76, 17);
            this.residence.TabIndex = 25;
            this.residence.Text = "Residence";
            this.residence.UseVisualStyleBackColor = true;
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.Location = new System.Drawing.Point(220, 19);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(47, 17);
            this.both.TabIndex = 26;
            this.both.Text = "Both";
            this.both.UseVisualStyleBackColor = true;
            // 
            // ContractDetails
            // 
            this.ContractDetails.Controls.Add(this.acmcGroupBox);
            this.ContractDetails.Controls.Add(this.none);
            this.ContractDetails.Controls.Add(this.amc);
            this.ContractDetails.Controls.Add(this.acmc);
            this.ContractDetails.Location = new System.Drawing.Point(12, 438);
            this.ContractDetails.Name = "ContractDetails";
            this.ContractDetails.Size = new System.Drawing.Size(296, 188);
            this.ContractDetails.TabIndex = 37;
            this.ContractDetails.TabStop = false;
            this.ContractDetails.Text = "Contract Details";
            // 
            // acmcGroupBox
            // 
            this.acmcGroupBox.Controls.Add(this.acmcCheckList);
            this.acmcGroupBox.Location = new System.Drawing.Point(16, 42);
            this.acmcGroupBox.Name = "acmcGroupBox";
            this.acmcGroupBox.Size = new System.Drawing.Size(260, 139);
            this.acmcGroupBox.TabIndex = 30;
            this.acmcGroupBox.TabStop = false;
            this.acmcGroupBox.Text = "ACMC Insurance covered";
            // 
            // acmcCheckList
            // 
            this.acmcCheckList.CheckOnClick = true;
            this.acmcCheckList.FormattingEnabled = true;
            this.acmcCheckList.Items.AddRange(new object[] {
            "Sedement",
            "Carbon",
            "R O Membrane",
            "Solinide valve (SV)",
            "Pump",
            "Flow rejection Tube (FRT)",
            "Float valve",
            "TDS valve",
            "Choke",
            "UV Lamp",
            "UV chamber",
            "Connectors L&T",
            "Adaptor"});
            this.acmcCheckList.Location = new System.Drawing.Point(13, 21);
            this.acmcCheckList.Name = "acmcCheckList";
            this.acmcCheckList.Size = new System.Drawing.Size(241, 109);
            this.acmcCheckList.TabIndex = 0;
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(216, 19);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(51, 17);
            this.none.TabIndex = 29;
            this.none.TabStop = true;
            this.none.Text = "None";
            this.none.UseVisualStyleBackColor = true;
            // 
            // amc
            // 
            this.amc.AutoSize = true;
            this.amc.Checked = true;
            this.amc.Location = new System.Drawing.Point(29, 19);
            this.amc.Name = "amc";
            this.amc.Size = new System.Drawing.Size(48, 17);
            this.amc.TabIndex = 27;
            this.amc.TabStop = true;
            this.amc.Text = "AMC";
            this.amc.UseVisualStyleBackColor = true;
            // 
            // acmc
            // 
            this.acmc.AutoSize = true;
            this.acmc.Location = new System.Drawing.Point(113, 19);
            this.acmc.Name = "acmc";
            this.acmc.Size = new System.Drawing.Size(55, 17);
            this.acmc.TabIndex = 28;
            this.acmc.Text = "ACMC";
            this.acmc.UseVisualStyleBackColor = true;
            this.acmc.CheckedChanged += new System.EventHandler(this.acmc_CheckedChanged);
            // 
            // warrantyDate
            // 
            this.warrantyDate.Location = new System.Drawing.Point(125, 418);
            this.warrantyDate.Name = "warrantyDate";
            this.warrantyDate.Size = new System.Drawing.Size(200, 20);
            this.warrantyDate.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Warranty  Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(340, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(636, 640);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // addHistBtn
            // 
            this.addHistBtn.Location = new System.Drawing.Point(173, 632);
            this.addHistBtn.Name = "addHistBtn";
            this.addHistBtn.Size = new System.Drawing.Size(150, 25);
            this.addHistBtn.TabIndex = 44;
            this.addHistBtn.Text = "Add History";
            this.addHistBtn.UseVisualStyleBackColor = true;
            this.addHistBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(148, 22);
            this.DeleteRow.Text = "Delete History";
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // Update_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 696);
            this.Controls.Add(this.addHistBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.FilterDetails);
            this.Controls.Add(this.customerData);
            this.Controls.Add(this.UserAt);
            this.Controls.Add(this.ContractDetails);
            this.Controls.Add(this.warrantyDate);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_customer";
            this.Text = "Update Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Update_customer_Activated);
            this.Load += new System.EventHandler(this.Update_customer_Load);
            this.FilterDetails.ResumeLayout(false);
            this.FilterDetails.PerformLayout();
            this.customerData.ResumeLayout(false);
            this.customerData.PerformLayout();
            this.UserAt.ResumeLayout(false);
            this.UserAt.PerformLayout();
            this.ContractDetails.ResumeLayout(false);
            this.ContractDetails.PerformLayout();
            this.acmcGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox FilterDetails;
        private System.Windows.Forms.TextBox unitSlNo;
        private System.Windows.Forms.DateTimePicker dateOfInstallation;
        private System.Windows.Forms.TextBox filterModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox customerData;
        private System.Windows.Forms.TextBox pinCode;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox doorNo;
        private System.Windows.Forms.TextBox phoneAlt;
        private System.Windows.Forms.TextBox phonePrime;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UserAt;
        private System.Windows.Forms.RadioButton office;
        private System.Windows.Forms.RadioButton residence;
        private System.Windows.Forms.RadioButton both;
        private System.Windows.Forms.GroupBox ContractDetails;
        private System.Windows.Forms.RadioButton amc;
        private System.Windows.Forms.RadioButton acmc;
        private System.Windows.Forms.DateTimePicker warrantyDate;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addHistBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteRow;
        private System.Windows.Forms.RadioButton none;
        private System.Windows.Forms.GroupBox acmcGroupBox;
        private System.Windows.Forms.CheckedListBox acmcCheckList;
    }
}