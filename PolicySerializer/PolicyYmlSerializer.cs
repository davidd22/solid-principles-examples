namespace OopPrinciple
{
    public class PolicyYmlSerializer : IPolicySerializer
    {
        public Policy GetPolicyFromString(string yml)
        {
            //some yml Deserialize here 
            return new Policy() { CustomerAge = 123, Type = PolictType.Bike };
        }
    }
}
