using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection variables
            string connectionString;
            SqlConnection cnn;

            //Connection
            connectionString = @"Data Source=VEDANT\SQLEXPRESS;Initial Catalog=TutorialDB;
            User ID=sa;Password=Admin@1234";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Query variables
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            //MessageBox.Show("Connection Open");

            //Query
            sql = "SELECT TutorialID,TutorialName from demotb";
            command = new SqlCommand(sql, cnn);

            //Data reader definition
            dataReader = command.ExecuteReader();

            //Get table values
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            //Display output
            MessageBox.Show(Output);

            //Close all objects
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            cnn.Close();
        }
    }
}
