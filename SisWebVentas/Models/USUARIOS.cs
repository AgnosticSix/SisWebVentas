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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.VENTAS = new HashSet<VENTAS>();
        }
    
        public int CVE_USUARIO { get; set; }
        [DisplayName("Nombre de Usuario")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string USUARIO { get; set; }
        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Password)]
        public string CONTRASENA { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public Nullable<bool> ADMINISTRADOR { get; set; }
    
        public virtual PERSONAS PERSONAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS> VENTAS { get; set; }
        public string LoginErrorMessage { get; internal set; }
    }
}
