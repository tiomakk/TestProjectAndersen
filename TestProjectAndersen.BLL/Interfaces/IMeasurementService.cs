using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.BLL.DTO;

namespace TestProjectAndersen.BLL.Interfaces
{
    interface IMeasurementService: IDisposable
    {
        IEnumerable<MeasurementDTO> GetFromFile(Stream file);
    }
}
