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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

       
        SqlConnection baglanti = new SqlConnection("Data Source=GOKAY\\SQLEXPRESS;Initial Catalog=OkulYonetim;Integrated Security=True");

        public string numara;

       
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select (ogrenciAd +' ' + ogrenciSoyad),dersAd,sınav1, sınav2, sınav3, ortalama, durum from Tbl_Notlar " +
                "inner join Tbl_Dersler on Tbl_Dersler.dersId = Tbl_Notlar.dersId  inner join Tbl_Ogrenciler on Tbl_Notlar.ogrenciId = Tbl_Ogrenciler.ogrenciId where Tbl_Ogrenciler.ogrenciId =@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);

           
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select (ogrenciAd + ' ' + ogrenciSoyad) from Tbl_Ogrenciler where ogrenciId = @p1",baglanti);
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString();
            }
            baglanti.Close();


            
        }
    }
}
