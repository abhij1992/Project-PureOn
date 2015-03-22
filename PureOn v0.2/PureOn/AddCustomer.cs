using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PureOn
{
    public partial class AddCustomer : Form
    {
        public bool newRecord { get; set; }
        public AddCustomer()
        {
            InitializeComponent();
            this.newRecord = false;
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
            else if (!amc.Checked && !acmc.Checked &&!none.Checked)
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
            if (parts.Count > 0)cr.acmc_covered_parts = string.Join(",", parts.ToArray());
            else cr.acmc_covered_parts = "NULL";
            MessageBox.Show(cr.acmc_covered_parts);

            return cr;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!AddCustomervalid())
            {
                return;
            }
            Customer cr = loadCustomerObject();
            try
            {
                DBConnection db = new DBConnection();
                if(db.insertCustomer(cr)){
                MessageBox.Show("Added new customer succesfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information); 
                this.newRecord = true;
                this.Close();
                }else 
                   MessageBox.Show("Error in adding new customer to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(MyDBError ex)
            {
                MessageBox.Show("Error encountered:\n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
