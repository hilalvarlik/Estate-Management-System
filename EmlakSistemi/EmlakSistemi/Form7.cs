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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string evdurumu;
        SqlCommand komut;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        private void listele()
        {
            baglanti.Open();
            string kayit = "select site,blok,no,adı,telefon from evbilgileri join sahipbilgileri on evbilgileri.SahipId = sahipbilgileri.id";
                           
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void sahipliste()
        {
            baglanti.Open();
            string kayit = "spGetSahipBilgileri";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
        private void evliste()
        {
            baglanti.Open();
            string kayit = "spGetEvBilgileri";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            baglanti.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void sahipsil()
        {
            baglanti.Open();
            string kayit = "Delete from sahipbilgileri where id=('"+dataGridView2.CurrentRow.Cells[0].Value.ToString()+"')";
            SqlCommand komut = new SqlCommand(kayit, baglanti);    
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();

        }
        private void eskievsahipliste()
        {
            baglanti.Open();
            string kayit = "Select * from eskievsahipleri";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sahipliste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evliste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 evsahibiekle = new Form8();
            evsahibiekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sahipsil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eskievsahipliste();
        }
    }
}
