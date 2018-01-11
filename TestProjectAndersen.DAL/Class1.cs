using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.DAL
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IEnumerable<int> abc = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };

            Console.WriteLine(String.Join(" ",abc.AsQueryable().Where(i => i % 2 == 0).ToList()));
            Console.ReadKey();
        }
       
    }
}
