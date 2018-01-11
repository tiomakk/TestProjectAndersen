using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class MetricRepository : IRepository<Metric>
    {
        public Task<IEnumerable<Metric>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Metric> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Metric>> FindAsync(Func<Metric, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Metric item)
        {
            throw new NotImplementedException();
        }

        public void Update(Metric item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
