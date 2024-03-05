using lr7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Feed1));
            host.Open();
            Console.WriteLine($"host open");
            Console.ReadLine();
            host.Close();
        }
    }
}
