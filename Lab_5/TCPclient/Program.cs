using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TCPclient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WCFSiplexTCP.WCFSiplexClient("NetTcpBinding_IWCFSiplex"))
            {
                // Вызовите методы службы
                Console.WriteLine("TCP Client - Add: " + client.Add(7, 8));
                Console.WriteLine("TCP Client - Concat: " + client.Concat("str", 77.99));

                WCFSiplexTCP.A a1 = new WCFSiplexTCP.A { s = "qqq", k = 11, f = 4.22f };
                WCFSiplexTCP.A a2 = new WCFSiplexTCP.A { s = "sss", k = 33, f = 5.33f };
                WCFSiplexTCP.A result = client.Sum(a1, a2);
                Console.WriteLine("TCP Client - Sum: " + $"s: {result.s}, k: {result.k}, f: {result.f}");

                Console.WriteLine("Нажмите Enter для завершения.");
                Console.ReadLine();
            }
        }
    }
}
