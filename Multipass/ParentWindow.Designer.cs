namespace Multipass
{
    partial class ParentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentWindow));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.generateControl1 = new Multipass.GenerateControl();
            this.storeAccountControl1 = new Multipass.StoreAccountControl();
            this.accountsControl1 = new Multipass.AccountsControl();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Silver;
            this.pnMenu.Controls.Add(this.btnGenerate);
            this.pnMenu.Controls.Add(this.btnSaveAccount);
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(178, 343);
            this.pnMenu.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(-1, 183);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(180, 45);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAccount.Location = new System.Drawing.Point(-1, 140);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(180, 45);
            this.btnSaveAccount.TabIndex = 1;
            this.btnSaveAccount.Text = "Save Account";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(-1, 97);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(180, 45);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // generateControl1
            // 
            this.generateControl1.Location = new System.Drawing.Point(179, 0);
            this.generateControl1.Name = "generateControl1";
            this.generateControl1.Size = new System.Drawing.Size(380, 340);
            this.generateControl1.TabIndex = 3;
            // 
            // storeAccountControl1
            // 
            this.storeAccountControl1.Location = new System.Drawing.Point(179, 0);
            this.storeAccountControl1.Name = "storeAccountControl1";
            this.storeAccountControl1.Size = new System.Drawing.Size(380, 340);
            this.storeAccountControl1.TabIndex = 2;
            // 
            // accountsControl1
            // 
            this.accountsControl1.Location = new System.Drawing.Point(180, 0);
            this.accountsControl1.Name = "accountsControl1";
            this.accountsControl1.Size = new System.Drawing.Size(380, 340);
            this.accountsControl1.TabIndex = 1;
            // 
            // ParentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 343);
            this.Controls.Add(this.generateControl1);
            this.Controls.Add(this.storeAccountControl1);
            this.Controls.Add(this.accountsControl1);
            this.Controls.Add(this.pnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentWindow";
            this.Text = "Multipass v1.0.0";
            this.Load += new System.EventHandler(this.ParentWindow_Load);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.Button btnGenerate;
        private AccountsControl accountsControl1;
        private StoreAccountControl storeAccountControl1;
        private GenerateControl generateControl1;
    }
}

