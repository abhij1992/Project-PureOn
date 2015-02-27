namespace PureOn
{
    partial class AdminPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.mngExe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mngExe
            // 
            this.mngExe.Location = new System.Drawing.Point(131, 68);
            this.mngExe.Name = "mngExe";
            this.mngExe.Size = new System.Drawing.Size(122, 32);
            this.mngExe.TabIndex = 1;
            this.mngExe.Text = "Manage Executives";
            this.mngExe.UseVisualStyleBackColor = true;
            this.mngExe.Click += new System.EventHandler(this.mngExe_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage Customers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // revenueBtn
            // 
            this.revenueBtn.Location = new System.Drawing.Point(132, 182);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(121, 32);
            this.revenueBtn.TabIndex = 3;
            this.revenueBtn.Text = "Revenue Details";
            this.revenueBtn.UseVisualStyleBackColor = true;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 237);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mngExe);
            this.Controls.Add(this.button1);
            this.Name = "AdminPage";
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mngExe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button revenueBtn;
    }
}