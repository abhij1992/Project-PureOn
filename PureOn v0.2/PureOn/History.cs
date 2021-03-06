﻿using System;
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
    public partial class History : Form
    {
        //DataTable dbdataset;
        private long  CustomerAutoGenID;
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM customer_info WHERE customer_id='"+custID.Text+"';";
            try
            {
                DBConnection db = new DBConnection();
                MySqlDataReader resultSet = db.ExecuteReader(strSQL);
                //if (!resultSet.HasRows) throw new MyDBError("User does not exist");
                resultSet.Read();
                CustomerAutoGenID = resultSet.GetInt64(0); //gets the Customers Autogenerated ID to be used in Add history card form
                custID.Text = resultSet.GetString(1);
                custName.Text = resultSet.GetString(2);
                phonePrime.Text = resultSet.GetString(3);
                filterModel.Text = resultSet.GetString(8);
                textBox1.Text = resultSet.GetString(9);
                unitSlNo.Text = resultSet.GetString(10);
                db.Close();

                //loading table
                load_history_table();

            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message);
            }
        }
        public void load_history_table()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DBConnection db = new DBConnection();
            string strSQL = "SELECT `vist_date`,`work_details`,`parts_replaced`,`icr_bill_no`,`iccr_no`,`iccr_date`,`amount`, `e`.`exe_name` FROM `history_card`,`executive` `e` WHERE e.exe_id = exec_attend and `history_card`.`customer_id` = '" + custID.Text + "';";
            MySqlDataReader resultSet = db.ExecuteReader(strSQL);
            dataGridView1.ColumnCount = 8   ;
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
                string rps = "Rs. "+resultSet.GetString(6).ToString();
                //string pattern = "\($-$)\+s";
                dataGridView1.Rows.Add(words[0], str, output, resultSet.GetString(3).ToString(), resultSet.GetString(4).ToString(), words2[0], rps, resultSet.GetString(7).ToString());
                //dataGridView1.Rows.Add(str,str);

                    /*CustomerAutoGenID = resultSet.GetInt64(0); //gets the Customers Autogenerated ID to be used in Add history card form
                custID.Text = resultSet.GetString(1);
                custName.Text = resultSet.GetString(2);
                phonePrime.Text = resultSet.GetString(3);
                filterModel.Text = resultSet.GetString(8);
                textBox1.Text = resultSet.GetString(9);
                unitSlNo.Text = resultSet.GetString(10);
                 */
            }

        }

        private void addHistory_Click(object sender, EventArgs e)
        {
            AddHistoryCard ahc = new AddHistoryCard(custID.Text);
            //MessageBox.Show(ahc.cID);
            ahc.ShowDialog();
        }

        private void History_Activated(object sender, EventArgs e)
        {
            load_history_table();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
