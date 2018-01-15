using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.DAL.Entites
{
    public class MetricMeasurement
    {
        public long Id { get; set; }
        [Required]
        public string Value { get; set; }

        public DateTime Date { get; set; }

        public int MetricId { get; set; }
        public Metric Metric { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
