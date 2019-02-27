using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] allprocesses = Process.GetProcesses();
            foreach (Process theprocess in allprocesses) {
                Console.WriteLine("Process:{0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            Console.ReadKey();
        }
    }
}
