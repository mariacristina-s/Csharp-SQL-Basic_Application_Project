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
    public partial class Form5 : Form
    {
        SqlConnection cnn;
        public Form5()
        {
            InitializeComponent();
            string connetionString;

            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select m.[Nume Materie] from materie m 
            inner join element e on e.[id materie] = m.[id materie] group by m.[nume materie] 
            having count(e.[id element]) > 3", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select a.[Nume Autor] from autor a inner join element_autor ea
            on a.[id autor] = ea.[id autor] inner join element e on e.[id element] = ea.[id element] 
            group by a.[nume autor] having count(e.[id element]) >"+textBox1.Text, cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select e.[Nume Element], e.pret from element e 
            inner join materie m on m.[id materie]=e.[id materie] where ((m.[nume materie]= '"+textBox2.Text+"')" +
            " AND (e.Tip = '"+textBox4.Text+"'))", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select e.[Nume Element], e.pret from element e 
            inner join clasa c on c.[id clasa]=e.[id clasa] where ((c.[numar clasa]= '" + textBox5.Text + "')" +
            " AND (e.Semestru = '" + textBox3.Text + "'))", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView4.DataSource = dtbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(@"Select DISTINCT  m.[Nume Element], a.[Nume Autor] 
                From Element m inner join Element_Autor ea on ea.[ID Element] = m.[ID Element] 
                inner join Autor a on a.[ID Autor] = ea.[ID Autor] where A.[Nume Autor] = '"+textBox6.Text+"'", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView5.DataSource = dtbl;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(@"Select e.[Nume Element] from Element e inner join Editura ea 
            on e.[ID Editura] = e.[ID Editura] where ea.[Nume Editura] = '"+textBox7.Text+"'", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView6.DataSource = dtbl;
        }
    }
}
