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
    
    public partial class Proceso_Generar_Diagramas_Result
    {
        public Nullable<long> ID_Relacion { get; set; }
        public Nullable<long> ID_Padre_Relacion { get; set; }
        public long ID_CONTROL { get; set; }
        public string NoParte { get; set; }
        public Nullable<long> ID_Clasificaciones { get; set; }
        public Nullable<long> ID { get; set; }
        public Nullable<decimal> Maximo { get; set; }
        public Nullable<decimal> Minimo { get; set; }
        public Nullable<decimal> Stock { get; set; }
        public byte[] Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Lote { get; set; }
        public string Leveling { get; set; }
    }
}