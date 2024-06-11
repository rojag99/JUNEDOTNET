using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOTNET
{
    internal class Program
    {
        private static object ic;

        static void Main(string[] args)
        {
            
            Instancecheck instancecheck = new Instancecheck();
            ClassIV c5 = new ClassIV();
            instancecheck.in1();
            M1.message1("computer-----1");
            M1.message1("computer-----2");
            M1.message1("computer-----3");
            M1.message1("computer-----4",32);
            M1.power(4);
            Array1.arr1();
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("KE54658578JM");
            string nm = "sdjasdmsdg";
            Console.WriteLine(nm.ToLower());
            Console.WriteLine(nm.Contains("sdm"));
            Class1.p();
            Class2.overflow();
            Class3.operatprs();
            Class4.userdata();

            
        }
    }
    internal class Instancecheck
    {
        
        public  void in1()
        {
            Console.WriteLine("FROM INSTANCE");

        }
    }

}
