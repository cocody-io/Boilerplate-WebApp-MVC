using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Infrastructure.Cache
{
    public interface ICacheManager
    {
        T Resolve<T>(string cacheKey, Func<T> createCacheFn) where T : class;
    }
}
