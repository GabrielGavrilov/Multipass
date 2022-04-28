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
            ((System.ComponentModel.ISupportInitialize)(this.numbChars)).BeginInit();
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
            this.tbPasswordOutput.Location = new System.Drawing.Point(24, 119);
            this.tbPasswordOutput.Name = "tbPasswordOutput";
            this.tbPasswordOutput.Size = new System.Drawing.Size(331, 20);
            this.tbPasswordOutput.TabIndex = 5;
            this.tbPasswordOutput.Text = "output";
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
            this.btnGeneratePassword.Location = new System.Drawing.Point(221, 145);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(134, 23);
            this.btnGeneratePassword.TabIndex = 7;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // numbChars
            // 
            this.numbChars.Location = new System.Drawing.Point(24, 75);
            this.numbChars.Name = "numbChars";
            this.numbChars.Size = new System.Drawing.Size(331, 20);
            this.numbChars.TabIndex = 8;
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
            // GenerateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNumbOfChars);
            this.Controls.Add(this.numbChars);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lbPasswordOutput);
            this.Controls.Add(this.tbPasswordOutput);
            this.Controls.Add(this.labelGeneratePassword);
            this.Name = "GenerateControl";
            this.Size = new System.Drawing.Size(380, 340);
            ((System.ComponentModel.ISupportInitialize)(this.numbChars)).EndInit();
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
    }
}
