using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class MetricMeasurementRepository : IRepository<MetricMeasurement>
    {
        public Task<IEnumerable<MetricMeasurement>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MetricMeasurement> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MetricMeasurement>> FindAsync(Func<MetricMeasurement, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(MetricMeasurement item)
        {
            throw new NotImplementedException();
        }

        public void Update(MetricMeasurement item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
