using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostel
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWorker adw = new AddWorker();
            adw.ShowDialog();
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
