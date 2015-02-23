﻿namespace PureOn
{
    partial class AddHistoryCard
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
            this.custID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HistoryGroup = new System.Windows.Forms.GroupBox();
            this.icrdate = new System.Windows.Forms.DateTimePicker();
            this.amount = new System.Windows.Forms.TextBox();
            this.icr = new System.Windows.Forms.TextBox();
            this.iccr = new System.Windows.Forms.TextBox();
            this.wrkDetails = new System.Windows.Forms.GroupBox();
            this.serviceRdBtn = new System.Windows.Forms.RadioButton();
            this.installRdBtn = new System.Windows.Forms.RadioButton();
            this.visitDt = new System.Windows.Forms.DateTimePicker();
            this.partsRepalcedGroup = new System.Windows.Forms.GroupBox();
            this.addPartsReplaced = new System.Windows.Forms.Button();
            this.partsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.addHCard = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.serviceEng = new System.Windows.Forms.ComboBox();
            this.HistoryGroup.SuspendLayout();
            this.wrkDetails.SuspendLayout();
            this.partsRepalcedGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // custID
            // 
            this.custID.Enabled = false;
            this.custID.Location = new System.Drawing.Point(114, 29);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(100, 20);
            this.custID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visit Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ICR No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ICCR No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ICR Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount Charged";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Service Engineer:";
            // 
            // HistoryGroup
            // 
            this.HistoryGroup.Controls.Add(this.serviceEng);
            this.HistoryGroup.Controls.Add(this.icrdate);
            this.HistoryGroup.Controls.Add(this.amount);
            this.HistoryGroup.Controls.Add(this.icr);
            this.HistoryGroup.Controls.Add(this.iccr);
            this.HistoryGroup.Controls.Add(this.wrkDetails);
            this.HistoryGroup.Controls.Add(this.visitDt);
            this.HistoryGroup.Controls.Add(this.label9);
            this.HistoryGroup.Controls.Add(this.label8);
            this.HistoryGroup.Controls.Add(this.label7);
            this.HistoryGroup.Controls.Add(this.label6);
            this.HistoryGroup.Controls.Add(this.label5);
            this.HistoryGroup.Controls.Add(this.label2);
            this.HistoryGroup.Controls.Add(this.label1);
            this.HistoryGroup.Controls.Add(this.custID);
            this.HistoryGroup.Location = new System.Drawing.Point(9, 7);
            this.HistoryGroup.Name = "HistoryGroup";
            this.HistoryGroup.Size = new System.Drawing.Size(279, 371);
            this.HistoryGroup.TabIndex = 10;
            this.HistoryGroup.TabStop = false;
            this.HistoryGroup.Text = "History Card Details";
            // 
            // icrdate
            // 
            this.icrdate.Location = new System.Drawing.Point(73, 258);
            this.icrdate.Name = "icrdate";
            this.icrdate.Size = new System.Drawing.Size(200, 20);
            this.icrdate.TabIndex = 17;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(114, 294);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 15;
            // 
            // icr
            // 
            this.icr.Location = new System.Drawing.Point(114, 215);
            this.icr.Name = "icr";
            this.icr.Size = new System.Drawing.Size(100, 20);
            this.icr.TabIndex = 13;
            // 
            // iccr
            // 
            this.iccr.Location = new System.Drawing.Point(114, 175);
            this.iccr.Name = "iccr";
            this.iccr.Size = new System.Drawing.Size(100, 20);
            this.iccr.TabIndex = 12;
            // 
            // wrkDetails
            // 
            this.wrkDetails.Controls.Add(this.serviceRdBtn);
            this.wrkDetails.Controls.Add(this.installRdBtn);
            this.wrkDetails.Location = new System.Drawing.Point(17, 110);
            this.wrkDetails.Name = "wrkDetails";
            this.wrkDetails.Size = new System.Drawing.Size(243, 55);
            this.wrkDetails.TabIndex = 11;
            this.wrkDetails.TabStop = false;
            this.wrkDetails.Text = "Work Details";
            // 
            // serviceRdBtn
            // 
            this.serviceRdBtn.AutoSize = true;
            this.serviceRdBtn.Location = new System.Drawing.Point(122, 26);
            this.serviceRdBtn.Name = "serviceRdBtn";
            this.serviceRdBtn.Size = new System.Drawing.Size(61, 17);
            this.serviceRdBtn.TabIndex = 1;
            this.serviceRdBtn.TabStop = true;
            this.serviceRdBtn.Text = "Service";
            this.serviceRdBtn.UseVisualStyleBackColor = true;
            // 
            // installRdBtn
            // 
            this.installRdBtn.AutoSize = true;
            this.installRdBtn.Checked = true;
            this.installRdBtn.Location = new System.Drawing.Point(26, 25);
            this.installRdBtn.Name = "installRdBtn";
            this.installRdBtn.Size = new System.Drawing.Size(75, 17);
            this.installRdBtn.TabIndex = 0;
            this.installRdBtn.TabStop = true;
            this.installRdBtn.Text = "Installation";
            this.installRdBtn.UseVisualStyleBackColor = true;
            // 
            // visitDt
            // 
            this.visitDt.Location = new System.Drawing.Point(73, 64);
            this.visitDt.Name = "visitDt";
            this.visitDt.Size = new System.Drawing.Size(200, 20);
            this.visitDt.TabIndex = 10;
            // 
            // partsRepalcedGroup
            // 
            this.partsRepalcedGroup.Controls.Add(this.addPartsReplaced);
            this.partsRepalcedGroup.Controls.Add(this.partsFlow);
            this.partsRepalcedGroup.Location = new System.Drawing.Point(304, 12);
            this.partsRepalcedGroup.Name = "partsRepalcedGroup";
            this.partsRepalcedGroup.Size = new System.Drawing.Size(308, 342);
            this.partsRepalcedGroup.TabIndex = 11;
            this.partsRepalcedGroup.TabStop = false;
            this.partsRepalcedGroup.Text = "Parts Replaced";
            // 
            // addPartsReplaced
            // 
            this.addPartsReplaced.Location = new System.Drawing.Point(21, 27);
            this.addPartsReplaced.Name = "addPartsReplaced";
            this.addPartsReplaced.Size = new System.Drawing.Size(75, 23);
            this.addPartsReplaced.TabIndex = 1;
            this.addPartsReplaced.Text = "Add";
            this.addPartsReplaced.UseVisualStyleBackColor = true;
            this.addPartsReplaced.Click += new System.EventHandler(this.addPartsReplaced_Click);
            // 
            // partsFlow
            // 
            this.partsFlow.Location = new System.Drawing.Point(6, 59);
            this.partsFlow.Name = "partsFlow";
            this.partsFlow.Size = new System.Drawing.Size(296, 277);
            this.partsFlow.TabIndex = 0;
            // 
            // addHCard
            // 
            this.addHCard.Location = new System.Drawing.Point(325, 364);
            this.addHCard.Name = "addHCard";
            this.addHCard.Size = new System.Drawing.Size(101, 23);
            this.addHCard.TabIndex = 12;
            this.addHCard.Text = "Add History Card";
            this.addHCard.UseVisualStyleBackColor = true;
            this.addHCard.Click += new System.EventHandler(this.addHCard_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(449, 364);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // serviceEng
            // 
            this.serviceEng.FormattingEnabled = true;
            this.serviceEng.Location = new System.Drawing.Point(111, 331);
            this.serviceEng.Name = "serviceEng";
            this.serviceEng.Size = new System.Drawing.Size(121, 21);
            this.serviceEng.Sorted = true;
            this.serviceEng.TabIndex = 18;
            // 
            // AddHistoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 396);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addHCard);
            this.Controls.Add(this.partsRepalcedGroup);
            this.Controls.Add(this.HistoryGroup);
            this.Name = "AddHistoryCard";
            this.Text = "AddHistoryCard";
            this.HistoryGroup.ResumeLayout(false);
            this.HistoryGroup.PerformLayout();
            this.wrkDetails.ResumeLayout(false);
            this.wrkDetails.PerformLayout();
            this.partsRepalcedGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox HistoryGroup;
        private System.Windows.Forms.GroupBox partsRepalcedGroup;
        private System.Windows.Forms.Button addHCard;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox icr;
        private System.Windows.Forms.TextBox iccr;
        private System.Windows.Forms.GroupBox wrkDetails;
        private System.Windows.Forms.RadioButton serviceRdBtn;
        private System.Windows.Forms.RadioButton installRdBtn;
        private System.Windows.Forms.DateTimePicker visitDt;
        private System.Windows.Forms.Button addPartsReplaced;
        private System.Windows.Forms.FlowLayoutPanel partsFlow;
        private System.Windows.Forms.DateTimePicker icrdate;
        private System.Windows.Forms.ComboBox serviceEng;
    }
}