using System.Data;
using System.Data.SqlClient;
namespace Hastatakipsistemi
{
    internal class frmSqlBağlantı
    {
        // SQL Server 2022 connection string
        private readonly string adres =
            @"Data Source=DESKTOP-A8RG0A1\SQLEXPRESS;
              Initial Catalog=db_hastaneyönetim;
              Integrated Security=True;
              TrustServerCertificate=True;";
        public SqlConnection baglan()
        {
            SqlConnection con = new SqlConnection(adres);

            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
    }
}
        
    

