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
    
    public partial class Matricula
    {
        public string CedulaEstudiante { get; set; }
        public byte Numero { get; set; }
        public string Sigla { get; set; }
        public string Anno { get; set; }
        public byte Semestre { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
    }
}
