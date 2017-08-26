using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace WebApplication1
{
    public class RepoDap
    {
        readonly SqlConnection conn;
        public RepoDap()
        {

            conn = new SqlConnection();
        }
        public IEnumerable<t> getData()
        {
            using (var db = new SqlConnection("server=localhost;database=test;Trusted_Connection=True; "))
            {
                db.Open();
                var result = db.Query<t>( "select id, data from t", commandType: System.Data.CommandType.Text );
                return result;

            }
        }
        
    }
}
