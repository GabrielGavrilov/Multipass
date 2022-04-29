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

        static Color tbBackColor = Color.FromArgb(25, 24, 25);
        static Color btnBackColor = Color.FromArgb(70, 69, 70);
        static Color labelColor = Color.FromArgb(130,130,130);
        static Color borderColor = Color.FromArgb(31, 31, 31);

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

        /************************************************************
        *                  ACCOUNTS CONTROL STYLE
        *************************************************************/

        private void AccountsControl_Load(object sender, EventArgs e)
        {
            labelFindStoredAccounts.ForeColor = Color.White;

            tbWebUrl.BackColor = tbBackColor;
            tbWebUrl.ForeColor = Color.White;
            tbWebUrl.TabStop = false;
            tbWebUrl.BorderStyle = BorderStyle.None;

            btnSearch.BackColor = btnBackColor;
            btnSearch.ForeColor = Color.White;
            btnSearch.TabStop = false;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;

            rtbOutput.BackColor = tbBackColor;
            rtbOutput.ForeColor = Color.White;
            rtbOutput.TabStop = false;
            rtbOutput.BorderStyle = BorderStyle.None;

            panelBackgroundWebUrl.BackColor = borderColor;
            panelBackgroundSearchBtn.BackColor = borderColor;
            panelBackgroundOutput.BackColor = borderColor;

        }

    }
}
