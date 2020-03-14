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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form3 girisyap = new Form3();
            girisyap.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form6 kaydol = new Form6();
            kaydol.Show();
        }
    }
}
