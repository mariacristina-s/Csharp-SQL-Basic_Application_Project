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

    public partial class Form3 : Form
    {
        SqlConnection cnn;
        
        public Form3()
        {
            InitializeComponent();
            string connetionString;

            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private TextBox GetTextBox1()
        {
            return textBox1;
        }

        private TextBox GetTextBox2()
        {
            return textBox2;
        }

        private TextBox GetTextBox3()
        {
            return textBox3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand(@"insert into Editura ([Nume Editura], [Nume Persoana Contact], 
                    [Nr Telefon Persoana Contact]) values ('" + textBox1.Text + "', '" + textBox2.Text + "'," +
                    " '" + textBox3.Text + "')", cnn);
            
            command.ExecuteNonQuery();
            
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand(@"update Editura set [Nume Persoana Contact]='" + textBox2.Text+"', " +
                "[Nr Telefon Persoana Contact]='" + textBox3.Text+ "' where [Nume Editura]='" + textBox1.Text + "'", cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data has been updated");
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Editura where [Nume Editura]='" + textBox1.Text + "'", cnn);
            command.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
