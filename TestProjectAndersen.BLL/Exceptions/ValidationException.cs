using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.BLL.Exceptions
{
    class ValidationException: Exception
    {
        public String Property { get; }

        public ValidationException(string message, string property) : base(message)
        {
            Property = property;
        }
    }
}
