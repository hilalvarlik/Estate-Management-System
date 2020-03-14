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
namespace EmlakSistemi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string evdurumu;
        SqlCommand komut;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        private void ekle()
        {
            baglanti.Open();
            string kayit = "insert into sahipbilgileri(id,adı,telefon) Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            baglanti.Close();
            MessageBox.Show("Kaydınız başarıyla eklendi");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ekle();
        }
    }
}
