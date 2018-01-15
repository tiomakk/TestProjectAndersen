using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.DAL.Entites
{
    public enum FrequencyType
    {
        Annual = 0,
        Semiannual,
        Quarterly,       
        Single
    }

    public class Metric
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public FrequencyType Frequency { get; set; }
        public IEnumerable<Program> Programs { get; set; }

        public Metric()
        {
            Programs = new List<Program>();
        }

    }
}
