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
    public partial class History : Form
    {
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
                
                custID.Text = resultSet.GetString(1);
                custName.Text = resultSet.GetString(2);
                phonePrime.Text = resultSet.GetString(3);
                filterModel.Text = resultSet.GetString(8);
                textBox1.Text = resultSet.GetString(9);
                unitSlNo.Text = resultSet.GetString(10);
                db.Close();
            }
            catch (Exception e3)
            {
                throw e3;
            }
        }
    }
}
