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
    public partial class ParentWindow : Form
    {


        static Color menuColor = Color.FromArgb(43, 43, 43);
        static Color contentColor = Color.FromArgb(53, 53, 53);
        static Color labelColor = Color.FromArgb(130, 130, 130);
        static Color onPanelColor = Color.FromArgb(51, 51, 51);

        static bool isOnAccounts;
        static bool isOnSave;
        static bool isOnGenerate;

        public ParentWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = contentColor;
        }

        /************************************************************
         *                      MENU CONTROLS
         ************************************************************/

        private void ParentWindow_Load(object sender, EventArgs e)
        {
            showAccountsPanel();
        }


        private void btnAccount_Click(object sender, EventArgs e)
        {
            showAccountsPanel();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            showSaveAccountPanel();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            showGeneratePanel(); 
        }

        /************************************************************
        *                   MENU BUTTONS LOGIC 
        *************************************************************/

        private void showAccountsPanel()
        {

            if(isOnSave == true)
            {
                btnSaveAccount.ForeColor = labelColor;
                btnSaveAccount.BackColor = menuColor;
            }

            if(isOnGenerate == true)
            {
                btnGenerate.ForeColor = labelColor;
                btnGenerate.BackColor = menuColor;
            }

            isOnAccounts = true;
            isOnSave = false;
            isOnGenerate = false;

            accountsControl1.Show();
            accountsControl1.BringToFront();
            storeAccountControl1.Hide();
            generateControl1.Hide();

            btnAccount.ForeColor = Color.White;
            btnAccount.BackColor = onPanelColor;

        }

        private void showSaveAccountPanel()
        {

            if (isOnAccounts == true)
            {
                btnAccount.ForeColor = labelColor;
                btnAccount.BackColor = menuColor;
            }

            if (isOnGenerate == true)
            {
                btnGenerate.ForeColor = labelColor;
                btnGenerate.BackColor = menuColor;
            }

            isOnAccounts = false;
            isOnSave = true;
            isOnGenerate = false;

            accountsControl1.Hide();
            storeAccountControl1.Show();
            storeAccountControl1.BringToFront();
            generateControl1.Hide();

            btnSaveAccount.ForeColor = Color.White;
            btnSaveAccount.BackColor = onPanelColor;

        }

        private void showGeneratePanel()
        {

            if (isOnAccounts == true)
            {
                btnAccount.ForeColor = labelColor;
                btnAccount.BackColor = menuColor;
            }

            if (isOnSave == true)
            {
                btnSaveAccount.ForeColor = labelColor;
                btnSaveAccount.BackColor = menuColor;
            }

            isOnAccounts = false;
            isOnSave = false;
            isOnGenerate = true;

            accountsControl1.Hide();
            storeAccountControl1.Hide();
            generateControl1.Show();
            generateControl1.BringToFront();

            btnGenerate.ForeColor = Color.White;
            btnGenerate.BackColor = onPanelColor;

        }

        /************************************************************
        *                       MENU STYLE
        *************************************************************/

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

            pnMenu.BackColor = menuColor;

            btnAccount.BackColor = menuColor;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.ForeColor = labelColor;
            
            btnSaveAccount.BackColor = menuColor;
            btnSaveAccount.FlatStyle = FlatStyle.Flat;
            btnSaveAccount.FlatAppearance.BorderSize = 0;
            btnSaveAccount.ForeColor = labelColor;

            btnGenerate.BackColor = menuColor;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.ForeColor = labelColor;

        }

        private void btnAccount_MouseEnter(object sender, EventArgs e)
        {

            btnAccount.ForeColor = Color.White;
            btnAccount.Cursor = Cursors.Hand;

        }

        private void btnAccount_MouseLeave(object sender, EventArgs e)
        {
            btnAccount.ForeColor = labelColor;

            if(isOnAccounts == true)
            {
                btnAccount.ForeColor = Color.White;
                btnAccount.BackColor = onPanelColor;
            }

        }

        private void btnSaveAccount_MouseEnter(object sender, EventArgs e)
        {

            btnSaveAccount.ForeColor = Color.White;
            btnSaveAccount.Cursor = Cursors.Hand;

        }

        private void btnSaveAccount_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAccount.ForeColor = labelColor;

            if (isOnSave == true)
            {
                btnSaveAccount.ForeColor = Color.White;
                btnSaveAccount.BackColor = onPanelColor;
            }
        }

        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {

            btnGenerate.ForeColor = Color.White;
            btnGenerate.Cursor = Cursors.Hand;

        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.ForeColor = labelColor;

            if (isOnGenerate == true)
            {
                btnGenerate.ForeColor = Color.White;
                btnGenerate.BackColor = onPanelColor;
            }
        }

    }
}
