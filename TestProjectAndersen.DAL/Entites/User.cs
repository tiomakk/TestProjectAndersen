using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.DAL.Entites
{
    public enum GenderType
    {
        Male = 0,
        Female
    }

    class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderType Gender { get; set; }

        public IEnumerable<UserProgram> UserPrograms { get; set; }

        public User()
        {
            UserPrograms = new List<UserProgram>();
        }
    }
}
