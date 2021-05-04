

namespace ecommerce_item_api.Controllers
{
    public abstract class SqlProvider
    {
        protected readonly string _connectionString;

        protected SqlProvider(string connectionString)=> _connectionString = connectionString;
        
    }
}
