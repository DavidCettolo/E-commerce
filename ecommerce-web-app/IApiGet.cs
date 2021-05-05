using System.Collections.Generic;

namespace ecommerce_web_app
{
    public interface IApiGet<T>
    {
        IEnumerable<T> GetApi(string url);
    }
}
