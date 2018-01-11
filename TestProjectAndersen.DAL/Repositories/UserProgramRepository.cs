using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class UserProgramRepository : IRepository<UserProgram>
    {
        public Task<IEnumerable<UserProgram>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserProgram> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserProgram>> FindAsync(Func<UserProgram, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(UserProgram item)
        {
            throw new NotImplementedException();
        }

        public void Update(UserProgram item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
