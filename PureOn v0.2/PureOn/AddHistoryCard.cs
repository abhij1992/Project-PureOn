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
    public partial class AddHistoryCard : Form
    {
        public string cID { get; set; }
        public AddHistoryCard(string custId)
        {
            InitializeComponent();
            loadServiceEngineers();
            cID = custId;
            this.custID.Text = cID;

            TextBox temp = new TextBox();
            Label tempL = new Label();
            tempL.Text = "Part:";
            partsFlow.Controls.Add(tempL);
            partsFlow.Controls.Add(temp);
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

            hc.icr_bill_no=icr.Text;
            hc.iccr_no = iccr.Text;
            d=icrdate.Value.Date;
            hc.iccr_date = d.Date.ToString("yyyy-MM-dd");
            hc.amount = Int32.Parse(amount.Text);
            hc.exec_attend = getExeId(serviceEng.Text);

            return hc;
        }
        private void addPartsReplaced_Click(object sender, EventArgs e)
        {
            TextBox temp = new TextBox();
            Label   tempL = new Label();
            tempL.Text = "Part Replaced:";
            partsFlow.Controls.Add(tempL);
            partsFlow.Controls.Add(temp);
        }
        private bool insertHistoryCard()
        {
            DBConnection db;
            try
            { 
            HistoryCard h = loadHistoryObject();
            string cmdDb = "INSERT INTO history_card values (DEFAULT,'"+h.customer_id+"','"+h.visitDate+"','"+h.work_details+"','"+h.part_replaced+"','"+h.icr_bill_no+"','"+h.iccr_no+"','"+h.iccr_date+"','"+h.amount+"','"+h.exec_attend+"');";
            //MessageBox.Show(cmdDb);
            
            db = new DBConnection();
            if (db.ExecuteQuery(cmdDb))
                return true;
            else return false;
           }
            catch(MyDBError ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private void addHCard_Click(object sender, EventArgs e)
        {
            if (insertHistoryCard())
            { MessageBox.Show("Succesfully Inserted new History Card"); this.Close(); }
            else MessageBox.Show("Error occured while inserting New History Card"); 
        }
        private bool loadServiceEngineers()
        {
            DBConnection db = new DBConnection();
            string cmd = "SELECT exe_name FROM executive;";
            MySqlDataReader r = db.ExecuteReader(cmd);
            if (!r.HasRows) { MessageBox.Show("No Executives found in Executive table"); return false; }
            while(r.Read())
            {
                serviceEng.Items.Add(r.GetString(0));
            }
            serviceEng.SelectedIndex=0;
            db.Close();
            return true;
        }
        private string gatherPartsReplaced()
        {
            string partsReplaced = "$-$";
            foreach (Control c in partsFlow.Controls)
            {
                if(c.GetType() ==typeof(TextBox))
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
            if(!res.HasRows){MessageBox.Show("Could not find selected executive in Database"); return -1;}
            res.Read();
            int id =  res.GetInt32(0);
            db.Close();
            return id;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
