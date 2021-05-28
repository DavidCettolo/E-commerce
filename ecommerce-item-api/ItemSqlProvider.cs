using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ecommerce_item_api.Controllers
{
    public class ItemSqlProvider: SqlProvider,ISqlProvider<Item>
    {
        public ItemSqlProvider(string connectionString) : base(connectionString) { }

        public IEnumerable<Item> GetItems()
        {
            var query = $@"SELECT *
                           FROM Items";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                yield return new Item()
                {
                    C8 = reader["C8"].ToString(),
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"].ToString())
                };
               
            }
            

        }

        public void ReduceQuantity(string c8,string reduce)
        {
            var query = $@"UPDATE [dbo].[Items]
                           SET Quantity = Quantity - @remove
                           WHERE C8=@c8";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@c8", c8);
            command.Parameters.AddWithValue("@remove", reduce);

            command.ExecuteNonQuery();

        }

       
    }
}
