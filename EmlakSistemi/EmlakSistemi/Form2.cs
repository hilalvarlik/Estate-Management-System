using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form4 emlakekleme = new Form4();
            emlakekleme.Show();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form7 evbilgileri = new Form7();
            evbilgileri.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form5 emlaksorgulama = new Form5();
            emlaksorgulama.Show();
        }
    }
}