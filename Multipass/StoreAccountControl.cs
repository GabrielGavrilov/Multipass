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

    }
}
