using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.EF;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        private readonly ApplicationContext _db;

        public UserRepository(ApplicationContext context)
        {
            _db = context;
        }
        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetAsync(int id)
        {
            return await _db.Users.FindAsync(id);
        }

        public Task<IEnumerable<User>> FindAsync(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(User item)
        {
            _db.Users.Add(item);
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
