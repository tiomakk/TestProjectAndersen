using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAndersen.BLL.Exceptions
{
    class ParsingExcelFileException : ParsingFileException
    {
        public int? Row { get; }
        public string ColumnName { get; set; }

        public ParsingExcelFileException(string message) : base(message) { }
        public ParsingExcelFileException(string message, int row, string columnName) : base(message)
        {
            Row = row;
            ColumnName = columnName;
        }
    }
}
