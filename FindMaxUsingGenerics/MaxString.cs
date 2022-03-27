using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxString
    {
        public string Maxstring(string First_str, string Seccond_str, string Third_str)
        {
            Console.WriteLine("Three Strings are : str1 = {0} , str2 = {1} , str3 = {2} ", First_str, Seccond_str, Third_str);
            if (First_str.CompareTo(Seccond_str) > 0 && First_str.CompareTo(Third_str) > 0)
            {
                Console.Write("Maximum String Is:");
                return First_str;
            }
            else if (Seccond_str.CompareTo(First_str) > 0 && Seccond_str.CompareTo(Third_str) > 0)
            {
                Console.Write("Maximum String Is:");
                return Seccond_str;
            }
            else if (Third_str.CompareTo(First_str) > 0 && Third_str.CompareTo(Seccond_str) > 0)
            {
                Console.Write("Maximum String Is:");
                return Third_str;
            }
            else
            {
                Console.Write("All string are equal");
            }
            return null;
        }

    }
}
