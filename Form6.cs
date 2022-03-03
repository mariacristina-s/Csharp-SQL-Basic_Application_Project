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
    public partial class Form6 : Form
    {
        SqlConnection cnn;
        public Form6()
        {
            
            InitializeComponent();
            string connetionString;

            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select ed.[nume editura] from editura ed 
            inner join element e on ed.[id editura] = e.[id editura] group by ed.[nume editura] 
            having COUNT(ed.[id editura]) >= (select top 1  count(m.[id editura]) from element m 
            group by m.[id editura] order by count(m.[id editura]) DESC)", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlData = new SqlDataAdapter(@"select ed.[id editura], ed.[nume editura] from editura ed 
            where ed.[id editura] NOT IN(select e.[id editura] from element e inner join editura ed2 
            on e.[id editura] = ed2.[id editura])", cnn);
            dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select ed.[id editura], ed.[nume editura] 
            from editura ed inner join element e on ed.[id editura] = e.[id editura] 
            where ed.[id editura] = any (select m.[id editura] from element m 
            where m.[an publicatie] = '"+textBox1.Text+"') group by ed.[id editura], ed.[nume editura]", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
