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
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(TxtId.Text));

        }
        Baglanti bgl = new Baglanti();
        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Dersler", bgl.baglanti());
            da.Fill(dt);
            cmbDersler.DisplayMember = "dersAd";
            cmbDersler.ValueMember = "dersId";
            cmbDersler.DataSource = dt;
            
        }
        int notid;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            notid = int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            TxtId.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSınav1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSınav2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSınav3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtOrt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        string durum;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            sinav1 = Convert.ToInt16(TxtSınav1.Text);
            sinav2 = Convert.ToInt16(TxtSınav2.Text);
            sinav3 = Convert.ToInt16(TxtSınav3.Text);
            proje = Convert.ToInt16(TxtProje.Text);

            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4.00;

            TxtOrt.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDersler.SelectedValue.ToString()),int.Parse(TxtId.Text),byte.Parse(sinav1.ToString()), byte.Parse(sinav2.ToString()), byte.Parse(sinav3.ToString()), byte.Parse(proje.ToString()), decimal.Parse(ortalama.ToString()), bool.Parse(TxtDurum.Text), 
                notid);
        }
    }
}
