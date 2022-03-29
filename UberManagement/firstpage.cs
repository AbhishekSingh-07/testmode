using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberManagement
{
    public partial class firstpage : Form
    {
        public firstpage()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
          registerpage  ob = new registerpage();
            ob.Show();
            this.Hide();
        }

        private void firstpage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
