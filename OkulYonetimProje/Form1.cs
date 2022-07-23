using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulYonetimProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar frmOgrenciNotlar = new FrmOgrenciNotlar();

            frmOgrenciNotlar.numara = textBox1.Text;
            frmOgrenciNotlar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgretmen frmOgretmen = new FrmOgretmen();
            frmOgretmen.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
