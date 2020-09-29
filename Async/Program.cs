using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
namespace Async
{
    class Program
    {
        static void Main( )
        {
            //Making breakfast

            //Make Tea
            // - Turn on burner(2s)
            // - Place Kettle on burner(3s)  
            // - Pour water(5s)
            // - Let it boil(5min)
            // - Grind masalas(1min)
            // - Put sugar and masalas(5s)
            // - Pour milk(5s)
            // - Let it boil(3min)

            // - Turn on burner(2s)
            // - Put pan on and oil it(30)
            // - Crack eggs and whisk it(3 min)
            // - Fry(3min)

           HttpClient client = new HttpClient();
            Stopwatch stopwatch = Stopwatch.StartNew();
            var google = client.GetStringAsync("google.com").Result;
            var microsoft = client.GetStringAsync("microsoft.com").Result;
            var yahoo = client.GetStringAsync("yahoo.com").Result;
            Console.WriteLine($"It took{stopwatch.ElapsedMilliseconds} ms");
 
           
           stopwatch.Restart();
           var G = client.GetStringAsync("google.com");
            var M = client.GetStringAsync("microsoft.com");
            var Y = client.GetStringAsync("yahoo.com");
            Console.WriteLine($"It took{stopwatch.ElapsedMilliseconds} ms");

        }      
    }
}
