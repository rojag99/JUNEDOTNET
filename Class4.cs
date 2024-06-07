using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class Class4
    {
        public static void userdata()
        {
            string name;
            long phn;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("the entered name is    " + name.ToUpper());
            Console.WriteLine("enter mobile number");
            //phn = long.Parse(Console.ReadLine());
            phn = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("the entered mobile number is    " + phn);
            Console.WriteLine("enter the code");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the entered code is," + c);
            //Console.WriteLine("enter a number");
            //double d = Convert.ToDouble(Console.ReadLine());



        }
    }
}
