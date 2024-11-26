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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Gender, Hobby, Status= "";
            if (radioButton1.Checked) Gender = "Male";
            else Gender = "Female";
            if (checkBox2.Checked) Hobby = "Book reading";
            else Hobby = "Gardening";
            if (radioButton3.Checked) Status = "Married";
            else Status = "UnMarried";
            MessageBox.Show("Customer Name: " + textBox1.Text + "\n" +
                "Country:" + comboBox1.Text + "\n" +
                "Gender:" + Gender + "\n" +
                "Hobby:" + Hobby + "\n" +
                "Status:" + Status + "\n"
 
                );

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCustomer();
        }
        private  void loadCustomer()
        {
            string strConnection = "Data Source=AUMC-LAB3-31\\SQLEXPRESS;Initial Catalog=customer DB;"+ "Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            string strCommand = "Select from CustomerTable";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            DataSet objDatSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDatSet);
            dataGridView1.DataSource = objDatSet.Tables[0];
            objConnection.Close();

        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
