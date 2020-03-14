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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        
        SqlDataReader dr;
        private void ekle()
        {
            baglanti.Open();
            string kayit = "insert into kullanicilar(email,kullaniciadi,parola) Values (@email,@kullaniciadi,@parola)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@email", bunifuMetroTextbox1.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", bunifuMetroTextbox2.Text);
            komut.Parameters.AddWithValue("@parola", bunifuMetroTextbox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız başarıyla oluşturuldu.Şimdi giriş yapınız.");

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ekle();
        }
    }
}
