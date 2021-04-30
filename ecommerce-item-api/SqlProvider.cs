using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_api
{
    public class SqlProvider 
    {
        public SqlProvider()
        {

        }
        public string Get()
        {

            var str = String.Empty;
            using (var conn = new SqlConnection("Server=Ecommerce-db;Database=Test;User Id=sa;Password=Password1!;"))
            using (var cmd = new SqlCommand(@"Select Test
                                            from Test"
                                            , conn))
            {
                conn.Open();
                
                var reader = cmd.ExecuteReader();
                while (reader.Read()){
                    str = reader["Test"].ToString();
                };


                    
            }
            return str;
        }

        
    }
}
