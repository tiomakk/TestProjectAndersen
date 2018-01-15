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
    class ProgramRepository : IProgramRepository
    {
        private readonly ApplicationContext _db;

        public ProgramRepository(ApplicationContext context)
        {
            _db = context;
        }

        public async Task<IEnumerable<Program>> GetAllAsync()
        {
            return await _db.Programs.ToListAsync();
        }

        public async Task<Program> GetAsync(int id)
        {
            return await _db.Programs.FindAsync(id);
        }

        public async Task<Program> GetAsync(string name)
        {
            return await _db.Programs.FirstOrDefaultAsync(p => p.Name == name);
        }

        public Task<IEnumerable<Program>> FindAsync(Func<Program, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Program item)
        {
            _db.Programs.Add(item);
        }

        public void Update(Program item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
