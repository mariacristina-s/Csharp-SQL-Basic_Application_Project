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

namespace ProiectBD
{
    public partial class Form2 : Form
    {
        bool check = true;
        SqlConnection cnn;

        public Form2()
        {
            InitializeComponent();
            string connetionString;
            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

        }

        private void txtUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(@"Select e.[Nume element], m.[nume materie],
                ed.[nume editura], e.semestru, e.tip, e.pret, e.[an publicatie], e.[nr pagini],
                e.[id clasa] from Element e 
                inner join materie m on m.[id materie]=e.[id materie]
                inner join editura ed on ed.[id editura]=e.[id editura]", cnn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Autor", cnn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Editura", cnn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Clasa", cnn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Materie", cnn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Element_Autor", cnn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
     
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }
    }
}
