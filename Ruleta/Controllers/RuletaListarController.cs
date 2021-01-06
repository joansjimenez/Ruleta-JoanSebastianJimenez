using Ruleta.Models.Bases;
using Ruleta.Models.RuletaListar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ruleta.Controllers
{
    public class RuletaListarController : ApiController
    {
        public HttpResponseMessage RuletasConsultar(GetRuletasParameters data)
        {
            CollectionResult<CRUDS_Ruletas_Result> service = CallService<CRUDS_Ruletas_Result>("Ruletas/RuletasConsultar", data, delegate ()
            {
                return db.CRUDS_Ruletas(data.RuletaID, data.Codigo);
            });

            if (service.result == ServiceResult.Success)
                return Request.CreateResponse(HttpStatusCode.OK, service);
            else
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, service.stackError);
        }
    }
}
