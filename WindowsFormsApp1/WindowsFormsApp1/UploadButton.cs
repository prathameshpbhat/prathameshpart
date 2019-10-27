﻿using System;
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
    public partial class UploadButton : UserControl
    {
        public UploadButton()
        {
            InitializeComponent();
        }

        private void UploadButton_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                label3.Visible = false;
          
            string oradb = "Data Source=localhost;User Id=17CE08;Password=17CE08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select *	 from CAR where CUS_ID ='" + textBox1.Text + "' ";
                cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
                dataGridView1.AllowUserToAddRows = true;
                if (dr.Read())
                {
                  
                    dataGridView1.Visible = true;
                  
                    OracleDataAdapter da = new OracleDataAdapter(cmd.CommandText, conn);
                    DataSet  d = new DataSet();
                    da.Fill(d, "test");
                    dataGridView1.DataSource = d.Tables[0];


                    //label1.Text = dr.GetString(0);
                }
                else
                {
                    label3.Text = "Department ID not found";
                    label3.Visible = true;
                }
                conn.Dispose();
            }
            else
            {
                label3.Text = "You Cant keep Field Empty";
                label3.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
