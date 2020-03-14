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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=Emlak;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader dr;

       

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanicilar where kullaniciadi='" + bunifuMetroTextbox5.Text + "' AND parola='" + bunifuMetroTextbox4.Text + "'";
            dr = komut.ExecuteReader();

            if (bunifuMetroTextbox5.Text == "admin" && bunifuMetroTextbox4.Text == "adminadmin")
            {
                Form2 emlakkayit = new Form2();
                emlakkayit.Show();
            }
            else
            {
                if (dr.Read())
                {

                    Form9 emlaksorgula = new Form9();
                    emlaksorgula.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }
                baglanti.Close();
            }
        }
    }
}
