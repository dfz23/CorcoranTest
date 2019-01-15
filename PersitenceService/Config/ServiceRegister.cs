using LightInject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersitenceService.DataServices.Implementations;
using PersitenceService.DataServices.Interfaces;

namespace Amadeus.LATAM.TOU.DataFileUploader.PersitenceService.Config
{
    class ServiceRegister : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            #region Context

            //var ambientDbContextLocator = new AmbientDbContextLocator();

            //serviceRegistry.Register<IDbContextScopeFactory>((x) => new DbContextScopeFactory(null));
            //serviceRegistry.Register<IAmbientDbContextLocator, AmbientDbContextLocator>(new PerScopeLifetime());

            #endregion

            #region Repositories

            //serviceRegistry.Register<IRepository<DataFileUploader_FileTypes>>((x) => new Repository<DataFileUploader_FileTypes>(ambientDbContextLocator));
            //serviceRegistry.Register<IRepository<DataFileUploader_DataTypes>>((x) => new Repository<DataFileUploader_DataTypes>(ambientDbContextLocator));
            //serviceRegistry.Register<IRepository<DataFileUploader_DataFile>>((x) => new Repository<DataFileUploader_DataFile>(ambientDbContextLocator));
            //serviceRegistry.Register<IRepository<DataFileUploader_DataFileDefinitions>>((x) => new Repository<DataFileUploader_DataFileDefinitions>(ambientDbContextLocator));
            //serviceRegistry.Register<IRepository<DataFileUploader_DataFileDefinition_Fields>>((x) => new Repository<DataFileUploader_DataFileDefinition_Fields>(ambientDbContextLocator));


            #endregion

            #region Services

            serviceRegistry.Register<IPresidentService, PresidentService>();
            //serviceRegistry.Register<IDataTypeService, DataTypeService>();
            //serviceRegistry.Register<IDataFileService, DataFileService>();
            //serviceRegistry.Register<IDataFileDefinitionsService, DataFileDefinitionsService>();
            //serviceRegistry.Register<IDataFileDefinitionFieldService, DataFileDefinitionFieldService>();



            #endregion
        }
    }
}
