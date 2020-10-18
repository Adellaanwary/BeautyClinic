using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace BeautyClinic
{
    public partial class daftarMembership : Form
    {
        OracleConnection conn;
        OracleCommand query;
        OracleDataReader reader;
        OracleDataAdapter adap;
        DataSet ds;

        string nama = "", alamat = "", email = "";
        long nomorTelepon = 0;


        public daftarMembership()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oprator opr = new Oprator();
            opr.MdiParent = this.MdiParent;
            opr.Visible = true;
            this.Visible = false;

            conn = new OracleConnection("Data Source = XE; User ID = beautyclinic; Password=beautyclinic");

            try
            {
                conn.Close();
                conn.Open();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void daftarMembership_Load(object sender, EventArgs e)
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Oprator opr;
            opr = new Oprator();
            opr.MdiParent = MdiParent;
            opr.Show();
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            nama = tb_nama.Text;
            alamat = tb_alamat.Text;
            nomorTelepon = Convert.ToInt64(tb_tlp.Text);
            email = tb_email.Text;

            int id = 0;

            conn.Close();
            conn.Open();

            query = new OracleCommand("INSERT INTO MEMBER VALUES(:id, :nama, :alamat, :telepon, :email, :status)", conn);
            query.Parameters.Add(new OracleParameter(":id", id));
            query.Parameters.Add(new OracleParameter(":nama", nama));
            query.Parameters.Add(new OracleParameter(":alamat", alamat));
            query.Parameters.Add(new OracleParameter(":telepon", nomorTelepon));
            query.Parameters.Add(new OracleParameter(":email", email));
            query.Parameters.Add(new OracleParameter(":status", "1"));
            query.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Berhasil menambahkan member!");
        }
    }
}
