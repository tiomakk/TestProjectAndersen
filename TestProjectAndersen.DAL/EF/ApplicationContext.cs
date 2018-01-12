using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using System.Data.Entity;

namespace TestProjectAndersen.DAL.EF
{
    class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<UserProgram> UserPrograms { get; set; }
        public DbSet<MetricMeasurement> MetricMesurements { get; set; }

        public ApplicationContext(string connectionString) 
            : base(connectionString) { }

        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new MetricsInitializer());
        }
    }
}
