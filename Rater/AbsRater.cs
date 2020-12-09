namespace OopPrinciple
{
    public abstract class AbsRater
    {
        protected readonly RatingEngine _engine;

        protected AbsRater(RatingEngine engine)
        {
            _engine = engine;
        }

        public abstract int Rate(Policy policy);
    }
}
