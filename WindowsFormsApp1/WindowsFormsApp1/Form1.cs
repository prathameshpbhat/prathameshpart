using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
         uploadButton1.BringToFront();
           
                
                }

        private void button1_Click(object sender, EventArgs e)
        {

            panel4.Height = button2.Height;
            panel4.Top = button1.Top;
            /*
            string oradb = "Data Source=localhost;User Id=17CE08;Password=17CE08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
           conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CUS_NAME	 from car";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            label1.Text = dr.GetString(0);
            conn.Dispose();
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            newupdates1.BringToFront();
            /*
            string oradb = "Data Source=localhost;User Id=17CE08;Password=17CE08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT into car values('jjjj','tttt')";
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
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;

            panel4.Visible = true;
            panel4.Top = button3.Top;
          newupload1.BringToFront();
           /* string oradb = "Data Source=localhost;User Id=17CE08;Password=17CE08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE car SET CUS_NAME='prathamesh' where CAR_MODEL='q'";
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
            conn.Dispose();*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uploadButton1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
           uploadButton1.BringToFront();
        }

        private void newupload1_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
