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
    public partial class Revenue : Form
    {
        private DataTable dbdataset;
        public Revenue()
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
                while (rd.Read())
                {
                    exeCombo.Items.Add(rd.GetString(0));
                }
                exeCombo.SelectedIndex = 0;
                db.Close();
                return;
            }
            catch (MyDBError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int getExeId(string name)
        {
            DBConnection db = new DBConnection();
            string cmd = "SELECT exe_id from executive WHERE exe_name='" + name + "' and isworking=1;";
            MySqlDataReader res = db.ExecuteReader(cmd);
            if (!res.HasRows) { MessageBox.Show("Could not find selected executive in Database"); return -1; }
            res.Read();
            int id = res.GetInt32(0);
            db.Close();
            return id;
        }
        private void loadTable(int id,string f,string t)
        {
            DBConnection db = new DBConnection();
            MySqlConnection conDataBase = new MySqlConnection(db.getconnstring());
            string cmd = "SELECT `customer_id`,`vist_date`,`icr_bill_no`,`iccr_no`,`iccr_date`,`amount` FROM `history_card` WHERE `exec_attend`='"+id+"' AND `vist_date` BETWEEN '" + f + "' AND '" + t + "';";
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

        private void queryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = getExeId(exeCombo.Text);
                if (id == -1) return;  //Executive not found!
                DateTime d = fromDate.Value.Date;
                string fD = d.Date.ToString("yyyy-MM-dd");
                d = toDate.Value.Date;
                string tD = d.Date.ToString("yyyy-MM-dd");
                loadTable(id, fD, tD);
                long sum = 0;
                foreach (DataRow row in dbdataset.Rows)
                {
                    sum += Int64.Parse(row.Field<string>("amount"));
                }
                totRev.Text = sum.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was some error while generating Report\n"+ex.Message,"Report Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);
        }
    }
}
