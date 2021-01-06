using Ruleta.Models.Bases;
using Ruleta.Models.RuletaApuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ruleta.Controllers
{
    public class RuletaApuestaController : ApiController
    {
        public HttpResponseMessage RuletaApuestaInsertar(PostRuletaApuestaParameters data)
        {
            if (data.UsuarioCreditos <= 0)
            {
                CollectionResult<CRUD_RuletaApuesta_Result> service = CallService<CRUD_RuletaApuesta_Result>("RuletaApuesta/RuletaApuestaInsertar", data, delegate ()
                {
                    return db.CRUD_RuletaApuesta(data.CodigoApuesta, data.NumeroID, data.ColorID, data.Cantidad, data.UsuarioID);
                });

                if (service.result == ServiceResult.Success)
                    return Request.CreateResponse(HttpStatusCode.OK, service);
                else
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, service.stackError);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, service.stackError);
            }
        }

    }
}
