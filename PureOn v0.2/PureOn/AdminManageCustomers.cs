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
    public partial class Admin_Manage_Users : Form
    {
        DataTable dbdataset;
        string customer_id_to_delete;
        private void loadTable()
        {
            
            DBConnection db = new DBConnection();
            MySqlConnection conDataBase = new MySqlConnection(db.getconnstring());
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT `customer_id`,`cust_name`,`phone_primary`,`door_no`,`street_name`,`pin_code`,`acmc_covered_parts` FROM `customer_info`;", conDataBase);
            //String cmdDataBase = "SELECT `customer_id`,`cust_name`,`phone_primary`,`door_no`,`street_name`,`pin_code` FROM `customer_info`;";

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView.DataSource = bSource;

                //set the 7 column parts_covered to display full content
                dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                sda.Update(dbdataset);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Admin_Manage_Users()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
            if (a.newRecord) loadTable();//MessageBox.Show("New record added");
            else MessageBox.Show("No record was added");
        }

        private void Admin_Manage_Users_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        private void textChanged()
        {

            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("customer_id LIKE '%{0}%' AND cust_name LIKE '%{1}%' AND CONVERT({2}, System.String) like '%{3}%' AND door_no LIKE '%{4}%' AND street_name LIKE '%{5}%' AND CONVERT({6}, System.String) like '%{7}%' ", custID.Text, custName.Text, "phone_primary", phonePrime.Text, doorNo.Text, street.Text, "pin_code", pinCode.Text);
            //dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'","phone_primary",custID.Text);
            dataGridView.DataSource = dv;
        }
       
        private void street_TextChanged_1(object sender, EventArgs e)
        {
            textChanged();
        }

        private void custID_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void custName_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void phonePrime_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void doorNo_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void pinCode_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
               /* History frmHistory = new History();
                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmHistory.custID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmHistory.ShowDialog();
              
            */
                Update_customer frmUCustomer = new Update_customer();
                frmUCustomer.custID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmUCustomer.ShowDialog();

                 }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete User id " + customer_id_to_delete, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    DBConnection db = new DBConnection();
                    string qdelete = "DELETE a.*, b.* FROM customer_info a LEFT JOIN history_card b ON b.`customer_id` = a.`customer_id` WHERE a.`customer_id` = '"+customer_id_to_delete+"'; ";
                    if (db.ExecuteQuery(qdelete))
                    {
                        MessageBox.Show(" Customer with ID " + customer_id_to_delete + " has been deleted.");
                        loadTable();
                    }
                    else
                        MessageBox.Show("Error in deleteing customer from the Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //MessageBox.Show("to delete" + hist_id_to_delete);
            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message);
            }
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;

            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    hitTestInfo = dataGridView.HitTest(e.X, e.Y);
                    if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    {

                        contextMenuStrip1.Show(dataGridView, e.Location);
                        dataGridView.Rows[hitTestInfo.RowIndex].Selected = true;
                        //MessageBox.Show(dataGridView1.Rows[hitTestInfo.RowIndex].Cells[8].Value.ToString());
                        customer_id_to_delete = dataGridView.Rows[hitTestInfo.RowIndex].Cells[0].Value.ToString();
                    }


                }
            }catch(Exception e12)
            {
                MessageBox.Show(e12.Message + " " + e12.Source);
            }
        }
    }
     
}
