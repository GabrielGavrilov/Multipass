namespace Mutlipass
{
    partial class Client
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.genBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.fndBtn = new System.Windows.Forms.Button();
            this.labelFind = new System.Windows.Forms.Label();
            this.tbWebUrl = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.bgPanelTbOutput = new System.Windows.Forms.Panel();
            this.bgPanelBtnFindUser = new System.Windows.Forms.Panel();
            this.bgPanelWebUrl = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelAccounts.SuspendLayout();
            this.bgPanelTbOutput.SuspendLayout();
            this.bgPanelBtnFindUser.SuspendLayout();
            this.bgPanelWebUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.genBtn);
            this.panelMenu.Controls.Add(this.saveBtn);
            this.panelMenu.Controls.Add(this.fndBtn);
            this.panelMenu.Location = new System.Drawing.Point(-4, -5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 370);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // genBtn
            // 
            this.genBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genBtn.Location = new System.Drawing.Point(3, 182);
            this.genBtn.Name = "genBtn";
            this.genBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genBtn.Size = new System.Drawing.Size(169, 40);
            this.genBtn.TabIndex = 2;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            this.genBtn.MouseEnter += new System.EventHandler(this.genBtn_MouseEnter);
            this.genBtn.MouseLeave += new System.EventHandler(this.genBtn_MouseLeave);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveBtn.Location = new System.Drawing.Point(3, 143);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveBtn.Size = new System.Drawing.Size(169, 40);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // fndBtn
            // 
            this.fndBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fndBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fndBtn.Location = new System.Drawing.Point(3, 104);
            this.fndBtn.Name = "fndBtn";
            this.fndBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fndBtn.Size = new System.Drawing.Size(169, 40);
            this.fndBtn.TabIndex = 0;
            this.fndBtn.Text = "Accounts";
            this.fndBtn.UseVisualStyleBackColor = true;
            this.fndBtn.Click += new System.EventHandler(this.fndBtn_Click);
            this.fndBtn.MouseEnter += new System.EventHandler(this.fndBtn_MouseEnter);
            this.fndBtn.MouseLeave += new System.EventHandler(this.fndBtn_MouseLeave);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.Location = new System.Drawing.Point(21, 25);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(130, 24);
            this.labelFind.TabIndex = 0;
            this.labelFind.Text = "Find Account";
            // 
            // tbWebUrl
            // 
            this.tbWebUrl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWebUrl.Location = new System.Drawing.Point(3, 2);
            this.tbWebUrl.Multiline = true;
            this.tbWebUrl.Name = "tbWebUrl";
            this.tbWebUrl.Size = new System.Drawing.Size(202, 24);
            this.tbWebUrl.TabIndex = 1;
            this.tbWebUrl.Text = "Website URL";
            this.tbWebUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(2, 2);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(299, 235);
            this.tbOutput.TabIndex = 2;
            this.tbOutput.Text = "Output";
            // 
            // btnFindUser
            // 
            this.btnFindUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.Location = new System.Drawing.Point(2, 2);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(89, 25);
            this.btnFindUser.TabIndex = 3;
            this.btnFindUser.Text = "Search";
            this.btnFindUser.UseVisualStyleBackColor = true;
            // 
            // panelAccounts
            // 
            this.panelAccounts.Controls.Add(this.bgPanelTbOutput);
            this.panelAccounts.Controls.Add(this.bgPanelBtnFindUser);
            this.panelAccounts.Controls.Add(this.bgPanelWebUrl);
            this.panelAccounts.Controls.Add(this.labelFind);
            this.panelAccounts.Location = new System.Drawing.Point(167, -5);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(363, 367);
            this.panelAccounts.TabIndex = 1;
            this.panelAccounts.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccounts_Paint);
            // 
            // bgPanelTbOutput
            // 
            this.bgPanelTbOutput.Controls.Add(this.tbOutput);
            this.bgPanelTbOutput.Location = new System.Drawing.Point(25, 107);
            this.bgPanelTbOutput.Name = "bgPanelTbOutput";
            this.bgPanelTbOutput.Size = new System.Drawing.Size(303, 239);
            this.bgPanelTbOutput.TabIndex = 6;
            // 
            // bgPanelBtnFindUser
            // 
            this.bgPanelBtnFindUser.Controls.Add(this.btnFindUser);
            this.bgPanelBtnFindUser.Location = new System.Drawing.Point(236, 73);
            this.bgPanelBtnFindUser.Name = "bgPanelBtnFindUser";
            this.bgPanelBtnFindUser.Size = new System.Drawing.Size(93, 29);
            this.bgPanelBtnFindUser.TabIndex = 5;
            // 
            // bgPanelWebUrl
            // 
            this.bgPanelWebUrl.Controls.Add(this.tbWebUrl);
            this.bgPanelWebUrl.Location = new System.Drawing.Point(25, 74);
            this.bgPanelWebUrl.Name = "bgPanelWebUrl";
            this.bgPanelWebUrl.Size = new System.Drawing.Size(207, 28);
            this.bgPanelWebUrl.TabIndex = 4;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Controls.Add(this.panelAccounts);
            this.Controls.Add(this.panelMenu);
            this.Name = "Client";
            this.Text = "Multipass v1.0.0";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelAccounts.ResumeLayout(false);
            this.panelAccounts.PerformLayout();
            this.bgPanelTbOutput.ResumeLayout(false);
            this.bgPanelBtnFindUser.ResumeLayout(false);
            this.bgPanelWebUrl.ResumeLayout(false);
            this.bgPanelWebUrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button fndBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox tbWebUrl;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Panel panelAccounts;
        private System.Windows.Forms.Panel bgPanelWebUrl;
        private System.Windows.Forms.Panel bgPanelBtnFindUser;
        private System.Windows.Forms.Panel bgPanelTbOutput;
    }
}

