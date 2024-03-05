using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFhost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Lab_5.WCFSiplex)))
            {
                host.Open();
                //host.AddServiceEndpoint();
                Console.WriteLine("Хост службы запущен. Нажмите Enter для завершения.");
                Console.ReadLine();
            }
        }
    }
}
