//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opiniometro_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conformado_Item_Sec_Form
    {
        public int ItemId { get; set; }
        public string CodigoFormulario { get; set; }
        public string TituloSeccion { get; set; }
        public string NombreFormulario { get; set; }
    
        public virtual Formulario Formulario { get; set; }
        public virtual Item Item { get; set; }
        public virtual Seccion Seccion { get; set; }
    }
}
