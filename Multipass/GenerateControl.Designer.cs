namespace Multipass
{
    partial class GenerateControl
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
            this.labelGeneratePassword = new System.Windows.Forms.Label();
            this.tbPasswordOutput = new System.Windows.Forms.TextBox();
            this.lbPasswordOutput = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.numbChars = new System.Windows.Forms.NumericUpDown();
            this.lbNumbOfChars = new System.Windows.Forms.Label();
            this.panelBackgroundNumbChars = new System.Windows.Forms.Panel();
            this.panelBackgroundPasswordOutput = new System.Windows.Forms.Panel();
            this.panelBackgroundGenBtn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numbChars)).BeginInit();
            this.panelBackgroundNumbChars.SuspendLayout();
            this.panelBackgroundPasswordOutput.SuspendLayout();
            this.panelBackgroundGenBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGeneratePassword
            // 
            this.labelGeneratePassword.AutoSize = true;
            this.labelGeneratePassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneratePassword.Location = new System.Drawing.Point(20, 20);
            this.labelGeneratePassword.Name = "labelGeneratePassword";
            this.labelGeneratePassword.Size = new System.Drawing.Size(245, 22);
            this.labelGeneratePassword.TabIndex = 2;
            this.labelGeneratePassword.Text = "Generate random password";
            // 
            // tbPasswordOutput
            // 
            this.tbPasswordOutput.Location = new System.Drawing.Point(2, 2);
            this.tbPasswordOutput.Name = "tbPasswordOutput";
            this.tbPasswordOutput.Size = new System.Drawing.Size(331, 20);
            this.tbPasswordOutput.TabIndex = 5;
            this.tbPasswordOutput.Text = "output";
            this.tbPasswordOutput.AutoSize = false;
            // 
            // lbPasswordOutput
            // 
            this.lbPasswordOutput.AutoSize = true;
            this.lbPasswordOutput.Location = new System.Drawing.Point(21, 102);
            this.lbPasswordOutput.Name = "lbPasswordOutput";
            this.lbPasswordOutput.Size = new System.Drawing.Size(91, 13);
            this.lbPasswordOutput.TabIndex = 6;
            this.lbPasswordOutput.Text = "Password Output:";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.Location = new System.Drawing.Point(1, 1);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(134, 23);
            this.btnGeneratePassword.TabIndex = 7;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // numbChars
            // 
            this.numbChars.Location = new System.Drawing.Point(2, 2);
            this.numbChars.Name = "numbChars";
            this.numbChars.Size = new System.Drawing.Size(331, 20);
            this.numbChars.TabIndex = 8;
            this.numbChars.AutoSize = false;
            // 
            // lbNumbOfChars
            // 
            this.lbNumbOfChars.AutoSize = true;
            this.lbNumbOfChars.Location = new System.Drawing.Point(23, 59);
            this.lbNumbOfChars.Name = "lbNumbOfChars";
            this.lbNumbOfChars.Size = new System.Drawing.Size(109, 13);
            this.lbNumbOfChars.TabIndex = 9;
            this.lbNumbOfChars.Text = "Number of characters";
            // 
            // panelBackgroundNumbChars
            // 
            this.panelBackgroundNumbChars.Controls.Add(this.numbChars);
            this.panelBackgroundNumbChars.Location = new System.Drawing.Point(24, 75);
            this.panelBackgroundNumbChars.Name = "panelBackgroundNumbChars";
            this.panelBackgroundNumbChars.Size = new System.Drawing.Size(336, 24);
            this.panelBackgroundNumbChars.TabIndex = 14;
            // 
            // panelBackgroundPasswordOutput
            // 
            this.panelBackgroundPasswordOutput.Controls.Add(this.tbPasswordOutput);
            this.panelBackgroundPasswordOutput.Location = new System.Drawing.Point(24, 118);
            this.panelBackgroundPasswordOutput.Name = "panelBackgroundPasswordOutput";
            this.panelBackgroundPasswordOutput.Size = new System.Drawing.Size(336, 24);
            this.panelBackgroundPasswordOutput.TabIndex = 15;
            // 
            // panelBackgroundGenBtn
            // 
            this.panelBackgroundGenBtn.Controls.Add(this.btnGeneratePassword);
            this.panelBackgroundGenBtn.Location = new System.Drawing.Point(224, 148);
            this.panelBackgroundGenBtn.Name = "panelBackgroundGenBtn";
            this.panelBackgroundGenBtn.Size = new System.Drawing.Size(136, 25);
            this.panelBackgroundGenBtn.TabIndex = 16;
            // 
            // GenerateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBackgroundGenBtn);
            this.Controls.Add(this.panelBackgroundPasswordOutput);
            this.Controls.Add(this.panelBackgroundNumbChars);
            this.Controls.Add(this.lbNumbOfChars);
            this.Controls.Add(this.lbPasswordOutput);
            this.Controls.Add(this.labelGeneratePassword);
            this.Name = "GenerateControl";
            this.Size = new System.Drawing.Size(380, 340);
            this.Load += new System.EventHandler(this.GenerateControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numbChars)).EndInit();
            this.panelBackgroundNumbChars.ResumeLayout(false);
            this.panelBackgroundPasswordOutput.ResumeLayout(false);
            this.panelBackgroundPasswordOutput.PerformLayout();
            this.panelBackgroundGenBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGeneratePassword;
        private System.Windows.Forms.TextBox tbPasswordOutput;
        private System.Windows.Forms.Label lbPasswordOutput;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.NumericUpDown numbChars;
        private System.Windows.Forms.Label lbNumbOfChars;
        private System.Windows.Forms.Panel panelBackgroundNumbChars;
        private System.Windows.Forms.Panel panelBackgroundPasswordOutput;
        private System.Windows.Forms.Panel panelBackgroundGenBtn;
    }
}
