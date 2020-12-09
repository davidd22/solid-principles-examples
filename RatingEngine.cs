namespace OopPrinciple
{
    public class RatingEngine
    {
        public readonly ILoger Loger;
        public readonly IPolicySource PolicySource;
        public readonly IPolicySerializer PolicySerializer;
        public int Rating { get; private set; }

        /// <summary>
        /// dependency constructor injection
        /// </summary>
        /// <param name="loger"></param>
        /// <param name="policySource"></param>
        /// <param name="policySerializer"></param>
        public RatingEngine(ILoger loger, IPolicySource policySource, IPolicySerializer policySerializer)
        {
            Loger = loger;
            PolicySource = policySource;
            PolicySerializer = policySerializer;
        }

        public void Rate()
        {
            Loger.Log($"Start {nameof(RatingEngine.Rate)}");

            string policySource = PolicySource.GetPolicyFromSource();

            var policy = PolicySerializer.GetPolicyFromString(policySource);

            AbsRater rater = new RaterFactory().Create(policy, this);
            Rating = rater.Rate(policy);

            Loger.Log($"End {nameof(RatingEngine.Rate)}");
        }
    }
}
