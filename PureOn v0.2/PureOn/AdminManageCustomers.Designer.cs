﻿namespace PureOn
{
    partial class Admin_Manage_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Manage_Users));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.customerData = new System.Windows.Forms.GroupBox();
            this.pinCode = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.doorNo = new System.Windows.Forms.TextBox();
            this.phonePrime = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.customerData.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(304, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(742, 452);
            this.dataGridView.TabIndex = 36;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // customerData
            // 
            this.customerData.Controls.Add(this.pinCode);
            this.customerData.Controls.Add(this.street);
            this.customerData.Controls.Add(this.doorNo);
            this.customerData.Controls.Add(this.phonePrime);
            this.customerData.Controls.Add(this.custName);
            this.customerData.Controls.Add(this.label6);
            this.customerData.Controls.Add(this.label5);
            this.customerData.Controls.Add(this.label3);
            this.customerData.Controls.Add(this.label2);
            this.customerData.Controls.Add(this.label7);
            this.customerData.Controls.Add(this.label1);
            this.customerData.Controls.Add(this.custID);
            this.customerData.Location = new System.Drawing.Point(8, 12);
            this.customerData.Name = "customerData";
            this.customerData.Size = new System.Drawing.Size(275, 384);
            this.customerData.TabIndex = 35;
            this.customerData.TabStop = false;
            this.customerData.Text = "Search Customer Data";
            // 
            // pinCode
            // 
            this.pinCode.Location = new System.Drawing.Point(100, 330);
            this.pinCode.Name = "pinCode";
            this.pinCode.Size = new System.Drawing.Size(150, 20);
            this.pinCode.TabIndex = 19;
            this.pinCode.TextChanged += new System.EventHandler(this.pinCode_TextChanged);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(100, 270);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(150, 20);
            this.street.TabIndex = 18;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged_1);
            // 
            // doorNo
            // 
            this.doorNo.Location = new System.Drawing.Point(100, 210);
            this.doorNo.Name = "doorNo";
            this.doorNo.Size = new System.Drawing.Size(150, 20);
            this.doorNo.TabIndex = 17;
            this.doorNo.TextChanged += new System.EventHandler(this.doorNo_TextChanged);
            // 
            // phonePrime
            // 
            this.phonePrime.Location = new System.Drawing.Point(100, 150);
            this.phonePrime.Name = "phonePrime";
            this.phonePrime.Size = new System.Drawing.Size(150, 20);
            this.phonePrime.TabIndex = 15;
            this.phonePrime.TextChanged += new System.EventHandler(this.phonePrime_TextChanged);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(100, 90);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(150, 20);
            this.custName.TabIndex = 14;
            this.custName.TextChanged += new System.EventHandler(this.custName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Door No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone (primary)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pin code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(100, 30);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(150, 20);
            this.custID.TabIndex = 0;
            this.custID.TextChanged += new System.EventHandler(this.custID_TextChanged);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(8, 420);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(275, 23);
            this.addCustomerBtn.TabIndex = 34;
            this.addCustomerBtn.Text = "Add New Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // Admin_Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 476);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.customerData);
            this.Controls.Add(this.addCustomerBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Manage_Users";
            this.Text = "Manage Customers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Manage_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.customerData.ResumeLayout(false);
            this.customerData.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox customerData;
        private System.Windows.Forms.TextBox pinCode;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox doorNo;
        private System.Windows.Forms.TextBox phonePrime;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}