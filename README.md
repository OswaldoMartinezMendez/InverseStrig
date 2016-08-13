# InverseStrig

Se crea el algoritmo para invertir el orden de los caracteres de un string pasado como parametro.
Se crea una clase adicional para desaclopar la funcionalidad, así:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvertString
{
    public class StringHelper
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}


Posteriormente en el metodo Main() de la clase principal de la consola Program.cs
se adiciona el llamado, así:

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
    
