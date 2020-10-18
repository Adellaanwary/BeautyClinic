using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyClinic
{
    public partial class Oprator : Form
    {
        public Oprator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Oprator_Load(object sender, EventArgs e)
        {
            //Untuk buat background tidak abu2
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.White;
                    break;
                }
            }
            //--------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daftarMembership dm = new daftarMembership();
            dm.MdiParent = this.MdiParent;
            this.Close();
            dm.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingJadwal bj = new BookingJadwal();
            bj.MdiParent = this.MdiParent;
            this.Close();
            bj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
