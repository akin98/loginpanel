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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(("server =.; Initial Catalog = soru2; Integrated Security = True"));


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sorgu = new SqlCommand("select*from giris where username=@ad and password=@şif ",baglan);
            sorgu.Parameters.AddWithValue("@ad", textBox1.Text);
            sorgu.Parameters.AddWithValue("@şif", textBox2.Text);

            baglan.Open();
            SqlDataReader oku=sorgu.ExecuteReader();
            if(oku.Read())
            {
                MessageBox.Show("Başarılı giriş yaptınız");
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }
            baglan.Close();
        }
    }
}
