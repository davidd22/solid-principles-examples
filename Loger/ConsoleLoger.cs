using System;

namespace OopPrinciple
{
    public class ConsoleLoger : ILoger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
