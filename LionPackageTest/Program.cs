using LeansoftX.Lion.Client;
using System;

namespace LionPackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lion Test!");
            var lionClient = new LionClient();
            var result = lionClient.BoolVariation("true");
            Console.WriteLine("Feature Flag Status:" + result.ToString());
            Console.ReadLine();
        }
    }
}
