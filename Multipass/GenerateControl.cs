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
    }
}
