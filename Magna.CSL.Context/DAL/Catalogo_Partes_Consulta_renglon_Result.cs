//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magna.CSL.Context.DAL
{
    using System;
    
    public partial class Catalogo_Partes_Consulta_renglon_Result
    {
        public long ID { get; set; }
        public string NoParte { get; set; }
        public string Descripcion { get; set; }
        public long ID_Catalogo_Partes_Clasificaciones { get; set; }
        public decimal Maximo { get; set; }
        public decimal Minimo { get; set; }
        public decimal StockActual { get; set; }
        public byte[] Imagen { get; set; }
        public Nullable<decimal> Demanda { get; set; }
        public long ID_Catalogo_Estatus { get; set; }
    }
}
