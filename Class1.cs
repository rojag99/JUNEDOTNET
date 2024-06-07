using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET
{
    public static class Class1
    {
        public static void p()
        { 
        int i = 2 + 4;
            byte b = 1;
            int j = b;
            float f = 1.0f;
            int k = (int)f;
            string s = "roja";
           // int n = int.Parse(s);
            //int st = Convert.ToInt32(s);
                Console.WriteLine(j);
            Console.WriteLine("using typecast operator",k);
           // Console.WriteLine(st);
    }
    }
}