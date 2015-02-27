namespace PureOn
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.lConnected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(167, 40);
            this.userText.MaxLength = 15;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 20);
            this.userText.TabIndex = 2;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(167, 75);
            this.passText.MaxLength = 15;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(100, 20);
            this.passText.TabIndex = 3;
            this.passText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passText_KeyPress);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(176, 111);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // lConnected
            // 
            this.lConnected.AutoSize = true;
            this.lConnected.Location = new System.Drawing.Point(3, 161);
            this.lConnected.Name = "lConnected";
            this.lConnected.Size = new System.Drawing.Size(35, 13);
            this.lConnected.TabIndex = 5;
            this.lConnected.Text = "label3";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 183);
            this.Controls.Add(this.lConnected);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label lConnected;
    }
}

