using LeansoftX.Lion.Client;
using System;

namespace LionPackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lion Test!");
            var lionClient = new LionClient("sdk-1fbfa9ca-7bd8-4a42-a328-05d8f924aa60");
            var result = lionClient.BoolVariation("labs");
            Console.WriteLine("Feature Flag Status:" + result.ToString());
            Console.ReadLine();
        }
    }
}
