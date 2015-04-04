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
    public partial class Executive : Form
    {
        DataTable dbdataset;

        public Executive()
        {
            InitializeComponent();
            Customer c = new Customer();

        }
        
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
            if (a.newRecord) loadTable();//MessageBox.Show("New record added");
            else { /*MessageBox.Show("No record was added"); */}
          
        }

        private void Executive_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult dr= MessageBox.Show("Do you want to Log out and Exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if (dr == DialogResult.OK)
           {
               //Application.Exit();
               Environment.Exit(0);
           }
           else { e.Cancel = true; this.Activate(); }
        }

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

        private void Executive_Load(object sender, EventArgs e)
        {
            loadTable();
            this.StartPosition = FormStartPosition.Manual;
        }

        private void textChanged()
        {
         
            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("customer_id LIKE '%{0}%' AND cust_name LIKE '%{1}%' AND CONVERT({2}, System.String) like '%{3}%' AND door_no LIKE '%{4}%' AND street_name LIKE '%{5}%' AND CONVERT({6}, System.String) like '%{7}%' ", custID.Text, custName.Text,"phone_primary",phonePrime.Text,doorNo.Text,street.Text,"pin_code",pinCode.Text);
            //dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'","phone_primary",custID.Text);
            dataGridView.DataSource = dv;
        }

        private void custID_TextChanged(object sender, EventArgs e)
        {

            custID.Text = Regex.Replace(custID.Text, @"[^0-9a-zA-Z]+", " ");
            textChanged();
        }

        private void custName_TextChanged(object sender, EventArgs e)
        {
            custName.Text = Regex.Replace(custName.Text, @"[^0-9a-zA-Z]+", " ");
            textChanged();
        }

        private void phonePrime_TextChanged(object sender, EventArgs e)
        {
            phonePrime.Text = Regex.Replace(phonePrime.Text, @"[^0-9a-zA-Z]+", " ");
            textChanged();
        }

        private void doorNo_TextChanged(object sender, EventArgs e)
        {
            doorNo.Text = Regex.Replace(doorNo.Text, @"[^0-9a-zA-Z#]+", " ");
            textChanged();
        }

        private void street_TextChanged(object sender, EventArgs e)
        {
            street.Text = Regex.Replace(street.Text, @"[*]+", " ");
            textChanged();
        }

        private void pinCode_TextChanged(object sender, EventArgs e)
        {
            pinCode.Text = Regex.Replace(pinCode.Text, @"[^0-9a-zA-Z]+", " ");
            textChanged();
        }
   
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
               /* History frmHistory = new History();
                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmHistory.custID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmHistory.ShowDialog();*/

                Update_customer frmUCustomer = new Update_customer(true);
                frmUCustomer.custID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmUCustomer.ShowDialog();
                if (frmUCustomer.newRecord) { loadTable(); }
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.ShowDialog();
        }

        private void customerData_Enter(object sender, EventArgs e)
        {

        }
    }
}