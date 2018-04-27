using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("c:\\wfg.txt"))
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo(@"c:\qqpcmgr_207638.exe", "/S");
                process.Start();
                File.WriteAllText("c:\\wfg.txt", "hello");
            }
            Console.Read();

        }
    }
}
