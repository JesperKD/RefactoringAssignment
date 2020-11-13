using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringAssignment
{
    public static class DisplayDhcp
    {
        public static void DisplayDhcpServerAddresses()
        {
            Console.WriteLine("DHCP Servers");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapteradapterProperties = adapter.GetIPProperties();
                IPAddressCollection addresses = adapteradapterProperties.DhcpServerAddresses;
                if (addresses.Count > 0)
                {
                    Console.WriteLine(adapter.Description);
                    foreach (IPAddress address in addresses)
                    {
                        Console.WriteLine("  Dhcp Address ............................ : {0}", address.ToString());
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
