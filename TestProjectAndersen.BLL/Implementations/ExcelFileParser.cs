using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ExcelDataReader;
using TestProjectAndersen.BLL.DTO;
using TestProjectAndersen.BLL.Exceptions;
using TestProjectAndersen.BLL.Interfaces;

namespace TestProjectAndersen.BLL.Implementations
{
    class ExcelFileParser : IFileParser
    {
        public IEnumerable<ParsedProgramDTO> ParsePrograms(Stream fileStream)
        {
            var parsedPrograms = new List<ParsedProgramDTO>();

            using (var reader = ExcelReaderFactory.CreateReader(fileStream))
            {
                reader.Read(); //Пропускаем первую строку с шапкой
                var i = 2;

                while (reader.Read())
                {
                    string skipRow;
                    try
                    {
                        skipRow = reader.GetString(1);
                    }
                    catch (Exception e)
                    {
                        throw new ParsingExcelFileException($"Error at row {i}. Is_Participating wrong format", i, "Is_Participating");
                    }
                    if (skipRow != "N" && skipRow != "Y")
                        throw new ParsingExcelFileException($"Error at row {i}. Is_Participating must be \"N\" or \"Y\"", i, "Is_Participating");
                    if (skipRow == "N")
                    {
                        i++;
                        continue;
                    }

                    DateTime date;
                    try
                    {
                        date = reader.GetDateTime(4);
                    }
                    catch (Exception e)
                    {
                        throw new ParsingExcelFileException($"Error at row {i}. Wrong date format", i, "Date_Start");
                    }
                    if (date > DateTime.Now)
                        throw new ParsingExcelFileException($"Error at row {i}. Date_Start must be earlier than now.", i, "Date_Start");

                    string isFollowed;
                    try
                    {
                        isFollowed = reader.GetString(2);
                    }
                    catch (Exception e)
                    {
                        throw new ParsingExcelFileException($"Error at row {i}. Is_Exec wrong format", i, "Is_Exec");
                    }
                    if(isFollowed != "N" && isFollowed != "Y")
                        throw new ParsingExcelFileException($"Error at row {i}. Is_Exec must be \"N\" or \"Y\"", i, "Is_Exec");


                    int userId;
                    try
                    {
                        userId = (int) reader
                            .GetDouble(0); //TODO На будущее добавить проверку, если User_Id будет дробным числом
                    }
                    catch (Exception e)
                    {
                        throw new ParsingExcelFileException($"Error at row {i}. User_Id wrong format", i, "User_Id");
                    }
                        

                    parsedPrograms.Add(new ParsedProgramDTO
                    {
                        UserId = userId,
                        IsFollowed = (isFollowed == "Y"),
                        Name = reader.GetString(3),
                        StartedAt = reader.GetDateTime(4)
                    });

                    i++;
                }

            }
            return parsedPrograms;
        }

        public IEnumerable<ParsedMeasurementDTO> ParseMeasurements(Stream fileStream)
        {
            var parsedMeasurements = new List<ParsedMeasurementDTO>();

            using (var reader = ExcelReaderFactory.CreateReader(fileStream))
            {
                reader.Read(); //Пропускаем первую строку с шапкой
                var i = 2;

                try
                {
                    while (reader.Read())
                    {
                        var valueType = reader.GetFieldType(1);
                        string value;
                        switch (Type.GetTypeCode(valueType)) //TODO Реализовать различные типы данных для измерений, если понадобится
                        {
                            case TypeCode.Double:
                                value = reader.GetDouble(1).ToString();
                                break;
                            case TypeCode.String:
                                value = reader.GetString(1);
                                break;
                            case TypeCode.DateTime:
                                value = reader.GetDateTime(1).ToString();
                                break;
                            default:
                                value = "";
                                break;
                        }

                        parsedMeasurements.Add(new ParsedMeasurementDTO
                        {
                            UserId = (int)reader.GetDouble(0), //TODO На будущее добавить проверку, если User_Id будет дробным числом
                            Value = value,
                            Name = reader.GetString(3),
                            MeasuredAt = reader.GetDateTime(2)
                        });

                        i++;
                    }
                }
                catch (InvalidCastException ex)
                {
                    throw new Exception($"Error at row {i}");                    
                }
            }
            return parsedMeasurements;
        }
    }
}
