using Ruleta.Models.Bases;
using Ruleta.Models.RuletaCrear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ruleta.Controllers
{
    public class RuletaCrearController : ApiController
    {
        public HttpResponseMessage RuletaInsertar(PostRuletaParameters data)
        {
            CollectionResult<CRUD_Ruleta_Result> service = CallService<CRUD_Ruleta_Result>("RuletaCrear/RuletaInsertar", data, delegate ()
            {
                return db.CRUD_Ruleta(data.Codigo);
            });

            if (service.result == ServiceResult.Success)
                return Request.CreateResponse(HttpStatusCode.OK, service);
            else
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, service.stackError);
        }
    }
}
