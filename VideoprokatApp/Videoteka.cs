//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoprokatApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Videoteka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Videoteka()
        {
            this.Vedomost = new HashSet<Vedomost>();
        }
    
        public int ID_kasseta { get; set; }
        public Nullable<int> ID_Film { get; set; }
        public Nullable<bool> Priznak { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vedomost> Vedomost { get; set; }
    }
}
