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
