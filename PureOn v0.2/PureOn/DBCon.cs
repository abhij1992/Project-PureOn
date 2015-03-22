using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PureOn
{
   public class Customer
   {
       public string cust_id { get; set; }
       public string customer_id { get; set; }
       public string  cust_name { get; set; }
       public string phone_primary { get; set; }
       public string phone_alt { get; set; }
       public string  door_no { get; set; }
       public string street_name { get; set; }
       public string pin_code { get; set; }
       public string  filter_model { get; set; }
       public string  date_of_installation { get; set; }
       public string unit_slno { get; set; }
       public int used_at { get; set; }
       public string warranty_date { get; set; }
       public int cont_details { get; set; }
       public string acmc_covered_parts { get; set; }
   }
   public class HistoryCard
    {
        public long hist_id { get; set; }
        public string customer_id { get; set; }
        public string visitDate { get; set; }
        public int work_details { get; set; }
        public string part_replaced { get; set; }
        public string icr_bill_no { get; set; }
        public string iccr_no { get; set; }
        public string iccr_date { get; set; }
        public string  amount { get; set; }
        public int exec_attend { get; set; }

    }
   public class Credentials
    {
        private string username, password;
        public Credentials(string u, string p)
        {
            username = u; password = p;
        }
       public string getUserName() { return username; }
       public string getPassWord() { return password; }
    }
   public class MyDBError:Exception
    {
        public string Message;
        public int Code;
        public MyDBError(string m) { Message = m; }
        public MyDBError(string m, int code) { Message = m; Code = code; }
    }
   public class LoginClass
   {
       public string user,pass;
       public string u, p;
       public int login_id, emp_privlage;
       public LoginClass(Credentials c)
       {
           this.u = c.getUserName(); this.p = c.getPassWord();
           string strSQL = "SELECT * FROM login_info WHERE emp_uname='"+c.getUserName()+"';";
           try
           {
               DBConnection db = new DBConnection();
               MySqlDataReader resultSet = db.ExecuteReader(strSQL);
               if (!resultSet.HasRows) throw new MyDBError("User does not exist");
               while (resultSet.Read())
               {
                   this.login_id = resultSet.GetInt32(0);
                   this.user = resultSet.GetString(1);
                   this.pass = resultSet.GetString(2);
                   this.emp_privlage = resultSet.GetInt32(3);
               }
               db.Close();
           }
           catch(Exception e)
           {
               throw e;
           }
       }
       public bool validate()
       {
           if((this.pass==this.p) && (this.user==this.u)) return true;
           else return false;
       }
       public int getPrivlage()
       {
           return emp_privlage;
       }
   }
   public class DBConnection
   {
       string connectionString;
       MySqlConnection conn;
       public DBConnection()
       {
           connectionString = "Server=127.0.0.1;Database=pureontech;Uid=root;Pwd=;";
       }
       public MySqlDataReader ExecuteReader(string Query)
       {
           MySqlDataReader resultSet;
           try
           {
               conn = new MySqlConnection(connectionString);
               conn.Open();
               MySqlCommand mysqlCmd = new MySqlCommand(Query, conn);
               resultSet = mysqlCmd.ExecuteReader();
               return resultSet;
           }
           catch(MySqlException e){
               throw new MyDBError(e.Message);
           }
           
       }
       public void Close()
       {
           try { conn.Close(); }
           catch (MySqlException e)
           {
               throw new MyDBError(e.Message);
           }
       }
       public bool ExecuteQuery(string Query)
       {
           try
           {
               conn = new MySqlConnection(connectionString);
               MySqlCommand command = conn.CreateCommand();
               command.CommandText = Query;
               conn.Open();
               if (command.ExecuteNonQuery() == 1) return true;
               else return false;
           }
           catch(MySqlException e)
           {
               throw new MyDBError(e.Message);
           }
           finally
           {
               conn.Close();
           }
       }
       public bool insertCustomer(Customer c)
       {
           try
           {
               string Query = "INSERT into customer_info VALUES (DEFAULT,'" + c.customer_id + "','" + c.cust_name + "','" + c.phone_primary + "','" + c.phone_alt + "','" + c.door_no + "','" + c.street_name + "','" + c.pin_code + "','" + c.filter_model+"','"+c.date_of_installation+"','"+c.unit_slno+"','"+c.used_at+"','"+c.warranty_date+"','"+c.cont_details+"','"+c.acmc_covered_parts+"');";
               //Console.WriteLine(Query);
               if (ExecuteQuery(Query)) return true;
               else return false;
           }
           catch(MyDBError e)
           {
               throw e;
           }
       }
       public string getconnstring()
       {
           return connectionString.ToString();
       }
   }
}