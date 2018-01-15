using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;

namespace TestProjectAndersen.DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<User> Users { get; }
        IProgramRepository Programs { get; }
        IUserProgramRepository UserPrograms { get; }
        IRepository<Metric> Metrics { get; }
        IRepository<MetricMeasurement> MetricMeasurements { get; }
        Task SaveAsync();
    }
}
