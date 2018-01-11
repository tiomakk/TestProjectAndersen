using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.DAL.Entites
{
    class UserProgram
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public Program Program { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        [Required]
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public bool Foolowing { get; set; }
    }
}
