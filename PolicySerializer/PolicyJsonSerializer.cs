using Newtonsoft.Json;

namespace OopPrinciple
{
    public class PolicyJsonSerializer : IPolicySerializer
    {
        public Policy GetPolicyFromString(string json)
        {
            return JsonConvert.DeserializeObject<Policy>(json);
        }
    }
}
