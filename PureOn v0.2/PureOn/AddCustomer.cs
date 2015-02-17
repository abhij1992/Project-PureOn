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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private Customer loadCustomerObject()
        {
            Customer cr = new Customer();
            cr.customer_id = custID.Text;
            cr.cust_name = custName.Text;
            cr.phone_primary = Int32.Parse(phonePrime.Text);
            cr.phone_alt = Int32.Parse(phoneAlt.Text);
            cr.door_no = doorNo.Text;
            cr.street_name = street.Text;
            cr.pin_code = Int32.Parse(pinCode.Text);
            cr.filter_model = filterModel.Text;
            DateTime d = dateOfInstallation.Value.Date;
            cr.date_of_installation = d.Date.ToString("yyyy-MM-dd");
            cr.unit_slno = unitSlNo.Text;

            if (office.Enabled) cr.used_at = 1;
            else if (residence.Enabled) cr.used_at = 2;
            else if (both.Enabled) cr.used_at = 3;

            d = warrantyDate.Value.Date;
            cr.warranty_date = d.Date.ToString("yyyy-MM-dd");

            if (amc.Enabled) cr.cont_details = 1;
            else if (acmc.Enabled) cr.cont_details = 2;

            return cr;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Customer cr = loadCustomerObject();

            try
            {
                DBConnection db = new DBConnection();
                if(db.insertCustomer(cr))
                MessageBox.Show("Added new customer succesfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else MessageBox.Show("Error in adding new customer to Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
