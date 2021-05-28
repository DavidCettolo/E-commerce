using System.Collections.Generic;
using System.Threading.Tasks;

namespace ecommerce_web_app
{
    public interface IApiGet<T> 
    {
        Task<IEnumerable<T>> GetApiAsync(string url);
    }
}
