using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureOn
{
    public partial class SpashScreen : Form
    {
        public SpashScreen()
        {
            InitializeComponent();
            this.BackColor = Color.Blue;
            this.TransparencyKey = Color.Blue;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
