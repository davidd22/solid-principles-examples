namespace OopPrinciple
{
    public class LifePolicyRater : AbsRater
    {

        public LifePolicyRater(RatingEngine engine) : base(engine)
        {
        }

        public override int Rate(Policy policy)
        {
            var result = 0;
            _engine.Loger.Log($"Start {nameof(LifePolicyRater.Rate)}");

            if (policy.CustomerAge > 20)
            {
                result = 500;
            }

            _engine.Loger.Log($"End {nameof(LifePolicyRater.Rate)}");

            return result;
        }
    }
}
