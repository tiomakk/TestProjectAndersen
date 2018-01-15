using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.BLL.DTO;
using TestProjectAndersen.BLL.Exceptions;
using TestProjectAndersen.BLL.Implementations;
using TestProjectAndersen.BLL.Interfaces;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.BLL.Services
{
    class MeasurementService: IMeasurementService
    {
        public IUnitOfWork Database { get; set; }

        public MeasurementService(IUnitOfWork db)
        {
            Database = db;
        }

        public IEnumerable<MeasurementDTO> GetFromFile(Stream file)
        {
            var fileParser = new ExcelFileParser();
            var parsedMeasurements = fileParser.ParseMeasurements(file);

            return from measurement in parsedMeasurements
                select new MeasurementDTO
                {
                    Name = measurement.Name,
                    Value = measurement.Value,
                    MeasuredAt = measurement.MeasuredAt,
                    UserId = measurement.UserId
                };
        }

        public async Task AddRangeAsync(IEnumerable<MeasurementDTO> measurements, bool onlyActual)
        {
            foreach (var measurement in measurements)
            {
                if(measurement.MeasuredAt > DateTime.Now)
                    throw new ValidationException("The date can not be after the present.", "MeasuredAt");

            }
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        
    }
}
