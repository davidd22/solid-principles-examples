namespace OopPrinciple
{
    public class UnknownPolicyRater : AbsRater
    {

        public UnknownPolicyRater(RatingEngine engine) : base(engine)
        {
        }

        public override int Rate(Policy policy)
        {
            _engine.Loger.Log($"Start {nameof(UnknownPolicyRater.Rate)}");
            _engine.Loger.Log($"End {nameof(UnknownPolicyRater.Rate)}");

            return 0;
        }
    }
}
