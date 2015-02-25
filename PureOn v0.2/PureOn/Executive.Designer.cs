namespace PureOn
{
    partial class Executive
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
            this.addCustomerBtn = new System.Windows.Forms.Button();
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.customerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(53, 275);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(176, 23);
            this.addCustomerBtn.TabIndex = 0;
            this.addCustomerBtn.Text = "Add New Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
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
            this.customerData.Location = new System.Drawing.Point(12, 12);
            this.customerData.Name = "customerData";
            this.customerData.Size = new System.Drawing.Size(275, 252);
            this.customerData.TabIndex = 32;
            this.customerData.TabStop = false;
            this.customerData.Text = "Search Customer Data";
            // 
            // pinCode
            // 
            this.pinCode.Location = new System.Drawing.Point(143, 181);
            this.pinCode.Name = "pinCode";
            this.pinCode.Size = new System.Drawing.Size(100, 20);
            this.pinCode.TabIndex = 19;
            this.pinCode.TextChanged += new System.EventHandler(this.pinCode_TextChanged);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(143, 148);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 20);
            this.street.TabIndex = 18;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // doorNo
            // 
            this.doorNo.Location = new System.Drawing.Point(143, 115);
            this.doorNo.Name = "doorNo";
            this.doorNo.Size = new System.Drawing.Size(100, 20);
            this.doorNo.TabIndex = 17;
            this.doorNo.TextChanged += new System.EventHandler(this.doorNo_TextChanged);
            // 
            // phonePrime
            // 
            this.phonePrime.Location = new System.Drawing.Point(143, 82);
            this.phonePrime.Name = "phonePrime";
            this.phonePrime.Size = new System.Drawing.Size(100, 20);
            this.phonePrime.TabIndex = 15;
            this.phonePrime.TextChanged += new System.EventHandler(this.phonePrime_TextChanged);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(143, 49);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(100, 20);
            this.custName.TabIndex = 14;
            this.custName.TextChanged += new System.EventHandler(this.custName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Door No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone (primary)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pin code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(143, 16);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(100, 20);
            this.custID.TabIndex = 0;
            this.custID.TextChanged += new System.EventHandler(this.custID_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(308, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(606, 252);
            this.dataGridView.TabIndex = 33;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // Executive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 310);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.customerData);
            this.Controls.Add(this.addCustomerBtn);
            this.Name = "Executive";
            this.Text = "Executive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Executive_FormClosing);
            this.Load += new System.EventHandler(this.Executive_Load);
            this.customerData.ResumeLayout(false);
            this.customerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCustomerBtn;
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
        private System.Windows.Forms.DataGridView dataGridView;
    }
}