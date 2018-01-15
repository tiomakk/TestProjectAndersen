using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAndersen.BLL.DTO;
using TestProjectAndersen.BLL.Implementations;
using TestProjectAndersen.BLL.Interfaces;
using TestProjectAndersen.DAL.Entites;
using TestProjectAndersen.DAL.Interfaces;

namespace TestProjectAndersen.BLL.Services
{
    class ProgramService: IProgramService
    {
        public IUnitOfWork Database { get; set; }

        public ProgramService(IUnitOfWork db)
        {
            Database = db;
        }
        public async Task UpdateFromFileAsync(Stream fileStream, bool onlyActual)
        {
            var fileParser = new ExcelFileParser();
            var parsedPrograms = fileParser.ParsePrograms(fileStream);
            parsedPrograms = NormalizePrograms(parsedPrograms, onlyActual);

            foreach (var nProg in parsedPrograms)
            {
                var program = (await Database.Programs.GetAsync(nProg.Name))
                              ?? new Program
                              {
                                  Name = nProg.Name
                              };

                var user = await Database.Users.GetAsync(nProg.UserId);
                if (user != null)
                {
                    var activeProgram =
                        await Database.UserPrograms.GetActiveAsync(nProg.UserId); //TODO Заменить на Find в случае чего

                    if (activeProgram != null)
                    {
                        if (activeProgram.StartedAt >= nProg.StartedAt)
                            continue;
                        activeProgram.FinishedAt = DateTime.Now;
                        Database.UserPrograms.Update(activeProgram);
                    }
                }
                else
                {
                    user = new User
                    {
                        Id = nProg.UserId
                    };
                    Database.Users.Create(user);
                }


                var newUserProgram = new UserProgram
                {
                    UserId = user.Id,
                    Foolowing = nProg.IsFollowed,
                    Program = program,
                    StartedAt = nProg.StartedAt
                };

                Database.UserPrograms.Create(newUserProgram);
                await Database.SaveAsync();
            }
        }

        private IEnumerable<ParsedProgramDTO> NormalizePrograms(IEnumerable<ParsedProgramDTO> parsedPrograms, bool onlyLast)
        {
            IEnumerable<ParsedProgramDTO> normalizedPrograms;
            if (onlyLast)
                normalizedPrograms = from p in parsedPrograms
                    group p by p.UserId
                    into g
                    let lastDate = g.Max(i => i.StartedAt)
                    select g.First(p => p.StartedAt == lastDate);
            else
                normalizedPrograms = from p in parsedPrograms
                    orderby p.StartedAt
                    select p;

            return normalizedPrograms;
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
