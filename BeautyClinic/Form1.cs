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

namespace BeautyClinic
{
    public partial class Form1 : Form
    {
        public static OracleConnection conn;
        OracleCommand cmd, query;
        OracleDataReader reader;
        OracleDataAdapter adap;
        DataSet ds;

        string username = "", password = "";
        Boolean login = false;

        public Form1()
        {
            InitializeComponent();

            // Testing git DONE
            // Coba push Git
            string connString = "Data Source=XE; User Id=beautyclinic; Password=beautyclinic;";

            conn = new OracleConnection(connString);

            try
            {
                conn.Close();
                conn.Open();

                MessageBox.Show("berhasil");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Salah pencet
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tb_username.Text;
            password = tb_password.Text;

            string oString = "Select * from Staff";
            OracleCommand oCmd = new OracleCommand(oString, conn);
            conn.Open();
            using (OracleDataReader oReader = oCmd.ExecuteReader())
            {
                
                while (oReader.Read())
                {
                    MessageBox.Show("aaaaaa");
                }

                conn.Close();
            }

            /*Oprator opr = new Oprator();
            opr.Show();
            this.Visible = false;*/

            try
            {

                // ini utk admin
               /* conn.Close();
                conn.Open();

                cmd = new OracleCommand("SELECT * FORM STAFF");
                adap = new OracleDataAdapter(cmd);
                ds = new DataSet();
                adap.Fill(ds, "akses");

                conn.Close();

                /*string nama = ds.Tables["akses"].Rows[0][1].ToString();

                MessageBox.Show(nama);*/


                /*query = new OracleCommand("SELECT * FROM STAFF WHERE NAMA_STAFF=:name AND PASSWORD_STAFF=:pass", conn);
                query.Parameters.Add(new OracleParameter(":name", username));
                query.Parameters.Add(new OracleParameter(":pass", password));
                adap = new OracleDataAdapter(query);
                ds = new DataSet();
                adap.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                MessageBox.Show(i + "");
                if(i == 1)
                {
                    Oprator opr = new Oprator();
                    opr.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                conn.Close();*/

                /*query = new OracleCommand("SELECT * FROM STAFF", conn);
                adap = new OracleDataAdapter(query);
                ds = new DataSet();
                adap.Fill(ds, "staff");

               for (int i=0; i<ds.Tables["staff"].Rows.Count; i++)
                {
                    MessageBox.Show("here1");
                    if (username == ds.Tables["staff"].Rows[i][1].ToString() 
                        && password == ds.Tables["staff"].Rows[i][5].ToString())
                    {
                        MessageBox.Show("here");
                        login = true;
                        if("Admin" == ds.Tables["staff"].Rows[i][4].ToString())
                        {
                            MessageBox.Show("a");
                        }
                        else if ("Beauty operator" == ds.Tables["staff"].Rows[i][4].ToString())
                        {
                            MessageBox.Show("bo");
                            Oprator opr = new Oprator();
                            opr.Show();
                            this.Visible = false;
                        }
                        else if ("Beauty assistant" == ds.Tables["staff"].Rows[i][4].ToString())
                        {
                            MessageBox.Show("ba");
                        }
                        else 
                        {
                            MessageBox.Show("nothing");
                        }
                    }
                }

                conn.Close();*/

                /*if(login == false)
                {
                    MessageBox.Show("Login failed!");
                }*/

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
