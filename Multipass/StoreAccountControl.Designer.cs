namespace Multipass
{
    partial class StoreAccountControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStoreAccount = new System.Windows.Forms.Label();
            this.tbAccountEmail = new System.Windows.Forms.TextBox();
            this.tbAccountUsername = new System.Windows.Forms.TextBox();
            this.tbAccountPassword = new System.Windows.Forms.TextBox();
            this.tbWebLink = new System.Windows.Forms.TextBox();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStoreAccount
            // 
            this.labelStoreAccount.AutoSize = true;
            this.labelStoreAccount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreAccount.Location = new System.Drawing.Point(20, 20);
            this.labelStoreAccount.Name = "labelStoreAccount";
            this.labelStoreAccount.Size = new System.Drawing.Size(163, 22);
            this.labelStoreAccount.TabIndex = 1;
            this.labelStoreAccount.Text = "Save new account";
            // 
            // tbAccountEmail
            // 
            this.tbAccountEmail.Location = new System.Drawing.Point(24, 82);
            this.tbAccountEmail.Name = "tbAccountEmail";
            this.tbAccountEmail.Size = new System.Drawing.Size(166, 20);
            this.tbAccountEmail.TabIndex = 2;
            this.tbAccountEmail.Text = "Account email";
            // 
            // tbAccountUsername
            // 
            this.tbAccountUsername.Location = new System.Drawing.Point(196, 82);
            this.tbAccountUsername.Name = "tbAccountUsername";
            this.tbAccountUsername.Size = new System.Drawing.Size(159, 20);
            this.tbAccountUsername.TabIndex = 3;
            this.tbAccountUsername.Text = "Account username";
            // 
            // tbAccountPassword
            // 
            this.tbAccountPassword.Location = new System.Drawing.Point(24, 130);
            this.tbAccountPassword.Name = "tbAccountPassword";
            this.tbAccountPassword.Size = new System.Drawing.Size(331, 20);
            this.tbAccountPassword.TabIndex = 4;
            this.tbAccountPassword.Text = "Account password";
            // 
            // tbWebLink
            // 
            this.tbWebLink.Location = new System.Drawing.Point(24, 271);
            this.tbWebLink.Name = "tbWebLink";
            this.tbWebLink.Size = new System.Drawing.Size(331, 20);
            this.tbWebLink.TabIndex = 5;
            this.tbWebLink.Text = "Website URL";
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAccount.Location = new System.Drawing.Point(242, 297);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(113, 23);
            this.btnSaveAccount.TabIndex = 6;
            this.btnSaveAccount.Text = "Save  Account";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Website URL:";
            // 
            // StoreAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveAccount);
            this.Controls.Add(this.tbWebLink);
            this.Controls.Add(this.tbAccountPassword);
            this.Controls.Add(this.tbAccountUsername);
            this.Controls.Add(this.tbAccountEmail);
            this.Controls.Add(this.labelStoreAccount);
            this.Name = "StoreAccountControl";
            this.Size = new System.Drawing.Size(380, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStoreAccount;
        private System.Windows.Forms.TextBox tbAccountEmail;
        private System.Windows.Forms.TextBox tbAccountUsername;
        private System.Windows.Forms.TextBox tbAccountPassword;
        private System.Windows.Forms.TextBox tbWebLink;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
