using hostel.Model;
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

    public partial class Form1 : Form
    {
        hostelDBEntities db = new hostelDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHostel.Text = "Welcome To Our Hostel";
            lblHostel.Location = new Point((this.ClientSize.Width-lblHostel.Size.Width)/2, 20);
            pcImage.Image = new Bitmap(@"C:\Users\aliw2\source\repos\HostelHomeWork\HostelHomeWork\Image\Image.png");
            pcImage.Location = new Point((this.ClientSize.Width - pcImage.Size.Width) / 2,
                (this.ClientSize.Height - pcImage.Size.Height) / 2);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.ShowDialog();
        }
    }
}
