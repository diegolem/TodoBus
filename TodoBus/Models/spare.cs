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
    
    public partial class spare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public spare()
        {
            this.units_spare = new HashSet<units_spare>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string code { get; set; }
        public Nullable<int> brand_id { get; set; }
        public int spare_type_id { get; set; }
    
        public virtual brands brands { get; set; }
        public virtual spare_categories spare_categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<units_spare> units_spare { get; set; }
    }
}
