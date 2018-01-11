using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> FindAsync(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(User item)
        {
            throw new NotImplementedException();
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
