using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            DBConnection db = new DBConnection();
             string strSQL = "SELECT * FROM login_info WHERE emp_uname='"+uname.Text+"';";
             try
             {
                 MySqlDataReader resultSet = db.ExecuteReader(strSQL);


                 if (uname.Text == "")
                     MessageBox.Show("Enter a user name.");
                 else if (pass.Text == "")
                     MessageBox.Show("Enter a password");
                 else if (repass.Text != pass.Text)
                     MessageBox.Show("The passwords do not match");
                 else if (!radioButton1.Checked && !radioButton2.Checked)
                     MessageBox.Show("Please select access type.");
                 else if (resultSet.HasRows)
                     MessageBox.Show("User already exisits");
                 else
                 {
                     int admin_priv = 0;
                     if (radioButton1.Checked)
                         admin_priv = 1;
                     string Query = "insert into login_info values (DEFAULT,'" + uname.Text + "','" + pass.Text + "','" + admin_priv + "');";
                     //MessageBox.Show(Query);
                     try
                     {
                         if (db.ExecuteQuery(Query))
                         { 
                             MessageBox.Show("Successfully inserted the User");
                             reload();
                         }
                         else MessageBox.Show("Failed to create new user...");
                     }
                     catch (MyDBError ex)
                     {
                         MessageBox.Show(ex.Message);
                     }
                 }
                 }
             catch (Exception e1)
             {
                 MessageBox.Show("Error :"+e1.Message);
             }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            reload();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 180);
        }
        private void reload()
        {
            try { 
                DBConnection db = new DBConnection();
                string strSQL = "SELECT emp_uname,login_id,emp_privlage FROM login_info where emp_uname <> 'admin';";
                MySqlDataReader resultSet = db.ExecuteReader(strSQL);
                DataTable dtusers = new DataTable();
                dtusers.Columns.Add("emp_uname", typeof(String));
                dtusers.Columns.Add("login_id", typeof(String));
                dtusers.Load(resultSet);
                cbDelete.ValueMember = "login_id";
                cbDelete.DisplayMember = "emp_uname";
                cbDelete.DataSource = dtusers;
                cbupdate.ValueMember = "login_id";
                cbupdate.DisplayMember = "emp_uname";
                cbupdate.DataSource = dtusers;
                db.Close();
            }catch(Exception e4){
                MessageBox.Show(e4.Message);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();
                string deluser = cbDelete.SelectedValue.ToString();
                string delusername = cbDelete.Text;
                string strSQL = "DELETE FROM login_info where login_id=" + deluser + ";";
                db.ExecuteQuery(strSQL);
                MessageBox.Show(delusername+" was successfully deleted.");
                reload();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" )
                    MessageBox.Show("Enter a password");
                else if (textBox1.Text != textBox2.Text)
                    MessageBox.Show("The passwords do not match");
                else
                {
                    DBConnection db = new DBConnection();
                    string deluser = cbupdate.SelectedValue.ToString();
                    string delusername = cbupdate.Text;
                    string strSQL = "UPDATE login_info SET emp_pword='"+textBox2.Text+"' where login_id=" + deluser + ";";
                    db.ExecuteQuery(strSQL);
                    MessageBox.Show(delusername + " was successfully Updated.");
                    reload();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
