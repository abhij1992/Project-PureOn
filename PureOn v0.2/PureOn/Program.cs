using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureOn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was some fatal error encountered in the Application..\nError: "+ex.Message+"\nApplication Shutting down..","Fatal App Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
