using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrinciple
{
    public class AutoPolicyRater : AbsRater
    {
        public AutoPolicyRater(RatingEngine engine) : base(engine)
        {

        }

        public override int Rate(Policy policy)
        {
            var result = 0;
            _engine.Loger.Log($"Start {nameof(AutoPolicyRater.Rate)}");

            if (policy.CustomerAge > 40)
            {
                result = 123;
            }

            _engine.Loger.Log($"End {nameof(AutoPolicyRater.Rate)}");

            return result;
        }
    }
}
