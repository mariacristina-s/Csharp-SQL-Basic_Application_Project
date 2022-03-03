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
    public partial class Form8 : Form
    {
        SqlConnection cnn;
        public Form8()
        {
            InitializeComponent();
           
            string connetionString;

            connetionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = Tema; Integrated Security = True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(@"select e.[id element], e.[nume element], e.pret 
            from element e group by e.[id element], e.[nume element], e.pret 
            having e.pret > (select avg(pret) from element)", cnn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            sqlData = new SqlDataAdapter("select avg(pret) as Medie from element", cnn);
            dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
