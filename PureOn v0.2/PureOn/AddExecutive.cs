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
using System.Text.RegularExpressions;

namespace PureOn
{
    public partial class AddExecutive : Form
    {
        public AddExecutive()
        {
            InitializeComponent();
            loadExecutives();
        }
        private void loadExecutives()
        {
            try
            {
                DBConnection db = new DBConnection();
                string cmd = "SELECT exe_name FROM executive;";
                MySqlDataReader rd = db.ExecuteReader(cmd);
                if (!rd.HasRows) { MessageBox.Show("No executives found in Database.."); return; }
                while(rd.Read())
                {
                    delExeCombo.Items.Add(rd.GetString(0));
                }
                delExeCombo.SelectedIndex = 0;
                db.Close();
                return;
            }
            catch(MyDBError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool addExecutivevalidate()
        {
            Regex a = new Regex("^[a-zA-Z]*$");
            Regex n = new Regex("^[0-9]+$");
            Regex ns = new Regex("^[789]/d{9}");
            Regex an = new Regex("^[a-zA-Z0-9_]+");

            if (exeName.Text == "")
            {
                MessageBox.Show("please enter the customer name");
                return false;
            }
            else if (!(a.IsMatch(exeName.Text)))
            {
                MessageBox.Show("please enter the customer name in correct format");
                return false;
            }
            else if (exeID.Text == "")
            {
                MessageBox.Show("please enter the customer ID");
                return false;
            }
            else if (exePhone.Text == "")
            {
                MessageBox.Show("please enter the primary phone number");
                return false;
            }
            else if ((!(n.IsMatch(exePhone.Text))) && (!(ns.IsMatch(exePhone.Text))))
            {
                MessageBox.Show("please enter the primary phone number in correct format");
                return false;
            }
            else if (exeAdd.Text == "")
            {
                MessageBox.Show("please enter the street address");
                return false;
            }
            else if (!(an.IsMatch(exeAdd.Text)))
            {
                MessageBox.Show("please enter the street address in correct format");
                return false;
            }
            return true;
        }
        private Executive loadExecutiveObject()
        {
            Executive e = new Executive();
            e.exe_name = exeName.Text;
            e.exe_emp_id = exeID.Text;
            e.exe_number = exePhone.Text;
            e.exe_address = exeAdd.Text;
            return e;
        }

        private void addExeBtn_Click(object sender, EventArgs e)
        {
            Executive ex = loadExecutiveObject();
            if(addExecutive(ex))
            {
                MessageBox.Show("Added new Executive succesfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in adding new Executive..try again");
            }
        }
        private bool addExecutive(Executive e)
        {
            try
            {
                DBConnection db = new DBConnection();
                string cmd = "INSERT INTO executive VALUES (DEFAULT,'" + e.exe_name + "','" + e.exe_emp_id + "','" + e.exe_number + "','" + e.exe_address + "');";
                if (db.ExecuteQuery(cmd))
                    return true;
                else return false;
            }
            catch (MyDBError ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public class Executive
        {
            public string exe_name { get; set; }
            public string exe_emp_id { get; set; }
            public string exe_number { get; set; }
            public string exe_address { get; set; }
        }
        private bool deleteExe(string name)
        {
            try
            {
                DBConnection db = new DBConnection();
                string cmd = "DELETE FROM executive WHERE exe_name='" + name + "';";
                //MessageBox.Show(cmd);
                if (db.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Succesfully deleted Executive: " + name);
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to delete Executive: " + name);
                    return false;
                }
            }
            catch(MyDBError ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void delExeBtn_Click(object sender, EventArgs e)
        {
            if(deleteExe(delExeCombo.Text))
            {
                this.Close();
            }
        }
    }
}
