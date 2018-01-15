using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.DAL.Entites
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Metric> Metrics { get; set; }
        public IEnumerable<UserProgram> UserPrograms { get; set; }


        public Program()
        {
            Metrics = new List<Metric>();
            UserPrograms = new List<UserProgram>();
        }
    }
}
