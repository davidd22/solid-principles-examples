namespace OopPrinciple
{
    public class LandPolicyRater : AbsRater
    {

        public LandPolicyRater(RatingEngine engine) : base(engine)
        {

        }

        public override int Rate(Policy policy)
        {
            var result = 0;

            _engine.Loger.Log($"Start {nameof(LandPolicyRater.Rate)}");

            if (policy.CustomerAge > 10)
            {
                result = 120;
            }

            _engine.Loger.Log($"End {nameof(LandPolicyRater.Rate)}");
            return result;
        }
    }
}
