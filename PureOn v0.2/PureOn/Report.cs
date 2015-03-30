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
    public partial class Report : Form
    {
        private DataTable dbdataset;
        public Report()
        {
            InitializeComponent();
        }
        private void loadTable(string f, string t)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conDataBase = new MySqlConnection(db.getconnstring());
            string cmd = "SELECT `customer_id`,`vist_date`,`icr_bill_no`,`iccr_no`,`iccr_date`,`amount` FROM `history_card` WHERE `vist_date` BETWEEN '" + f + "' AND '" + t + "';";
            MySqlCommand cmdDataBase = new MySqlCommand(cmd, conDataBase);
            //Console.WriteLine(cmd);
            //MessageBox.Show(cmd);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime d = fromDate.Value.Date;
                string fD = d.Date.ToString("yyyy-MM-dd");
                d = toDate.Value.Date;
                string tD = d.Date.ToString("yyyy-MM-dd");
                loadTable(fD, tD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was some error while generating Report\n" + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void genpast6_Click(object sender, EventArgs e)
        {
            try
            {
                toDate.Value= DateTime.Now.Date;
                fromDate.Value = DateTime.Now.Date.AddMonths(-6);
                MessageBox.Show("Generating Report From :"+fromDate.Value.Date+" to "+toDate.Value.Date,"Previous 6 Months Report",MessageBoxButtons.OK,MessageBoxIcon.Information);
                generate_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was some error while generating Report\n" + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
           
            }
        }
    }
}
