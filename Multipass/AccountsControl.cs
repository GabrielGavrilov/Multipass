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
    public partial class AccountsControl : UserControl
    {
        public AccountsControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string webUrl, outputText;

            webUrl = tbWebUrl.Text;
            outputText = Database.findSavedAccount(webUrl);

            rtbOutput.Text = outputText;

        }
    }
}
