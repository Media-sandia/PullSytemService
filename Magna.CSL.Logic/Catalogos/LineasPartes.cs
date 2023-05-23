using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cistel.Core.Base;
using Cistel.Core.Interfaces;
using Magna.CSL.Entities.Catalogos;
using System.Threading.Tasks;

namespace Magna.CSL.Logic.Catalogos
{
    public class LineasPartes : Core<Context.Context>, ICommon<Catalogo_Partes>
    {
        public IEnumerable<Catalogo_Partes> Activos(string connectionString)
        {
            throw new NotImplementedException();
        }

        public object Actualizar(string connectionString, Catalogo_Partes dataToUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Catalogo_Partes> Consultar(string connectionString, Catalogo_Partes filterToApply = null)
        {
            var result = ExecuteProcedureIEnumerable<Catalogo_Partes>(
                connectionString,
                Procedimientos.Proceso_Consultar_Api,
                methodArgs: filterToApply ?? new Catalogo_Partes());
            return result;
        }

        public object Eliminar(string connectionString, Catalogo_Partes dataToDelete)
        {
            throw new NotImplementedException();
        }

        public Catalogo_Partes Filtrar(string connectionString, Catalogo_Partes filterToApply = null)
        {
            throw new NotImplementedException();
        }

        public object Insertar(string connectionString, Catalogo_Partes dataToInsert)
        {
            throw new NotImplementedException();
        }
    }
}
