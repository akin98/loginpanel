using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ödvsoru2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            sorgu();
        }
        SqlConnection baglantı=new SqlConnection("server =.; Initial Catalog = soru2; Integrated Security = True");
        public void sorgu()
        {baglantı.Open();
            string baglan = ("select*from giris ");
            SqlDataAdapter ata = new SqlDataAdapter(baglan, baglantı);
            DataTable dt= new DataTable();
            ata.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();

            
          
        }
            

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
