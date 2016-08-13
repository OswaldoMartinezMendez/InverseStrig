using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace InvertString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input string:");
            string line = Console.ReadLine();
            if (line != null && line.Equals("exit"))
            {
                Environment.Exit(0);
            }
            Console.WriteLine(StringHelper.ReverseString(line));
            Console.ReadLine();
        }
    }
}
