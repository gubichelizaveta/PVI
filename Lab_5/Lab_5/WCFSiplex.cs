using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lab_5
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class WCFSiplex : IWCFSiplex
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string Concat(string s, double d)
        {
            return s + d;
        }

        public A Sum(A a1, A a2)
        {
            A a = new A();

            a.s = a1.s + a2.s;
            a.k = a1.k + a2.k;
            a.f = a1.f + a2.f;
            return a;
        }
    }
}
