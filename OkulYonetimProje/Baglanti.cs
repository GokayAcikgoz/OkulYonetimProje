using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OkulYonetimProje
{
    internal class Baglanti
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=GOKAY\\SQLEXPRESS;Initial Catalog=OkulYonetim;Integrated Security=True");

            baglanti.Open();
            return baglanti;
        }

    }
}
