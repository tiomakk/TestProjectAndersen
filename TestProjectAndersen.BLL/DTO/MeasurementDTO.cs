using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.BLL.DTO
{
    class MeasurementDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime MeasuredAt { get; set; }
    }
}
