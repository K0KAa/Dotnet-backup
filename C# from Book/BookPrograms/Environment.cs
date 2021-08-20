using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Book
{
    class Program
    {
        static void Main2(String[] args)
        {
            //Display a simple msg
            Console.WriteLine("***MY c# app****");
            Console.WriteLine("HEllo");
            Console.WriteLine();

            // Get arguments using System.Environment.
            ShowComputerDetails();

            Console.ReadLine();

        }

        static void ShowComputerDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            Console.WriteLine("Drive:{0}", drive);
            Console.WriteLine("OS version: {0},Environment.OSVersion");
            Console.WriteLine(".NET verion:{0}", Environment.Version);
            Console.WriteLine("Number of ProcessorCount:{0}", Environment.ProcessorCount);
            Console.WriteLine("Machine Name:{0}", Environment.MachineName);
        }
    }


}