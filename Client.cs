using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutlipass
{

    public partial class Client : Form
    {

        public bool isOnAccounts;
        public bool isOnSave;
        public bool isOnGenerate;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(53, 53, 53);

        }

        /**************************************************************
        *                      MENU PANEL
        ***************************************************************/

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(43, 43, 43);

            fndBtn.FlatStyle = FlatStyle.Flat;
            fndBtn.FlatAppearance.BorderSize = 0;
            fndBtn.ForeColor = Color.FromArgb(97, 97, 97);

            saveBtn.BackColor = Color.FromArgb(43, 43, 43);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.ForeColor = Color.FromArgb(97, 97, 97);

            genBtn.BackColor = Color.FromArgb(43, 43, 43);
            genBtn.FlatStyle = FlatStyle.Flat;
            genBtn.FlatAppearance.BorderSize = 0;
            genBtn.ForeColor = Color.FromArgb(97, 97, 97);

            onAccountPanel();

        }

        /**************************************************************
        *                     ACCOUNT PANEL
        ***************************************************************/

        private void panelAccounts_Paint(object sender, PaintEventArgs e)
        {

            labelFind.ForeColor = Color.FromArgb(143, 143, 143);

            bgPanelWebUrl.BackColor = Color.FromArgb(31, 31, 31);
            bgPanelBtnFindUser.BackColor = Color.FromArgb(48, 48, 48);
            bgPanelTbOutput.BackColor = Color.FromArgb(31, 31, 31);

            tbWebUrl.BackColor = Color.FromArgb(25, 24, 25);
            tbWebUrl.ForeColor = Color.White;
            tbWebUrl.BorderStyle = BorderStyle.None;

            btnFindUser.BackColor = Color.FromArgb(70, 69, 70);
            btnFindUser.FlatStyle = FlatStyle.Flat;
            btnFindUser.FlatAppearance.BorderSize = 0;
            btnFindUser.ForeColor = Color.White;

            tbOutput.BackColor = Color.FromArgb(25, 24, 25);
            tbOutput.ForeColor = Color.White;
            tbOutput.BorderStyle = BorderStyle.None;

            if (isOnAccounts == true && isOnSave == false && isOnGenerate == false)
            {
                fndBtn.BackColor = Color.FromArgb(51, 51, 51);
            }

        }

        /**************************************************************
        *                   VISIBILITY CONTROL
        ***************************************************************/

        void onAccountPanel()
        {

            if (isOnSave)
            {
                saveBtn.ForeColor = Color.FromArgb(97, 97, 97);
                saveBtn.BackColor = Color.FromArgb(43, 43, 43);
            }

            if (isOnGenerate)
            {
                genBtn.ForeColor = Color.FromArgb(97, 97, 97);
                genBtn.BackColor = Color.FromArgb(43, 43, 43);
            }

            isOnAccounts = true;
            isOnSave = false;
            isOnGenerate = false;

            panelAccounts.Visible = true;
            fndBtn.BackColor = Color.FromArgb(51, 51, 51);
            fndBtn.ForeColor = Color.White;

        }

        void onSavePanel()
        {
            if(isOnAccounts)
            {
                fndBtn.ForeColor = Color.FromArgb(97, 97, 97);
                fndBtn.BackColor = Color.FromArgb(43, 43, 43);
            }

            if(isOnGenerate)
            {
                genBtn.ForeColor = Color.FromArgb(97, 97, 97);
                genBtn.BackColor = Color.FromArgb(43, 43, 43);
            }

            isOnAccounts = false;
            isOnSave = true;
            isOnGenerate = false;

            saveBtn.BackColor = Color.FromArgb(51, 51, 51);
            saveBtn.ForeColor = Color.White;
        }

        void onGeneratePanel()
        {
            if (isOnAccounts)
            {
                fndBtn.ForeColor = Color.FromArgb(97, 97, 97);
                fndBtn.BackColor = Color.FromArgb(43, 43, 43);
            }

            if (isOnSave)
            {
                saveBtn.ForeColor = Color.FromArgb(97, 97, 97);
                saveBtn.BackColor = Color.FromArgb(43, 43, 43);
            }

            isOnAccounts = false;
            isOnSave = false;
            isOnGenerate = true;

            genBtn.BackColor = Color.FromArgb(51, 51, 51);
            genBtn.ForeColor = Color.White;

        }

        /**************************************************************
        *                      MOUSE EVENTS
        ***************************************************************/

        /*
            Find Button
         */

        private void fndBtn_Click(object sender, EventArgs e)
        {
            onAccountPanel();
        }

        private void fndBtn_MouseEnter(object sender, EventArgs e)
        {
            fndBtn.ForeColor = Color.White;
            fndBtn.Cursor = Cursors.Hand;

            if(isOnAccounts)
            {
                fndBtn.BackColor = Color.FromArgb(42, 42, 42);
            }

        }
        
        private void fndBtn_MouseLeave(object sender, EventArgs e)
        {

            fndBtn.ForeColor = Color.FromArgb(97,97,97);

            if (isOnAccounts)
            {
                fndBtn.ForeColor = Color.White;
                fndBtn.BackColor = Color.FromArgb(51, 51, 51);
            }

        }

        /*
            Save Button
         */

        private void saveBtn_Click(object sender, EventArgs e)
        {
            onSavePanel();
        }

        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            saveBtn.ForeColor = Color.White;
            saveBtn.Cursor = Cursors.Hand;

            if(isOnSave)
            {
                saveBtn.BackColor = Color.FromArgb(42, 42, 42);
            }

        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.ForeColor = Color.FromArgb(97, 97, 97);

            if(isOnSave)
            {
                saveBtn.ForeColor = Color.White;
                saveBtn.BackColor = Color.FromArgb(51, 51, 51);
            }

        }

        /*
            Generate Button
         */
        
        private void genBtn_Click(object sender, EventArgs e)
        {
            onGeneratePanel();
        }

        private void genBtn_MouseEnter(object sender, EventArgs e)
        {
            genBtn.ForeColor = Color.White;
            genBtn.Cursor = Cursors.Hand;

            if(isOnGenerate)
            {
                genBtn.BackColor = Color.FromArgb(42, 42, 42);
            }

        }

        private void genBtn_MouseLeave(object sender, EventArgs e)
        {
            genBtn.ForeColor = Color.FromArgb(97, 97, 97);

            if(isOnGenerate)
            {
                genBtn.ForeColor = Color.White;
                genBtn.BackColor = Color.FromArgb(51, 51, 51);
            }

        }

        /**************************************************************
        *                       MISCELLANEOUS
        ***************************************************************/

    }
}
