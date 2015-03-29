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
    
    public partial class Update_customer : Form
    {
        bool executiveDisableFlag;
        string hist_id_to_delete;
        String CustomerAutoGenID;
        public bool newRecord { get; set; }
        public Update_customer()
        {
            InitializeComponent();
            this.newRecord = false;
        }
        public Update_customer(bool forExecutiveFlag)
        {
            if(forExecutiveFlag)
            {
                InitializeComponent();
                this.newRecord = false;
                this.FilterDetails.Enabled = false;
                this.UserAt.Enabled = false;
                this.warrantyDate.Enabled = false;
                this.ContractDetails.Enabled = false;
                this.executiveDisableFlag = true;
            }
        }
        private bool AddCustomervalid()
        {
            Regex a = new Regex("^[a-zA-Z\\s]*$");
            Regex n = new Regex("^[0-9]+$");
            Regex ns = new Regex("^d{9}");
            Regex an = new Regex("^[a-zA-Z0-9_#]+");
            Regex p = new Regex("/d{6}");
           
            if (custID.Text == "")
            {
                MessageBox.Show("please enter the customer ID");
                return false;
            }
            else if (custName.Text == "")
            {
                MessageBox.Show("please enter the customer name");
                return false;
            }
            else if (!(a.IsMatch(custName.Text)))
            {
                MessageBox.Show("please enter the customer name in correct format");
                return false;
            }
            else if (phonePrime.Text == "")
            {
                MessageBox.Show("please enter the primary phone number");
                return false;
            }
            else if ((!(n.IsMatch(phonePrime.Text))) && (!(ns.IsMatch(phonePrime.Text))))
            {
                MessageBox.Show("please enter the primary phone number in correct format");
                return false;
            }
            else if ((!(n.IsMatch(phoneAlt.Text))) && (!(ns.IsMatch(phoneAlt.Text))))
            {
                MessageBox.Show("please enter the alternate phone number in correct format");
                return false;
            }
            else if (doorNo.Text == "")
            {
                MessageBox.Show("please enter the door no");
                return false;
            }
            else if (!(an.IsMatch(doorNo.Text)))
            {
                MessageBox.Show("please enter the door no in correct format");
                return false;
            }
            else if (street.Text == "")
            {
                MessageBox.Show("please enter the street address");
                return false;
            }
            else if (!(an.IsMatch(street.Text)))
            {
                MessageBox.Show("please enter the street address in correct format");
                return false;
            }
            else if (pinCode.Text == "")
            {
                MessageBox.Show("please enter the pincode");
                return false;
            }
            else if (!(n.IsMatch(pinCode.Text)))
            {
                MessageBox.Show("please enter the pincode in correct format");
                return false;
            }
            else if (filterModel.Text == "")
            {
                MessageBox.Show("please enter the filter model");
                return false;
            }
            else if (unitSlNo.Text == "")
            {
                MessageBox.Show("please enter the unit serial nnumber");
                return false;
            }
            else if (!office.Checked && !residence.Checked && !both.Checked)
            {
                MessageBox.Show("please select any option from used at");
                return false;
            }
            else if (!amc.Checked && !acmc.Checked)
            {
                MessageBox.Show("please select any option from contracts details");
                return false;
            }
            return true;
        }
        private Customer loadCustomerObject()
        {
            Customer cr = new Customer();
            cr.customer_id = custID.Text;
            cr.cust_name = custName.Text;
            cr.phone_primary = phonePrime.Text;
            cr.phone_alt = phoneAlt.Text;
            cr.door_no = doorNo.Text;
            cr.street_name = street.Text;
            cr.pin_code = pinCode.Text;
            cr.filter_model = filterModel.Text;
            DateTime d = dateOfInstallation.Value.Date;
            cr.date_of_installation = d.Date.ToString("yyyy-MM-dd");
            cr.unit_slno = unitSlNo.Text;

            if (office.Checked) cr.used_at = 1;
            else if (residence.Checked) cr.used_at = 2;
            else if (both.Checked) cr.used_at = 3;

            d = warrantyDate.Value.Date;
            cr.warranty_date = d.Date.ToString("yyyy-MM-dd");

            if (amc.Checked) cr.cont_details = 1;
            else if (acmc.Checked) cr.cont_details = 2;
            else if (none.Checked) cr.cont_details = 0;

            var parts = new List<string>();
            foreach (Object c in acmcCheckList.CheckedItems)
            {
                //parts.Add(acmcCheckList.Items.IndexOf(c).ToString());//For index value
                parts.Add(c.ToString());
            }
            if (parts.Count > 0) cr.acmc_covered_parts = string.Join(",", parts.ToArray());
            else cr.acmc_covered_parts = "NULL";
            //MessageBox.Show(cr.acmc_covered_parts);

            return cr;
        }
        public void load_history_table()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DBConnection db = new DBConnection();
            string strSQL = "SELECT `vist_date`,`work_details`,`parts_replaced`,`icr_bill_no`,`iccr_no`,`iccr_date`,`amount`, `e`.`exe_name`,`hist_id`,`acmc_part_used` FROM `history_card`,`executive` `e` WHERE e.exe_id = exec_attend and `history_card`.`customer_id` = '" + custID.Text + "';";
            MySqlDataReader resultSet = db.ExecuteReader(strSQL);
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Visit Date";
            dataGridView1.Columns[1].Name = "Work Detail";
            dataGridView1.Columns[2].Name = "Parts Replaced";
            dataGridView1.Columns[3].Name = "ICR Bill no.";
            dataGridView1.Columns[4].Name = "ICCR no.";
            dataGridView1.Columns[5].Name = "ICCR Date";
            dataGridView1.Columns[6].Name = "Amount";
            dataGridView1.Columns[7].Name = "Executive";
            dataGridView1.Columns[0].HeaderText = "Visit Date";
            dataGridView1.Columns[1].HeaderText = "Work Detail";
            dataGridView1.Columns[2].HeaderText = "Parts Replaced";
            dataGridView1.Columns[3].HeaderText = "ICR Bill no.";
            dataGridView1.Columns[4].HeaderText = "ICCR no.";
            dataGridView1.Columns[5].HeaderText = "ICCR Date";
            dataGridView1.Columns[6].HeaderText = "Amount";
            dataGridView1.Columns[7].HeaderText = "Executive";
            dataGridView1.Columns[8].HeaderText = "History ID";
            dataGridView1.Columns[9].HeaderText = "Part already covered";
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            while (resultSet.Read())
            {
                String str = "Installation";
                if (resultSet.GetString(1).ToString() == "2")
                {
                    str = "Service";
                }

                string input = resultSet.GetString(2).ToString();
                string output = input.Replace("$-$", "\n ");
                string[] words = resultSet.GetString(0).Split(' ');
                string[] words2 = resultSet.GetString(5).Split(' ');
                string rps = "Rs. " + resultSet.GetString(6).ToString();
                dataGridView1.Rows.Add(words[0], str, output, resultSet.GetString(3).ToString(), resultSet.GetString(4).ToString(), words2[0], rps, resultSet.GetString(7).ToString(), resultSet.GetString(8).ToString(), resultSet.GetString(9).ToString());
               
             
            }

        }

        private void Update_customer_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM customer_info WHERE customer_id='" + custID.Text + "';";
            try
            {
                
                DBConnection db = new DBConnection();
                MySqlDataReader resultSet = db.ExecuteReader(strSQL);
                //if (!resultSet.HasRows) throw new MyDBError("User does not exist");
                resultSet.Read();
                CustomerAutoGenID = resultSet.GetString(0); //gets the Customers Autogenerated ID to be used in Add history card form
                custID.Text = resultSet.GetString(1);
                custName.Text = resultSet.GetString(2);
                phonePrime.Text = resultSet.GetString(3);
                phoneAlt.Text = resultSet.GetString(4);
                doorNo.Text = resultSet.GetString(5);
                street.Text = resultSet.GetString(6);
                pinCode.Text = resultSet.GetString(7);
                filterModel.Text = resultSet.GetString(8);
                dateOfInstallation.Value = Convert.ToDateTime(resultSet.GetString(9));
                //textBox1.Text = resultSet.GetString(9);
                unitSlNo.Text = resultSet.GetString(10);
                int usedatplace = resultSet.GetInt32(11);
                if (usedatplace == 1) office.Select();
                else if (usedatplace == 2 ) residence.Select();
                else if (usedatplace == 3) both.Select();
                warrantyDate.Value = Convert.ToDateTime(resultSet.GetString(12));
                int cont_details = resultSet.GetInt32(13);
                if (cont_details == 1) amc.Select();
                else if (cont_details == 2) acmc.Select();
                else if (cont_details == 0) none.Select();

                string[] acmcParts = resultSet.GetString(14).Split(',');
                foreach(string part in acmcParts)
                {
                    if(acmcCheckList.Items.Contains(part))
                    {
                        acmcCheckList.SetItemCheckState(acmcCheckList.Items.IndexOf(part),CheckState.Checked);
                    }
                }
                db.Close();

                //loading table
                load_history_table();

            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddHistoryCard ahc = new AddHistoryCard(custID.Text);
            //MessageBox.Show(ahc.cID);
            ahc.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_customer_Activated(object sender, EventArgs e)
        {
            load_history_table();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (executiveDisableFlag) return;
            Update_History frmHistory = new Update_History(custID.Text, dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            frmHistory.custID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            frmHistory.ShowDialog();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (executiveDisableFlag) {MessageBox.Show("You cannot delete History cards","Not Permitted",MessageBoxButtons.OK); return;}
            try { 
                if (MessageBox.Show("Are you sure you want to delete History id "+hist_id_to_delete, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    DBConnection db = new DBConnection();
                    string qdelete = "DELETE FROM `pureontech`.`history_card` WHERE `history_card`.`hist_id` = "+hist_id_to_delete+"; ";
                    if (db.ExecuteQuery(qdelete)) {
                        MessageBox.Show(" History ID "+hist_id_to_delete+" has been deleted.");
                    }
                    else
                        MessageBox.Show("Error in deleting history from the Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //MessageBox.Show("to delete" + hist_id_to_delete);
            }
            catch(Exception e4)
            {
                MessageBox.Show(e4.Message);
            }

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                    if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    {

                        contextMenuStrip1.Show(dataGridView1, e.Location);
                        dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;
                        //MessageBox.Show(dataGridView1.Rows[hitTestInfo.RowIndex].Cells[8].Value.ToString());
                        hist_id_to_delete = dataGridView1.Rows[hitTestInfo.RowIndex].Cells[8].Value.ToString();
                    }


                }
            }catch(Exception e11){
                MessageBox.Show(e11.Message+" "+e11.Source);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!AddCustomervalid())
            {
                return;
            }
            Customer cr = loadCustomerObject();
            try
            {
                DBConnection db = new DBConnection();
                if (MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    string qdelete = "DELETE FROM customer_info WHERE customer_id='" + custID.Text + "'; ";
                    if (db.ExecuteQuery(qdelete))
                    {
                        if (db.insertCustomer(cr))
                        {
                            MessageBox.Show("Updated customer succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.newRecord = true;
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error in adding new customer to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MyDBError ex)
            {
                MessageBox.Show("Error encountered:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acmc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.acmc.Checked == true) this.acmcGroupBox.Enabled = true;
            else
            {
                foreach (int i in acmcCheckList.CheckedIndices)
                {
                    acmcCheckList.SetItemCheckState(i, CheckState.Unchecked);
                }
                this.acmcGroupBox.Enabled = false;
            }
        }

    }
}
