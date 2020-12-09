using Microsoft.Extensions.Caching.Distributed;
using System.IO;

namespace OopPrinciple
{
    public class DistributedCachePolicySource : IPolicySource
    {
        private readonly string _key;
        private readonly IDistributedCache _distributedCache;
        public DistributedCachePolicySource(string key, IDistributedCache distributedCache)
        {
            _key = key;
            _distributedCache = distributedCache;
        }

        public string GetPolicyFromSource()
        {
            try
            {
                return _distributedCache.GetString(_key);
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
