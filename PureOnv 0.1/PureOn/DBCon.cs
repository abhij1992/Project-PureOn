using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace PureOn
{
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
        public MyDBError(string m) { Message = m; }
    }
   public class LoginClass
   {
       public string user,pass;
       public string u, p;
       public int login_id, emp_privlage;
       public LoginClass(Credentials c,string server,string database,string username,string password)
       {
           this.u = c.getUserName(); this.p = c.getPassWord();
           string connectionString = "Server="+server+";Database="+database+";Uid="+username+";Pwd="+password+";";
           string strSQL = "SELECT * FROM login_info WHERE emp_uname='"+c.getUserName()+"';";
           try
           {
               MySqlConnection conn = new MySqlConnection(connectionString);
               conn.Open();
               MySqlCommand mysqlCmd = new MySqlCommand(strSQL, conn);
               MySqlDataReader resultSet = mysqlCmd.ExecuteReader();
               if (!resultSet.HasRows) throw new MyDBError("User does not exist");
               while (resultSet.Read())
               {
                   this.login_id = resultSet.GetInt32(0);
                   this.user = resultSet.GetString(1);
                   this.pass = resultSet.GetString(2);
                   this.emp_privlage = resultSet.GetInt32(3);
               }
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
}
