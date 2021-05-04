using System.Data.SqlClient;

namespace ecommerce_cart_api.Controllers
{
    public class OrderSqlProvider : SqlProvider, ISqlProvider<Order>
    {
        public OrderSqlProvider(string connectionString) : base(connectionString) { }

        public void Insert(Order order)
        {
            var query = $@"INSERT INTO [dbo].[Cart]         
                          VALUES
                          (@UserId
                          ,@C8
                          ,@Quantity
                          ,@Date)";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);
            connection.Open();

            command.Parameters.AddWithValue("@UserId", order.User.ToString());
            command.Parameters.AddWithValue("@C8", order.C8);
            command.Parameters.AddWithValue("@Quantity", order.Quantity.ToString());
            command.Parameters.AddWithValue("@Date", order.Date);

            command.ExecuteNonQuery();
        }




    }

}
