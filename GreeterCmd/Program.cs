using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length==1)
            {
                var greeter = new Greeter(args[0]);
                Console.WriteLine(greeter.SayHello());
                Console.WriteLine(greeter.SayGoodBye());
            }
            else
            {
                Console.WriteLine($"Parameter falsch.");
            }
        }
    }
}
