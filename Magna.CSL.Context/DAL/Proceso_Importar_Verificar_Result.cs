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
    
    public partial class Proceso_Importar_Verificar_Result
    {
        public Nullable<long> ID_Catalogo_Partes { get; set; }
        public Nullable<long> ID_Catalogo_Partes_Clasificaciones { get; set; }
        public string NoParte { get; set; }
        public Nullable<decimal> Maximo { get; set; }
        public Nullable<decimal> Minimo { get; set; }
        public Nullable<decimal> Stock { get; set; }
        public Nullable<long> ID_Proceso_Produccion_Ultimo { get; set; }
        public Nullable<long> ID_Proceso_Produccion { get; set; }
        public string ProductionOrder { get; set; }
        public string Leveling { get; set; }
        public string Lote { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<long> ID_Proceso_Embarques_Ultimo { get; set; }
        public Nullable<long> ID_Proceso_Embarques { get; set; }
        public string NoEmbarque { get; set; }
        public string Motivo { get; set; }
    }
}