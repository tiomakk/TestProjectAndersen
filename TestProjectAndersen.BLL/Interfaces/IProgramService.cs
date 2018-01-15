using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.BLL.Interfaces
{
    interface IProgramService: IDisposable
    {
        Task UpdateFromFileAsync(Stream file, bool onlyActual);
    }
}
