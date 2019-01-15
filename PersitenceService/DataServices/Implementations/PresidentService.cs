using Microsoft.VisualBasic.FileIO;
using NLog;
using PersitenceService.Common.DTO;
using PersitenceService.DataServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace PersitenceService.DataServices.Implementations
{
    public class PresidentService : IPresidentService
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();


        #region constructor        

        #endregion

        #region Methods
        public IEnumerable<PresidentDTO> GetPresidentsFromFile()
        {
            List<PresidentDTO> result = new List<PresidentDTO>();
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\DFZ-23\source\repos\WebAPI\PersitenceService\Files\Presidents.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    result.Add(new PresidentDTO()
                    {
                        FullName = fields[0],
                        Birthday = !string.IsNullOrEmpty(fields[1])? Convert.ToDateTime(fields[1]):default(DateTime),
                        Birthplace = fields[2],
                        DeathDay = !string.IsNullOrEmpty(fields[3]) ? Convert.ToDateTime(fields[3]) : default(DateTime),
                        DeathPlace = fields[4]
                    });
                  
                }
            }            

            return result;
        }

        #endregion



    }
}
