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
    public partial class StoreAccountControl : UserControl
    {

        static Color tbBackColor = Color.FromArgb(25, 24, 25);
        static Color btnBackColor = Color.FromArgb(70, 69, 70);
        static Color labelColor = Color.FromArgb(130, 130, 130);
        static Color borderColor = Color.FromArgb(31, 31, 31);

        public StoreAccountControl()
        {
            InitializeComponent();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string accountEmail, accountUsername, accountPassword, savedWebUrl;

            accountEmail = tbAccountEmail.Text;
            accountUsername = tbAccountUsername.Text;
            accountPassword = tbAccountPassword.Text;
            savedWebUrl = tbWebLink.Text;

            if (tbAccountEmail.Text == "" || tbAccountEmail.Text == "Account email")
                accountEmail = "NULL";

            if (tbAccountUsername.Text == "" || tbAccountUsername.Text == "Account username")
                accountUsername = "NULL";

            if (tbAccountPassword.Text == "" || tbAccountPassword.Text == "Account password")
                accountPassword = "NULL";

            try
            {
                Database.saveNewAccount(accountEmail, accountUsername, accountPassword, savedWebUrl);
                tbAccountEmail.Text = "";
                tbAccountUsername.Text = "";
                tbAccountPassword.Text = "";
                tbWebLink.Text = "";
            } catch(Exception err)
            {
                Console.WriteLine(err);
            }

        }

        private void StoreAccountControl_Load(object sender, EventArgs e)
        {
            labelStoreAccount.ForeColor = Color.White;

            lbEmail.ForeColor = Color.White;
            lbUsername.ForeColor = Color.White;
            lbPassword.ForeColor = Color.White;
            lbEmail.ForeColor = Color.White;
            lbWebsiteUrl.ForeColor = Color.White;

            tbAccountEmail.BackColor = tbBackColor;
            tbAccountEmail.ForeColor = Color.White;
            tbAccountEmail.BorderStyle = BorderStyle.None;
            tbAccountEmail.TabStop = false;

            tbAccountUsername.BackColor = tbBackColor;
            tbAccountUsername.ForeColor = Color.White;
            tbAccountUsername.BorderStyle = BorderStyle.None;

            tbAccountPassword.BackColor = tbBackColor;
            tbAccountPassword.ForeColor = Color.White;
            tbAccountPassword.BorderStyle = BorderStyle.None;

            tbWebLink.BackColor = tbBackColor;
            tbWebLink.ForeColor = Color.White;
            tbWebLink.BorderStyle = BorderStyle.None;

            btnSaveAccount.ForeColor = Color.White;
            btnSaveAccount.BackColor = btnBackColor;
            btnSaveAccount.TabStop = false;
            btnSaveAccount.FlatStyle = FlatStyle.Flat;
            btnSaveAccount.FlatAppearance.BorderSize = 0;

            panelBackgroundEmail.BackColor = borderColor;
            panelBackgroundUsername.BackColor = borderColor;
            panelBackgroundPassword.BackColor = borderColor;
            panelBackgroundWebUrl.BackColor = borderColor;
            panelBackgroundSaveBtn.BackColor = borderColor;

        }
    }
}
