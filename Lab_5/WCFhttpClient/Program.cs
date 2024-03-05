using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WCFhttpClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            using (var client = new WCFSiplexHttp.WCFSiplexClient("http"))
            {
                
                Console.WriteLine("HTTP Client - Add: " + client.Add(12, 21));
                Console.WriteLine("HTTP Client - Concat: " + client.Concat("qwerty", 88.55));

                Lab_5.A a1 = new Lab_5.A { s = "zxc", k = 55, f = 1.58f };
                Lab_5.A a2 = new Lab_5.A { s = "xxx", k = 75, f = 2.35f };
                Lab_5.A result = client.Sum(a1, a2);
                Console.WriteLine("HTTP Client - Sum: " + $"s: {result.s}, k: {result.k}, f: {result.f}");
                Console.WriteLine("Нажмите Enter для завершения.");
                Console.ReadLine();
            }
        }
    }
}
