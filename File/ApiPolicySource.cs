using System.IO;

namespace OopPrinciple
{
    public class ApiPolicySource : IPolicySource
    {
        private readonly string _url;

        public ApiPolicySource(string url)
        {
            _url = url;
        }

        public string GetPolicyFromSource()
        {
            return "somehttpcall";
        }
    }
}
