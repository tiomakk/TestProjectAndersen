using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;

namespace TestProjectAndersen.DAL.Interfaces
{
    public interface IProgramRepository: IRepository<Program>
    {
        Task<Program> GetAsync(string name);
    }
}
