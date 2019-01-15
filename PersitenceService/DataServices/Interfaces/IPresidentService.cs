using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersitenceService.Common.DTO;

namespace PersitenceService.DataServices.Interfaces
{
    public interface IPresidentService
    {
        IEnumerable<PresidentDTO> GetPresidentsFromFile();
    }
}
