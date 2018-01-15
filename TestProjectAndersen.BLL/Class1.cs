using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.BLL.Implementations;
using TestProjectAndersen.BLL.Services;
using TestProjectAndersen.DAL;
using TestProjectAndersen.DAL.Entites;

namespace TestProjectAndersen.BLL
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            using (var file = File.Open(@"C:\Users\TiomaK\Desktop\Проект Андерсен\User_Programm.xlsx", FileMode.Open))
            using(var service = new FileService(new EFUnitOfWork("DefaultConnection"), new ExcelFileParser()))
            {
                //var parser = new ExcelFileParser();

                //var parsedPrograms = parser.ParsePrograms(file);
                //var service = new FileService();

                //var normalizedPrograms = service.Normalize(parsedPrograms);

                //int i = 0;
                //foreach (var program in normalizedPrograms)
                //{
                //    Console.WriteLine($"{i++:D4})\t{program.UserId}\t{program.StartedAt:G}\t{program.Name.PadRight(20)}\t{program.IsFollowed}");
                //}


                 service.UpdateProgramsAsync(file).Wait();

            }

            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }

    class Abc
    {
        public int Id { get; set; }
        public IEnumerable<string> Strings { get; set; }
    }
}
