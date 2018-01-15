using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.EF;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;
using TestProjectAndersen.DAL.Repositories;

namespace TestProjectAndersen.DAL
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _db;
        private UserRepository _userRepository;
        private UserProgramRepository _userProgramRepository;
        private MetricRepository _metricRepository;
        private MetricMeasurementRepository _metricMeasurementRepository;
        private ProgramRepository _programRepository;

        public EFUnitOfWork(string connectionString)
        {
            _db = new ApplicationContext(connectionString);
        }       

        public IRepository<User> Users
        {
            get { return _userRepository = _userRepository ?? new UserRepository(_db); }
        }

        public IProgramRepository Programs
        {
            get { return _programRepository = _programRepository ?? new ProgramRepository(_db); }
        }

        public IUserProgramRepository UserPrograms
        {
            get { return _userProgramRepository = _userProgramRepository ?? new UserProgramRepository(_db); }
        }

        public IRepository<Metric> Metrics
        {
            get { return _metricRepository = _metricRepository ?? new MetricRepository(); }
        }

        public IRepository<MetricMeasurement> MetricMeasurements
        {
            get
            {
                return _metricMeasurementRepository = _metricMeasurementRepository ?? 
                    new MetricMeasurementRepository();
            }
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
