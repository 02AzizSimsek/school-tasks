using System;

namespace Nesne
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(new BenimStringim("FrontEndDeveloper"));
            test.TestEt();
            Console.ReadKey();
        }
    }
}