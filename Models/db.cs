//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Configuration;
//using System.Data.SqlClient;
//using System.Data;

//namespace TextAreaMessageToPdf.Models
//{
//    public class db
//    {
//        SqlConnection con = new SqlConnection("Data Source=LAPTOP-3LO55SM4\\SQLEXPRESS; User ID=asbin;Password=4061;Initial Catalog=MarketRiskNew;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

//            public DataTable Getrecord()
//        {
//            SqlCommand con = new SqlCommand("select  * from MarketRiskNew.MarketRisk.Currency
//", con );
//            SqlDataAdapter da = new SqlDataAdapter(con);
//            DataTable dt = new DataTable();
//            da.Fill(dt);
//            return dt;

//        }

//    }
//}
