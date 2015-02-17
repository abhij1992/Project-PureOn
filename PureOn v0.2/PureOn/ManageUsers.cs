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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection("127.0.0.1", "pureontech", "root", "");
            string Query = "insert into login_info values (DEFAULT,'" + uname.Text + "','" + pass.Text + "','1');";
            //MessageBox.Show(Query);
            try
            {
                if (db.ExecuteQuery(Query))
                { MessageBox.Show("Successfully inserted the User"); }
                else MessageBox.Show("Failed to create new user...");
            }
            catch(MyDBError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
