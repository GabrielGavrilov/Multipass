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
        public ParentWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

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
    }
}
