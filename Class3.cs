using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    internal class Class3
    {
        public static void operatprs()
        {
            var a = 10;
            var b = 3;
            int c=a+b;
            Console.WriteLine(a < b);
            Console.WriteLine(!(a != b));
            Console.WriteLine(a != b);
            Console.WriteLine(a=b);
            Console.WriteLine(c);
            Console.WriteLine("Logical AND",a > b && b < c);
            Console.WriteLine("Logical OR", a < b || b > c);

        }
    }
}
