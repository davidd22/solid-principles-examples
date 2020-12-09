using System;
using System.Collections.Generic;
using System.Text;

namespace OopPrinciple
{
    /// <summary>
    /// will create a rater based on input
    /// </summary>
    public class RaterFactory
    {
        public AbsRater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (AbsRater)Activator.CreateInstance(
                                        Type.GetType($"OopPrinciple.{policy.Type}PolicyRater")
                                        , new object[] { engine });
            }
            catch (Exception ex)
            {
                return new UnknownPolicyRater(engine);
            }
        }
    }
}
