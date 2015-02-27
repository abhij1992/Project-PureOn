using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureOn
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers muf = new ManageUsers();
            muf.ShowDialog();
        }

        private void mngExe_Click(object sender, EventArgs e)
        {
            AddExecutive a = new AddExecutive();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Manage_Users amu = new Admin_Manage_Users();
            amu.ShowDialog();
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            Revenue r = new Revenue();
            r.ShowDialog();
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Log out and Exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else e.Cancel = true;
        }
    }
}
