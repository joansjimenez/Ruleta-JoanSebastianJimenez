using Ruleta.Models.Bases;
using Ruleta.Models.RuletaCerrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ruleta.Controllers
{
    public class RuletaCerrarController : ApiController
    {
        public HttpResponseMessage RuletaCerrarActualizar(PutRuletaCerrarParameters data)
        {
            CollectionResult<CRUD_RuletaCerrar_Result> service = CallService<CRUD_RuletaCerrar_Result>("RuletaCerrar/RuletaCerrarActualizar", data, delegate ()
            {
                return db.CRUD_RuletaCerrar(data.RuletaID, data.Estado);
            });

            if (service.result == ServiceResult.Success)
                return Request.CreateResponse(HttpStatusCode.OK, service);
            else
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, service.stackError);
        }
    }
}
