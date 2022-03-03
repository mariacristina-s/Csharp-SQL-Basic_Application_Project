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
    public partial class Form7 : Form
    {
        SqlConnection cnn;
        public Form7()
        {
            InitializeComponent();
            string connetionString;

            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select a.[Nume Autor] from autor a 
            where a.[id autor] not in (select b.[id autor] from autor b 
            inner join element_autor ea on ea.[ID autor] = b.[ID autor] 
            inner join element e on e.[id element] = ea.[id element] 
            where ((b.[id autor] = ea.[id autor]) AND(ea.[id element] = e.[id element])))", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
