//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisWebVentas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUNICIPIOS
    {
        public int CVE_MUNICIPIO { get; set; }
        public Nullable<int> CVE_ESTADO { get; set; }
        public string MUNICIPIO { get; set; }
    
        public virtual ESTADOS ESTADOS { get; set; }
    }
}
