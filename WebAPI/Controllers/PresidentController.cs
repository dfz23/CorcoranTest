using PersitenceService.DataServices.Interfaces;
using PersitenceService.Factory;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebAPI.Models;
using WebAPI.Models.Utilities;

namespace WebAPI.Controllers
{
    public class PresidentController : ApiController
    {



        #region Properties
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        ResponseModel obResponse = new ResponseModel() { };
        private readonly IPresidentService _presidentService = DependecyFactory.GetInstance<IPresidentService>();

        #endregion


        [HttpGet]
        public HttpResponseMessage GetAll(string orderType)
        {
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            var presidents = new List<PresidentViewModel>();
            try
            {
                foreach (var item in _presidentService.GetPresidentsFromFile())
                {
                    presidents.Add(new PresidentViewModel(item));
                }

                obResponse.Status = true;
                switch (orderType)
                {
                    case "asc":
                         presidents.Sort((x, y) => x.FullName.CompareTo(y.FullName));
                        break;
                    case "desc":
                        presidents.Sort((x, y) => y.FullName.CompareTo(x.FullName));
                        break;
                }

                obResponse.DataResponse = presidents;
                obResponse.Message = "Consulta realizada exitosamente.";

            }
            catch (Exception ex)
            {
                response = this.Request.CreateResponse(HttpStatusCode.InternalServerError);
                obResponse.Status = false;
                obResponse.Message = "Error al procesar la solicitud.";
                obResponse.InnerException = ex.Message;
            }
            response.Content = new StringContent(serializer.Serialize(obResponse), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
