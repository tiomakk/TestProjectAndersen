using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.BLL.DTO;

namespace TestProjectAndersen.BLL.Interfaces
{
    interface IFileParser
    {
        IEnumerable<ParsedProgramDTO> ParsePrograms(Stream file);
        IEnumerable<ParsedMeasurementDTO> ParseMeasurements(Stream file);      
    }
}
