﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.DAL.Repositories
{
    class MetricMesurementRepository : IRepository<MetricMesurement>
    {
        public Task<IEnumerable<MetricMesurement>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MetricMesurement> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MetricMesurement>> FindAsync(Func<MetricMesurement, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(MetricMesurement item)
        {
            throw new NotImplementedException();
        }

        public void Update(MetricMesurement item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}