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
    public partial class NEWUPLOAD : UserControl
    {
        public NEWUPLOAD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""&& textBox2.Text != ""&& textBox3.Text != "")
            {
                label4.Visible = false;
                string oradb = "Data Source=localhost;User Id=17CE08;Password=17CE08;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT into car values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',0)";
                cmd.CommandType = CommandType.Text;


                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    MessageBox.Show("Record not inserted");
                }
                else
                {
                    MessageBox.Show("Success!");
                    MessageBox.Show("User has been created");
                }
                conn.Dispose();
            }
            else
            {
                label4.Text = "You Cant keep Field Empty";
                label4.Visible = true;
            }

        }
    }
}
