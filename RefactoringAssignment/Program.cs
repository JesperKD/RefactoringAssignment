using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringAssignment
{
    class Program
    {
        static void Main()
        {
            IPAddress[] array = Dns.GetHostAddresses("en.wikipedia.org");
            foreach (IPAddress ip in array)
            {
                Console.WriteLine(ip.ToString());
            }

            Pinging.LocalPing();
            Console.WriteLine("start");
            string t = GetHost.GetHostnameFromIp("8.8.8.8");
            Console.WriteLine(t);
            Console.WriteLine("slut");
            string adr = GetIP.GetIpFromHostname(t);
            Console.WriteLine("Weee " + adr);

            string a = Trace.Traceroute("8.8.8.8");
            Console.WriteLine("route*** " + a);

            DisplayDhcp.DisplayDhcpServerAddresses();
            
            Console.ReadKey();
            //WIN-M69SG2Q0732.test.local
            //ZBC-RG01203MKC
            string hostName = "ZBC-RG01203MKC";
            IPHostEntry hostInfo = Dns.GetHostEntry(hostName);
            // Get the IP address list that resolves to the host names contained in the 
            // Alias property.
            IPAddress[] address = hostInfo.AddressList;
            // Get the alias names of the addresses in the IP address list.
            String[] alias = hostInfo.Aliases;

            Console.WriteLine("Host name : " + hostInfo.HostName);
            Console.WriteLine("\nAliases : ");
            for (int index = 0; index < alias.Length; index++)
            {
                Console.WriteLine(alias[index]);
            }
            Console.WriteLine("\nIP address list : ");
            for (int index = 0; index < address.Length; index++)
            {
                Console.WriteLine(address[index]);
            }
            Console.ReadKey();

        }
    }
}
