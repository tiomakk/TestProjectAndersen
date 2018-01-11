using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class ProgramRepository : IRepository<Program>
    {
        public Task<IEnumerable<Program>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Program> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Program>> FindAsync(Func<Program, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Program item)
        {
            throw new NotImplementedException();
        }

        public void Update(Program item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
