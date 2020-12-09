using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace OopPrinciple
{
    /// <summary>
    /// to add new policy add file called {PolicyName}PolicyRater.cs with inherent to AbsRater (reflection will handle the factory)
    /// </summary>
    class Program
    {
        static ServiceProvider serviceProvider;

        static void Main(string[] args)
        {

            IServiceCollection services = new ServiceCollection();
            serviceProvider = services.BuildServiceProvider();

            var redisService = serviceProvider.GetService<IDistributedCache>();

            var ratingEngine = new RatingEngine(new FileLoger(@"WriteText.txt")
                                                       , new DistributedCachePolicySource("policy", redisService)
                                                       , new PolicyYmlSerializer());


            var ratingEngine1 = new RatingEngine(new ConsoleLoger()
                                               , new DistributedCachePolicySource("policy", redisService)
                                               , new PolicyJsonSerializer()
                                  );

            var ratingEngine2 = new RatingEngine(new ConsoleLoger()
                                              , new FilePolicySource("policy.json")
                                              , new PolicyYmlSerializer());

            var ratingEngine3 = new RatingEngine(new ConsoleLoger()
                                               , new ApiPolicySource("http://someUrl.com")
                                               , new PolicyXmlSerializer());

            //calling public metohds

            ratingEngine.Rate();
            ratingEngine2.Rate();
            ratingEngine3.Rate();

        }
    }
}