using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DOTNET
{
    internal class Class2
    {
        
        public static void overflow()
        {
            double pi = 3.14;
            {
                byte a = 1;
                {
                    Console.WriteLine(a);
                    //Console.WriteLine(b);
                    byte b = 2;
                    {
                        Console.WriteLine(b);
                        Console.WriteLine(a);
                        //Console.WriteLine(name);
                        byte c = 3;
                        var number = 45;
                        var number1 = 45;
                        String name = "c#";
                        Console.WriteLine(c);
                        Console.WriteLine(b);
                        Console.WriteLine(a);
                        Console.WriteLine(name);
                        Console.WriteLine(number );
                        Console.WriteLine(name, number);

                    }
                }
            }
         
            Console.WriteLine(pi);
   
            //Console.WriteLine(name, number);
        }

    }
}
