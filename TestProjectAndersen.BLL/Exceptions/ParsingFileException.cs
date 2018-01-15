using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.BLL.Exceptions
{
    class ParsingFileException : Exception
    {
        public ParsingFileException(string message) : base(message) { }

    }
}
