using LightInject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersitenceService.DataServices.Implementations;
using PersitenceService.DataServices.Interfaces;

namespace PersitenceService.Config
{
    class ServiceRegister : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
             
            #region Services

            serviceRegistry.Register<IPresidentService, PresidentService>();
        
            #endregion
        }
    }
}
