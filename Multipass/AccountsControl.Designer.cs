namespace Multipass
{
    partial class AccountsControl
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
            this.labelFindStoredAccounts = new System.Windows.Forms.Label();
            this.tbWebUrl = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.panelBackgroundWebUrl = new System.Windows.Forms.Panel();
            this.panelBackgroundSearchBtn = new System.Windows.Forms.Panel();
            this.panelBackgroundOutput = new System.Windows.Forms.Panel();
            this.panelBackgroundWebUrl.SuspendLayout();
            this.panelBackgroundSearchBtn.SuspendLayout();
            this.panelBackgroundOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFindStoredAccounts
            // 
            this.labelFindStoredAccounts.AutoSize = true;
            this.labelFindStoredAccounts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindStoredAccounts.Location = new System.Drawing.Point(20, 20);
            this.labelFindStoredAccounts.Name = "labelFindStoredAccounts";
            this.labelFindStoredAccounts.Size = new System.Drawing.Size(187, 22);
            this.labelFindStoredAccounts.TabIndex = 0;
            this.labelFindStoredAccounts.Text = "Find stored accounts";
            // 
            // tbWebUrl
            // 
            this.tbWebUrl.Location = new System.Drawing.Point(2, 2);
            this.tbWebUrl.Name = "tbWebUrl";
            this.tbWebUrl.Size = new System.Drawing.Size(242, 20);
            this.tbWebUrl.TabIndex = 1;
            this.tbWebUrl.Text = "Website URL";
            this.tbWebUrl.AutoSize = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(2, 2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(337, 233);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "Output";
            // 
            // panelBackgroundWebUrl
            // 
            this.panelBackgroundWebUrl.Controls.Add(this.tbWebUrl);
            this.panelBackgroundWebUrl.Location = new System.Drawing.Point(22, 64);
            this.panelBackgroundWebUrl.Name = "panelBackgroundWebUrl";
            this.panelBackgroundWebUrl.Size = new System.Drawing.Size(246, 24);
            this.panelBackgroundWebUrl.TabIndex = 4;
            // 
            // panelBackgroundSearchBtn
            // 
            this.panelBackgroundSearchBtn.Controls.Add(this.btnSearch);
            this.panelBackgroundSearchBtn.Location = new System.Drawing.Point(272, 63);
            this.panelBackgroundSearchBtn.Name = "panelBackgroundSearchBtn";
            this.panelBackgroundSearchBtn.Size = new System.Drawing.Size(87, 25);
            this.panelBackgroundSearchBtn.TabIndex = 5;
            // 
            // panelBackgroundOutput
            // 
            this.panelBackgroundOutput.Controls.Add(this.rtbOutput);
            this.panelBackgroundOutput.Location = new System.Drawing.Point(21, 92);
            this.panelBackgroundOutput.Name = "panelBackgroundOutput";
            this.panelBackgroundOutput.Size = new System.Drawing.Size(340, 236);
            this.panelBackgroundOutput.TabIndex = 6;
            // 
            // AccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBackgroundOutput);
            this.Controls.Add(this.panelBackgroundSearchBtn);
            this.Controls.Add(this.panelBackgroundWebUrl);
            this.Controls.Add(this.labelFindStoredAccounts);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(380, 340);
            this.Load += new System.EventHandler(this.AccountsControl_Load);
            this.panelBackgroundWebUrl.ResumeLayout(false);
            this.panelBackgroundWebUrl.PerformLayout();
            this.panelBackgroundSearchBtn.ResumeLayout(false);
            this.panelBackgroundOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFindStoredAccounts;
        private System.Windows.Forms.TextBox tbWebUrl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Panel panelBackgroundWebUrl;
        private System.Windows.Forms.Panel panelBackgroundSearchBtn;
        private System.Windows.Forms.Panel panelBackgroundOutput;
    }
}
