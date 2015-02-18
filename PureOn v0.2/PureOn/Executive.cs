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
    public partial class Executive : Form
    {
        public Executive()
        {
            InitializeComponent();
            Customer c = new Customer();

        }
        DataTable dbdataset;
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
        }

        private void Executive_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Executive_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conDataBase = new MySqlConnection(db.getconnstring());
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT `customer_id`,`cust_name`,`phone_primary`,`door_no`,`street_name`,`pin_code` FROM `customer_info`;", conDataBase);
            //String cmdDataBase = "SELECT `customer_id`,`cust_name`,`phone_primary`,`door_no`,`street_name`,`pin_code` FROM `customer_info`;";

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }

        }
        private void textChanged()
        {
         
            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("customer_id LIKE '%{0}%' AND cust_name LIKE '%{1}%' AND CONVERT({2}, System.String) like '%{3}%' AND door_no LIKE '%{4}%' AND street_name LIKE '%{5}%' AND CONVERT({6}, System.String) like '%{7}%' ", custID.Text, custName.Text,"phone_primary",phonePrime.Text,doorNo.Text,street.Text,"pin_code",pinCode.Text);
            //dv.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'","phone_primary",custID.Text);
            dataGridView1.DataSource = dv;
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

        private void street_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void pinCode_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }
     
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                History frmHistory = new History();
                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmHistory.custID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmHistory.ShowDialog();
            }
        }
    }
}