using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            XmlReader xmlReader = XmlReader.Create("http://localhost:8733/SyndicationService/Feed1/");
            SyndicationFeed feed = SyndicationFeed.Load(xmlReader);
            foreach (SyndicationItem item in feed.Items)
            {
                result += item.Title.Text + "\n";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
