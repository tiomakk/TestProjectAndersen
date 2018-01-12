using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.BLL.DTO
{
    class ParsedProgramDTO
    {
        public int UserId { get; set; } //TODO Поменять long на int в сущностях 
        public bool IsFollowed { get; set; }
        public string Name { get; set; }
        public DateTime StartedAt { get; set; }
    }

}
