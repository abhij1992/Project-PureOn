namespace PureOn
{
    partial class History
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
            this.FilterDetails = new System.Windows.Forms.GroupBox();
            this.unitSlNo = new System.Windows.Forms.TextBox();
            this.filterModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerData = new System.Windows.Forms.GroupBox();
            this.phonePrime = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilterDetails.SuspendLayout();
            this.customerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterDetails
            // 
            this.FilterDetails.Controls.Add(this.textBox1);
            this.FilterDetails.Controls.Add(this.unitSlNo);
            this.FilterDetails.Controls.Add(this.filterModel);
            this.FilterDetails.Controls.Add(this.label10);
            this.FilterDetails.Controls.Add(this.label9);
            this.FilterDetails.Controls.Add(this.label8);
            this.FilterDetails.Location = new System.Drawing.Point(12, 129);
            this.FilterDetails.Name = "FilterDetails";
            this.FilterDetails.Size = new System.Drawing.Size(274, 129);
            this.FilterDetails.TabIndex = 34;
            this.FilterDetails.TabStop = false;
            this.FilterDetails.Text = "Filter Details";
            // 
            // unitSlNo
            // 
            this.unitSlNo.Location = new System.Drawing.Point(143, 89);
            this.unitSlNo.Name = "unitSlNo";
            this.unitSlNo.ReadOnly = true;
            this.unitSlNo.Size = new System.Drawing.Size(100, 20);
            this.unitSlNo.TabIndex = 22;
            // 
            // filterModel
            // 
            this.filterModel.Location = new System.Drawing.Point(143, 13);
            this.filterModel.Name = "filterModel";
            this.filterModel.ReadOnly = true;
            this.filterModel.Size = new System.Drawing.Size(100, 20);
            this.filterModel.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Unit Slno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date of Installation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Filter Model";
            // 
            // customerData
            // 
            this.customerData.Controls.Add(this.phonePrime);
            this.customerData.Controls.Add(this.custName);
            this.customerData.Controls.Add(this.label3);
            this.customerData.Controls.Add(this.label2);
            this.customerData.Controls.Add(this.label1);
            this.customerData.Controls.Add(this.custID);
            this.customerData.Location = new System.Drawing.Point(12, 12);
            this.customerData.Name = "customerData";
            this.customerData.Size = new System.Drawing.Size(274, 111);
            this.customerData.TabIndex = 33;
            this.customerData.TabStop = false;
            this.customerData.Text = "Customer Data";
            // 
            // phonePrime
            // 
            this.phonePrime.Location = new System.Drawing.Point(143, 78);
            this.phonePrime.Name = "phonePrime";
            this.phonePrime.ReadOnly = true;
            this.phonePrime.Size = new System.Drawing.Size(100, 20);
            this.phonePrime.TabIndex = 15;
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(143, 46);
            this.custName.Name = "custName";
            this.custName.ReadOnly = true;
            this.custName.Size = new System.Drawing.Size(100, 20);
            this.custName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone (primary)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
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
            this.custID.ReadOnly = true;
            this.custID.Size = new System.Drawing.Size(100, 20);
            this.custID.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.Controls.Add(this.FilterDetails);
            this.Controls.Add(this.customerData);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.FilterDetails.ResumeLayout(false);
            this.FilterDetails.PerformLayout();
            this.customerData.ResumeLayout(false);
            this.customerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilterDetails;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox unitSlNo;
        public System.Windows.Forms.TextBox filterModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox customerData;
        public System.Windows.Forms.TextBox phonePrime;
        public System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox custID;
    }
}