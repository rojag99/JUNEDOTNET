using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class M1
    {
        public static void message1(string names)
        {
            Console.WriteLine("given name is " + names);
        }
        public static void message1(string names, int age)
        {
            Console.WriteLine("given name and age is " + names  +" and " +age);
        }
        public static void power(int n)
        {
            if (n != 0)
            {
                int p = n;
                Console.WriteLine(p);

            }
            
        }
    }
           
   
}
