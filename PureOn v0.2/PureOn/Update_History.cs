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
    public partial class Update_History : Form
    {
        string id_to_update;
        string c_id;
        public string cID { get; set; }
        public Update_History(string cusids,string up_hist_id)
        {
            InitializeComponent();
            this.custID.Text = cusids;
            c_id = cusids;
            id_to_update = up_hist_id;
        }
        private bool HistoryValid()
        {
            Regex a = new Regex("^[a-zA-Z\\s]*$");
            Regex n = new Regex("^[0-9]+$");
            Regex ns = new Regex("^d{9}");
            Regex an = new Regex("^[a-zA-Z0-9_]+");

            if (custID.Text == "")
            {
                MessageBox.Show("please enter the customer ID");
                return false;
            }
            else if (!serviceRdBtn.Checked && !installRdBtn.Checked)
            {
                MessageBox.Show("please select any option from work details");
                return false;
            }
            else if (iccr.Text == "")
            {
                MessageBox.Show("please enter the iccr number");
                return false;
            }
            else if ((!(n.IsMatch(iccr.Text))) && (!(ns.IsMatch(iccr.Text))))
            {
                MessageBox.Show("please enter the iccr number in correct format");
                return false;
            }
            else if (icr.Text == "")
            {
                MessageBox.Show("please enter the icr number");
                return false;
            }
            else if ((!(n.IsMatch(icr.Text))) && (!(ns.IsMatch(icr.Text))))
            {
                MessageBox.Show("please enter the iccr number in correct format");
                return false;
            }
            else if (amount.Text == "")
            {
                MessageBox.Show("please enter the amount");
                return false;
            }
            else if ((!(n.IsMatch(amount.Text))) && (!(ns.IsMatch(amount.Text))))
            {
                MessageBox.Show("please enter the amount correct format");
                return false;
            }
            else if (serviceEng.Text == "")
            {
                MessageBox.Show("please select the service engineer");
                return false;
            }
            return true;
        }
        private void getAcmcParts()
        {
            acmcCheckList.Items.Clear();
            String covered_parts = "NULL";
            String parts_removed = "NULL";
            String[] parts_removed_patt;
            String[] covered_parts_left;
            DBConnection db = new DBConnection();
            string cmd = "SELECT `acmc_covered_parts` FROM `customer_info` WHERE `customer_id`='" + custID.Text + "' ;";
            MySqlDataReader r = db.ExecuteReader(cmd);
            while (r.Read())
            {
                if (!(r.GetString(0).Equals("NULL")))
                    covered_parts += r.GetString(0);
                //acmcCheckList.Items.Add(r.GetString(0));
            }
            textBox2.Text = covered_parts;
            if (covered_parts.Equals("NULL"))
                acmcCheckList.Enabled = false;
            else
            {
                covered_parts = covered_parts.Replace("NULL", "");
                cmd = "SELECT `acmc_part_used` FROM `history_card` WHERE `customer_id`='" + custID.Text + "' and not hist_id = " + id_to_update + ";";
                r = db.ExecuteReader(cmd);
                while (r.Read())
                {
                    if (!(r.GetString(0).Equals("NULL")))
                    {
                        string temp = "," + r.GetString(0);
                        parts_removed += temp;

                        //acmcCheckList.Items.Add(r.GetString(0));
                    }
                }
                if (!parts_removed.Equals("NULL"))
                {
                    parts_removed = parts_removed.Replace("NULL", "");
                    parts_removed_patt = parts_removed.Split(',');
                    foreach (string part in parts_removed_patt)
                    {
                        if (part.Length > 2)
                            covered_parts = covered_parts.Replace(part, "");
                    }
                    //covered_parts = covered_parts.Replace(",,", "");
                }
                
                textBox3.Text = parts_removed;
                covered_parts_left = covered_parts.Split(',');
                foreach (string part in covered_parts_left)
                {
                    if (part.Length > 2)
                        acmcCheckList.Items.Add(part);
                }
            }

            cmd = "SELECT `acmc_part_used` FROM `history_card` WHERE hist_id = " + id_to_update + ";";
            r = db.ExecuteReader(cmd);
            r.Read();
            string[] acmcParts = r.GetString(0).Split(',');
            foreach (string part in acmcParts)
            {
                if (acmcCheckList.Items.Contains(part))
                {
                    acmcCheckList.SetItemCheckState(acmcCheckList.Items.IndexOf(part), CheckState.Checked);
                }
            }

            db.Close();
        }
        private HistoryCard loadHistoryObject()
        {
            HistoryCard hc = new HistoryCard();

            hc.customer_id = this.cID;

            DateTime d = visitDt.Value.Date;
            hc.visitDate = d.Date.ToString("yyyy-MM-dd");

            if (installRdBtn.Checked) hc.work_details = 1;
            else if (serviceRdBtn.Checked) hc.work_details = 2;

            hc.part_replaced = gatherPartsReplaced();

            hc.icr_bill_no = icr.Text;
            hc.iccr_no = iccr.Text;
            d = icrdate.Value.Date;
            hc.iccr_date = d.Date.ToString("yyyy-MM-dd");
            hc.amount = amount.Text;
            hc.exec_attend = getExeId(serviceEng.Text);
            
            return hc;
        }

        private void Update_History_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            string strSQL = "SELECT * FROM customer_info WHERE customer_id='" + c_id + "';";
            try
            {

                
                MySqlDataReader resultSet = db.ExecuteReader(strSQL);
                //if (!resultSet.HasRows) throw new MyDBError("User does not exist");
                resultSet.Read();
                custID.Text = resultSet.GetString(1);
                custName.Text = resultSet.GetString(2);
                phonePrime.Text = resultSet.GetString(3);
                filterModel.Text = resultSet.GetString(8);
                textBox1.Text = resultSet.GetString(9);
                unitSlNo.Text = resultSet.GetString(10);
                getAcmcParts();
                db.Close();

               

            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message + " =====1");
            }
            string strSQL2 = "SELECT * FROM history_card WHERE hist_id='" +id_to_update+ "';";
            try
            {

                MySqlDataReader resultSet2 = db.ExecuteReader(strSQL2);
                //if (!resultSet.HasRows) throw new MyDBError("User does not exist");
                resultSet2.Read();
                visitDt.Value = Convert.ToDateTime(resultSet2.GetString(2));
                int workDet = resultSet2.GetInt32(3);
                if (workDet == 1) installRdBtn.Select();
                else if (workDet == 2) serviceRdBtn.Select();
                iccr.Text = resultSet2.GetString(6);
                icr.Text = resultSet2.GetString(5);
                icrdate.Value = Convert.ToDateTime(resultSet2.GetString(7));
                amount.Text = resultSet2.GetString(8);
                loadServiceEngineers(resultSet2.GetString(9));
                //string[] parts = Regex.Split(resultSet2.GetString(4),"$-$");
                string[] parts = resultSet2.GetString(4).Split(new string[] { "$-$" }, StringSplitOptions.None);
                foreach (string part in parts)
                {
                    if (part.Length != 0)
                    {
                        TextBox temp = new TextBox();
                        Label tempL = new Label();
                        tempL.Text = "Part Replaced:";
                        temp.Text = part;
                        partsFlow.Controls.Add(tempL);
                        partsFlow.Controls.Add(temp);
                    }
                    //Console.WriteLine(line);
                }


                /*
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
                else if (usedatplace == 2) residence.Select();
                else if (usedatplace == 3) both.Select();
                warrantyDate.Value = Convert.ToDateTime(resultSet.GetString(12));
                int cont_details = resultSet.GetInt32(13);
                if (cont_details == 1) amc.Select();
                else if (cont_details == 2) acmc.Select();
                //loading table
                load_history_table();
                */
                db.Close();
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message );
            }
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
        }

        private bool insertHistoryCard()
        {
            DBConnection db = new DBConnection();
            string qdelete = "DELETE FROM history_card WHERE hist_id='" + id_to_update + "'; ";
            if (db.ExecuteQuery(qdelete))
            {
                try
                {
                    HistoryCard h = loadHistoryObject();
                    String acmc_covered_parts;
                    var parts = new List<string>();
                    foreach (Object c in acmcCheckList.CheckedItems)
                    {
                        //parts.Add(acmcCheckList.Items.IndexOf(c).ToString());//For index value
                        parts.Add(c.ToString());
                    }
                    if (parts.Count > 0) acmc_covered_parts = string.Join(",", parts.ToArray());
                    else acmc_covered_parts = "NULL";
                    string cmdDb = "INSERT INTO history_card values (DEFAULT,'" + c_id + "','" + h.visitDate + "','" + h.work_details + "','" + h.part_replaced + "','" + h.icr_bill_no + "','" + h.iccr_no + "','" + h.iccr_date + "','" + h.amount + "','" + h.exec_attend + "','" + acmc_covered_parts + "');";
                    //MessageBox.Show(cmdDb);

                   
                    if (db.ExecuteQuery(cmdDb))
                        return true;
                    else return false;
                }
                catch (MyDBError ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        private void addPartsReplaced_Click(object sender, EventArgs e)
        {
            TextBox temp = new TextBox();
            Label tempL = new Label();
            tempL.Text = "Part Replaced:";
            partsFlow.Controls.Add(tempL);
            partsFlow.Controls.Add(temp);
        }

        private void addHCard_Click(object sender, EventArgs e)
        {
            if (!(HistoryValid())) return;
            if (MessageBox.Show("Are you sure you want to update ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (insertHistoryCard())
                { MessageBox.Show("Succesfully Updated History Card"); this.Close(); }
                else MessageBox.Show("Error occured while Updating History Card");
            }
        }
        private void loadServiceEngineers(string SE_id)
        {
            int count = 0,pos=0;
            DBConnection db = new DBConnection();
            string cmd = "SELECT exe_name,exe_id FROM executive order by exe_name;";
            MySqlDataReader r = db.ExecuteReader(cmd);
            if (!r.HasRows) { MessageBox.Show("No Executives found in Executive table");  }
            while (r.Read())
            {
                string temp2 =r.GetString(1);
                string temp = r.GetString(0);
                serviceEng.Items.Add(temp);
                if (temp2 == SE_id)
                {
                    pos = count;
                }
                count++;
            }
            serviceEng.SelectedIndex = pos;
            db.Close();
            //return true;
        }
        private string gatherPartsReplaced()
        {
            string partsReplaced = "$-$";
            foreach (Control c in partsFlow.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    partsReplaced += c.Text + "$-$";
                }
            }
            return partsReplaced;
        }
        private int getExeId(string name)
        {
            DBConnection db = new DBConnection();
            string cmd = "SELECT exe_id from executive WHERE exe_name='" + name + "';";
            MySqlDataReader res = db.ExecuteReader(cmd);
            if (!res.HasRows) { MessageBox.Show("Could not find selected executive in Database"); return -1; }
            res.Read();
            int id = res.GetInt32(0);
            db.Close();
            return id;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
