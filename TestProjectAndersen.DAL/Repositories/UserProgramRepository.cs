using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.EF;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class UserProgramRepository : IUserProgramRepository
    {
        private readonly ApplicationContext _db;

        public UserProgramRepository(ApplicationContext context)
        {
            _db = context;
        }

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
            _db.UserPrograms.Add(item);
        }

        public void Update(UserProgram item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserProgram> GetActiveAsync(int userId)
        {
            return await _db.UserPrograms.FirstOrDefaultAsync(u => u.UserId == userId
                                                             && u.FinishedAt != null);
        }
    }
}
