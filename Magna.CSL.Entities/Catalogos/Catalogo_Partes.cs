using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magna.CSL.Entities.Catalogos
{
   public class Catalogo_Partes
    {
        public long ID { get; set; }
        public string NoParte { get; set; }
        public string Descripcion { get; set; }
        public string Clasificaciones { get; set; }
        public decimal Maximo { get; set; }
        public decimal Minimo { get; set; }
        public decimal StockActual { get; set; }
        public byte[] Imagen { get; set; }
        public Nullable<decimal> Demanda { get; set; }
        public long ID_Catalogo_Estatus { get; set; }
    }
}
