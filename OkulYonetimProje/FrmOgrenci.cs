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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();

            Baglanti bgl = new Baglanti();

            SqlCommand komut = new SqlCommand("select * from Tbl_Kulupler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "kulupAd";
            comboBox1.ValueMember = "kulupId";
            comboBox1.DataSource = dt;
            bgl.baglanti().Close();


        }
        string cinsiyet = "";
        private void button2_Click(object sender, EventArgs e)
        {

            
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Kız";
            }
            if (radioButton2.Checked == true)
            {
                cinsiyet = "Erkek";
            }

            ds.OgrenciEkle(textBox2.Text, textBox3.Text,byte.Parse(comboBox1.SelectedValue.ToString()),cinsiyet);

            MessageBox.Show("Öğrenci Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(textBox2.Text, textBox3.Text,byte.Parse(comboBox1.Text) ,cinsiyet, int.Parse(textBox1.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cinsiyet = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            if (cinsiyet == "Kız")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            if (cinsiyet == "Erkek")
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ds.OgrenciGetir(textBox2.Text);
        }
    }
}
