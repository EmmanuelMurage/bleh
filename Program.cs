using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Win32;
using System.Net.NetworkInformation;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] allprocesses = Process.GetProcesses(); //iterate through processes
            foreach (Process theprocess in allprocesses) {
                Console.WriteLine("Process:{0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            
          string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
if (key != null)
{
    foreach (String a in key.GetSubKeyNames())
    {
        RegistryKey subkey = key.OpenSubKey(a);
        Console.WriteLine(subkey.GetValue("DisplayName"));
    }
}

            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces
                = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface ni in interfaces)
            {
                Console.WriteLine("    Bytes Sent: {0}",
                    ni.GetIPv4Statistics().BytesSent);
                Console.WriteLine("    Bytes Received: {0}",
                    ni.GetIPv4Statistics().BytesReceived);
            }



            Console.ReadKey();
        }

    }


}
    



     
        