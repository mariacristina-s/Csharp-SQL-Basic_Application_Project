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
    
    public partial class Form4 : Form
    {
        SqlConnection cnn;
        public Form4()
        {
            InitializeComponent();


            string connetionString;

            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand command = new SqlCommand("insert into Autor ([Nume Autor], CNP, NrTelefon) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Autor set [Nume Autor]='" + textBox1.Text + "', NrTelefon='" + textBox3.Text + "' where CNP='" + textBox2.Text + "'", cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data has been updated");
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Autor where CNP='" + textBox2.Text + "'",cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
