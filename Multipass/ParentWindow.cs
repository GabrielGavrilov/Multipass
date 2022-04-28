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
            accountsControl1.Show();
            accountsControl1.BringToFront();
            storeAccountControl1.Hide();
            generateControl1.Hide();
        }


        private void btnAccount_Click(object sender, EventArgs e)
        {
            accountsControl1.Show();
            accountsControl1.BringToFront();
            storeAccountControl1.Hide();
            generateControl1.Hide();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            accountsControl1.Hide();
            storeAccountControl1.Show();
            storeAccountControl1.BringToFront();
            generateControl1.Hide();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            accountsControl1.Hide();
            storeAccountControl1.Hide();
            generateControl1.Show();
            generateControl1.BringToFront();
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
        }

        private void btnSaveAccount_MouseEnter(object sender, EventArgs e)
        {

            btnSaveAccount.ForeColor = Color.White;
            btnSaveAccount.Cursor = Cursors.Hand;

        }

        private void btnSaveAccount_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAccount.ForeColor = labelColor;
        }

        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {

            btnGenerate.ForeColor = Color.White;
            btnGenerate.Cursor = Cursors.Hand;

        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.ForeColor = labelColor;
        }

    }
}
