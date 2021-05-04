
namespace ecommerce_cart_api.Controllers
{
    public interface ISqlProvider<T>
    {
        void Insert(T entity);

    }
}
