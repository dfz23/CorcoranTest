using PersitenceService.DataServices.Interfaces;
using PersitenceService.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebAPI.Models.Utilities;

namespace WebAPI.Controllers
{
    public class PresidentController : ApiController
    {
       


        #region Properties
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        ResponseModel obResponse = new ResponseModel() { };
        private readonly IPresidentService _dataFileService = DependecyFactory.GetInstance<IPresidentService>();

        #endregion

       
        [HttpGet]       
        public HttpResponseMessage GetAll(string GetAll)    
        {
            var response = this.Request.CreateResponse(HttpStatusCode.OK);

            if (GetAll == "true")
            {
                try
                {
                    obResponse.Status = true;

                    obResponse.DataResponse = _dataFileService.GetPresidentsFromFile();
                    obResponse.Message = "Consulta realizada exitosamente.";

                }
                catch (Exception ex)
                {
                    response = this.Request.CreateResponse(HttpStatusCode.InternalServerError);
                    obResponse.Status = false;
                    obResponse.Message = "Error al procesar la solicitud.";
                    obResponse.InnerException = ex.Message;
                }

            }
            response.Content = new StringContent(serializer.Serialize(obResponse), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
