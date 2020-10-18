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
    public partial class UbahJadwal : Form
    {
        public UbahJadwal()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Oprator opr;
            opr = new Oprator();
            opr.MdiParent = MdiParent;
            opr.Show();
            this.Close();
        }
    }
}
