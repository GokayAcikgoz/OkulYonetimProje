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

namespace OkulYonetimProje
{
    public partial class frmDers : Form
    {
        public frmDers()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void frmDers_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =ds.DersListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.DersEkle(textBox2.Text);
            MessageBox.Show("Ders Eklendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(textBox2.Text, byte.Parse(textBox1.Text));
            MessageBox.Show("Ders Güncellendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(textBox1.Text));
            MessageBox.Show("Ders Silindi.");
        }
    }
}
