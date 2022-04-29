using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multipass
{
    public partial class GenerateControl : UserControl
    {

        static Color tbBackColor = Color.FromArgb(25, 24, 25);
        static Color btnBackColor = Color.FromArgb(70, 69, 70);
        static Color labelColor = Color.FromArgb(130, 130, 130);
        static Color borderColor = Color.FromArgb(31, 31, 31);
        public GenerateControl()
        {
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {

            string passwordChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()";

            int numbOfChars = Convert.ToInt32(numbChars.Text);
            char[] password = new char[numbOfChars];
            Random rand = new Random();

            for(int i = 0; i < password.Length; i++)
            {
                password[i] = passwordChars[rand.Next(passwordChars.Length)];
            }

            string stringPassword = new String(password);
            tbPasswordOutput.Text = stringPassword;

        }

        private void GenerateControl_Load(object sender, EventArgs e)
        {
            labelGeneratePassword.ForeColor = Color.White;

            lbNumbOfChars.ForeColor = Color.White;
            numbChars.BackColor = tbBackColor;
            numbChars.ForeColor = Color.White;
            numbChars.BorderStyle = BorderStyle.None;

            panelBackgroundNumbChars.BackColor = borderColor;

            lbPasswordOutput.ForeColor = Color.White;
            tbPasswordOutput.BackColor = tbBackColor;
            tbPasswordOutput.ForeColor = Color.White;
            tbPasswordOutput.BorderStyle = BorderStyle.None;

            panelBackgroundPasswordOutput.BackColor = borderColor;

            btnGeneratePassword.ForeColor = Color.White;
            btnGeneratePassword.BackColor = btnBackColor;
            btnGeneratePassword.TabStop = false;
            btnGeneratePassword.FlatStyle = FlatStyle.Flat;
            btnGeneratePassword.FlatAppearance.BorderSize = 0;

            panelBackgroundGenBtn.BackColor = borderColor;

        }
    }
}
