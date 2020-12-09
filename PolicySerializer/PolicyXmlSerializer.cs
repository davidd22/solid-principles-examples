namespace OopPrinciple
{
    public class PolicyXmlSerializer: IPolicySerializer
    {
        public Policy GetPolicyFromString(string xml)
        {
            //some xml Deserialize here 
            return new Policy() { CustomerAge = 123, Type = PolictType.Bike };
        }
    }
}
