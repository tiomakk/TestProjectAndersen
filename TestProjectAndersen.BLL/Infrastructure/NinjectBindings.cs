using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using TestProjectAndersen.BLL.Implementations;
using TestProjectAndersen.BLL.Interfaces;
using TestProjectAndersen.DAL;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.BLL.Infrastructure
{
    class NinjectBindings: NinjectModule
    {
        private readonly string _connectionString;

        public NinjectBindings(string connectionString)
        {
            _connectionString = connectionString;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>()
                .WithConstructorArgument(_connectionString);

            Bind<IFileParser>().To<ExcelFileParser>();
        }

    }
}
