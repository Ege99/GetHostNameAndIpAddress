using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace GetHostNameAndIpAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string HostName = Dns.GetHostName();
            Console.WriteLine("Cihazin Host Adi : " + HostName);
            IPAddress[] ipadress = Dns.GetHostAddresses(HostName);
            Console.WriteLine("Cihazin IP Adresi : " +
                "   Ilk Satir IPV6,   Ikinci Satir IPV4 icindir.");
            foreach (IPAddress ip in ipadress)
            {
                Console.WriteLine(ip.ToString());
            }
            Console.ReadLine();
        }
    }
}
