using Microsoft.VisualBasic.FileIO;
using PersitenceService.Common.DTO;
using PersitenceService.DataServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace PersitenceService.DataServices.Implementations
{
    public class PresidentService : IPresidentService
    {


        #region constructor        

        #endregion

        #region Methods
        public IEnumerable<PresidentDTO> GetPresidentsFromFile()
        {
            List<PresidentDTO> result = new List<PresidentDTO>();
            
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Files\Presidents.csv");
            using (TextFieldParser parser = new TextFieldParser(path))
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
