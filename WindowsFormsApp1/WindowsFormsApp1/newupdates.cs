using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class newupdates : UserControl
    {
        public newupdates()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                label3.Visible = false;

                string oradb = "Data Source=localhost;User Id=17CE08;Password=17CE08;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select SERVICE_NO	 from CAR where CUS_ID ='" + textBox1.Text + "' ";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    int val = dr.GetInt32(0);
                  
                    val++;



                    cmd.CommandText = "UPDATE car SET SERVICE_NO='" + val + "'  where CUS_ID='" + textBox1.Text + "' ";
                    cmd.CommandType = CommandType.Text;


                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        MessageBox.Show("Success!");
                        
                    }

                    conn.Dispose();
                }








            }
            else
            {
                label3.Text = "You Cant keep Field Empty";
                label3.Visible = true;
            }

        }
    }
}

