using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;

namespace TestProjectAndersen.DAL.Interfaces
{
    interface IUnitOfWork: IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Program> Orders { get; }
        IRepository<UserProgram> UserPrograms { get; }
        IRepository<Metric> Metrics { get; }
        IRepository<MetricMeasurement> MetricMeasurements { get; }
        Task SaveAsync();
    }
}
