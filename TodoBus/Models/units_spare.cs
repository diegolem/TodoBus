//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoBus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class units_spare
    {
        public int id { get; set; }
        public int unit_id { get; set; }
        public int spare_id { get; set; }
    
        public virtual spare spare { get; set; }
        public virtual units units { get; set; }
    }
}
