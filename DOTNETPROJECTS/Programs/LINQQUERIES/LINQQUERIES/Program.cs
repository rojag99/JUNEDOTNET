using System.Collections.Generic;

namespace LINQQUERIES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //query syntax
            String[] s = { "a", "b", "c", "d" };
            var check = from ch in s
                            //check is of type  IEnumerable<string>       
                        where ch.Contains("c")
                        select ch;
            //Console.WriteLine(check); ==>System.Linq.Enumerable+WhereArrayIterator`1[System.String]
            foreach (var item in check)
            {
                Console.WriteLine(item);
                
            }
            var fil = s.Where(a => a.Contains("a"));
            Console.WriteLine(fil);
            IList<string> stringList = new List<string>()
            { "a", "b", "c", "d"};

            var result = from sl in stringList
                         where sl.Contains("d")
                         select $"the result is {sl}";

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            //method syntax
            IList<string> my_list = new List<string>
                { "a", "b", "c", "d" };
            var res = my_list.Where(a => a.Contains("b"));
            //Console.WriteLine(res);   ==> System.Linq.Enumerable+WhereListIterator`1[System.String]
            foreach (var item1 in res)
            {
                Console.WriteLine(item1);
            }
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 6 };

            IEnumerable<int> sco = from scor in numbers
                                   where scor > 2
                                   orderby scor descending
                                   select scor;
            foreach(int i in sco)
            {
                Console.WriteLine("num:",i);
            }
            //Console.WriteLine(sco);
            int sscoress = (
                                         from scor in numbers
                                         where scor > 2
                                         orderby scor descending
                                         select scor
                                         ).Count();

            Console.WriteLine($"Count of numbers greater than 2: {sscoress}");

            IEnumerable<int> sc = numbers.Where(ab => ab> 2).OrderByDescending(ab => ab);
           foreach(int n in sc)
            {
                Console.WriteLine(n);
            }
            

            var scores = new List<int>() { 7, 5, 4, 3, 8, 5 };

            var result4 =
                from score in scores
                where score > 5
                select score;

            foreach (var r in result4)
            {
                Console.WriteLine("Score: {0}", r);
            }


        }
    }
}
