using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class ClassIV
    {
        int eno = 231; //instance variable
        static string ename = "dotnet"; //static variable
        ClassIV c5 = new ClassIV();
        public void show()
        {
            Console.WriteLine(eno);
            Console.WriteLine(ename);
            display();
            add1(20, 4);

        }
        public static void display()
        {
            //static method cannot accept IM's directly
            //Console.WriteLine(c5.eno);
            Console.WriteLine(ename);
        }
        public static int add1(int a, int b)
        {
            Console.WriteLine("addition of  " + a +" and " + b + " is " + a + b);
            return a + b;
        }
    }
}
