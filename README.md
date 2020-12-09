
   this is a small demo of an insurance policy rating engine 
   code should return a rating score based on the policy type 
   
   policy type can be fetched from a file, API call, or a local DB
   policy type can exist on JSON, XML, YML
   
   so the program should support all this without breaking the SOLID principles...
   
   examples:
   
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
   
   single responsibility: class will have only one responsibility and will have only one reason to change

   Open–closed principle: in this example, if u want to add a new Rater object, no need to edit and change existing code,
   just create your class and name it OopPrinciple.{policy.Type}PolicyRater.cs (reflection will handle the rest)
   
   Liskov substitution principle: Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program
   
   Interface segregation principle: all interfaces are fully implemented, if a class need to implement an interface all the interface methods
   will be in use inside that class
   
   Dependency inversion principle: avoid as much as needed from creating dependencies inside the class, all
   dependencies are initiated at the program starting point.
