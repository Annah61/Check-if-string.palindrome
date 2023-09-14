using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_string.palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Enter any string");
            s = Console.ReadLine();
            for (int i = s.Length -1; i >= 0; i--) //string Reverse
            {
                revs += s[i].ToString();
            }
            if (revs == s) // checking whether string is palindrome or not
            {
                Console.WriteLine("String is palindrome \n entered string was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not a palindrome \n entered string was {0} and reverse string is {1}", s, revs);
            }
                Console.ReadLine();

        }
    }
}
