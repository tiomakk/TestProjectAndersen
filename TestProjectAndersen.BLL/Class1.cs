using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.BLL.Implementations;

namespace TestProjectAndersen.BLL
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            using (var file = File.Open(@"C:\Users\TiomaK\Desktop\Проект Андерсен\User_Metric_Values.xlsx", FileMode.Open))
            {
                var parser = new ExcelFileParser();

                var parsedPrograms = parser.ParseMeasurements(file);

                var take5 = parsedPrograms.Take(5);

                foreach (var program in parsedPrograms.Take(1000))
                    Console.WriteLine($"{program.Name.PadRight(30)}\t{program.Value.PadRight(20)}\t{program.MeasuredAt}");
                Console.ReadKey();
            }
        }
    }
}
