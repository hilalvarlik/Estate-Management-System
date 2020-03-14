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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        string evdurumu;

        private void sorgula()
        {
            baglanti.Open();
            string kayit = "SELECT * FROM emlakekleme Where evdurumu='Satılık Ev'";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        private void sorgula1()
        {
            baglanti.Open();
            string kayit = "SELECT * FROM emlakekleme Where evdurumu='Kiralık Ev'";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        private void siralamabk()
        {
            baglanti.Open();
            string kayit = "SELECT * FROM emlakekleme order by fiyat DESC";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        private void siralamakb()
        {
            baglanti.Open();
            string kayit = "SELECT* FROM emlakekleme order by fiyat ASC";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        private void max()
        {
            baglanti.Open();
            string kayit = "SELECT Max(fiyat) as EnYüksekFiyat from emlakekleme";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        private void min()
        {
            baglanti.Open();
            string kayit = "SELECT Min(fiyat) as EnDüşükFiyat from emlakekleme";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            evdurumu = "Satılık Ev";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            evdurumu = "Kiralık Ev";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (evdurumu == "Satılık Ev")
            {
                sorgula();
            }
            else if (evdurumu == "Kiralık Ev")
            {
                sorgula1();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Çoktan aza")
            {
                siralamabk();
            }
            if (comboBox1.Text == "Azdan çoğa")
            {
                siralamakb();
            }
            if (comboBox1.Text == "En yüksek")
            {
                max();
            }
            if (comboBox1.Text == "En düşük")
            {
                min();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
