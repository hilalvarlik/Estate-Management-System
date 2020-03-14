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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string evdurumu;
        SqlCommand komut;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void doldur()
        {
            baglanti.Open();
            string kayit = "spGetSelect";
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void ekle()
        {
            baglanti.Open();
            string kayit = "insert into emlakekleme(site,blok,no,katno,metrekare,odasayisi,evdurumu,fiyat) Values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + comboBox4.Text + "','" + evdurumu + "','" + textBox3.Text + "')";

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
            MessageBox.Show("Kaydınız başarıyla eklendi");

        }
        private void sil()
        {
            
            string kayit = ("Delete from emlakekleme where no='"+dataGridView1.CurrentRow.Cells[2].Value.ToString()+"'");
            
            SqlCommand komut = new SqlCommand(kayit, baglanti);
           
            SqlDataAdapter da = new SqlDataAdapter(komut);
            baglanti.Open();
            komut.ExecuteNonQuery(); 
            baglanti.Close();
            doldur();
            MessageBox.Show("Kayıt silindi.");

        }
        private void guncelle()
        {

            string kayit = ("Update emlakekleme set site='" + comboBox1.Text + "', blok='" + comboBox2.Text + "',no='" + textBox1.Text + "',katno='" + comboBox3.Text + "',metrekare='" + textBox2.Text + "',odasayisi='" + comboBox4.Text + "',evdurumu='" + evdurumu + "' ,fiyat='" + textBox3.Text + "' where no='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'");

            SqlCommand komut = new SqlCommand(kayit, baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.DataSource = da;

            doldur();
            MessageBox.Show("Kayıt güncellendi.");

        }
        private void say()
        {
            string kayit = "Select count(*) From emlakekleme";


            baglanti.Open();
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            dataGridView1.DataSource = da;
            string okunan = komut.ExecuteScalar().ToString();
            baglanti.Close();
            MessageBox.Show("Toplam kayıt sayısı :" + okunan);

        }


        private void button5_Click(object sender, EventArgs e)
        {
            ekle();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Zambak Sitesi")
            {
                button1.BackColor = Color.Pink;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;

            }
            if (comboBox1.Text == "Orkide Sitesi")
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.Pink;
                button4.BackColor = Color.White;

            }
            if (comboBox1.Text == "Papatya Sitesi")
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.Pink;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;

            }
            if (comboBox1.Text == "Menekşe Sitesi")
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.Pink;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            doldur();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            evdurumu = "Satılık Ev";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            evdurumu = "Kiralık Ev";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
             
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            evdurumu = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            say();
        }
    }
}
