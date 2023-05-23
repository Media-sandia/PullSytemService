using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Cistel.Core.Interfaces;
using Magna.CSL.Entities.Catalogos;
using System.Web.Http;
using System.Configuration;

namespace Magna.CSL.Api.Controllers
{
    public class PartesController : ApiController
    {
        private ICommon<Catalogo_Partes> Partes;
        private string GetConnection = App.Propiedades.GetConnectionString;

        public PartesController()
        {
            this.Partes = new Logic.Catalogos.LineasPartes();
        }

        [HttpGet]
        public IEnumerable<Catalogo_Partes> allParts()
        {
            var result = Partes.Consultar(GetConnection);
            return result;
        }
    }
}
