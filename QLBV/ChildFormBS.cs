using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Size

namespace QLBV
{
    public partial class frmChildFormBS : Form
    {
        public frmChildFormBS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new frmMainForm();
            if(f1.WindowState != FormWindowState.Maximized)
            {
                Form f = new test();
                f.ShowDialog();
            }
            
        }
    }
}
