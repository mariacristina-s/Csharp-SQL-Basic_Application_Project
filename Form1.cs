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
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        bool check = false;
        public Form1()
        {
            InitializeComponent();
            //label4.Hide();
            //label5.Hide();
            //checkBox1.Checked = true;
            //txtPassword.UseSystemPasswordChar = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
          /* if (txtUsername.Text == "Admin" && txtPassword.Text == "parola")
            { 
                check = true; 
            }
 
            if (check == true)
            {
                string connetionString;
                
                connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                //label4.Show();
                //label5.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //label4.Hide();
                //label5.Show();
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // dataGridView1.Columns.Clear();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
        }

        private void exitToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
        }

        private void exitToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panelaplicatie_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "parola")
            {
                check = true;
            }

            if (check == true)
            {
                //this.Close();
                string connetionString;

                connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                //label4.Show();
                //label5.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //label4.Hide();
                //label5.Show();
            }
        
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}