using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web; 

namespace deneme
{
    public class sqlbaglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=mobilyaci;Integrated Security=True;");
            baglanti.Open();

            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();

            return (baglanti);

        }
    }
}