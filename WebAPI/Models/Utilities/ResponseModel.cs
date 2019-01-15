using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models.Utilities
{
    public class ResponseModel
    {
        public bool Status { get; set; }
        public dynamic DataResponse { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
    }
}