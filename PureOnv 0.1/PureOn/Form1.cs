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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(userText.Text!="" && passText.Text!="")
            { 
            Credentials usr = new Credentials(userText.Text,passText.Text);
            try
            {
                LoginClass log = new LoginClass(usr, "127.0.0.1", "pureontech", "root", "");
                if (log.validate())
                    MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Login Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (MyDBError x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
             {
                 MessageBox.Show("Encountered a Fatal Error:\n"+ex.Message);
             }
  
            }
            else { MessageBox.Show("Enter a valid Username and Password please","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
        }

    }
   
}
