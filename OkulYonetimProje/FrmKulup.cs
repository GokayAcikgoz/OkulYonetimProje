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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kulupler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kulupler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kulupler(kulupAd) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kulup Ekledi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Kulupler set kulupAd = @d1 where kulupId = @d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBox2.Text);
            komut.Parameters.AddWithValue("@d2", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kulup Güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Kulupler where kulupId = @d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kulup Silindi");
        }
    }
}
