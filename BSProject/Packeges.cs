//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BSProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Packeges
    {
        public Packeges()
        {
            this.Price = new HashSet<Price>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> VolumeMeasureId { get; set; }
        public Nullable<int> MeasureId { get; set; }
        public Nullable<decimal> Volume { get; set; }
    
        public virtual Measures Measures { get; set; }
        public virtual Measures Measures1 { get; set; }
        public virtual Products Products { get; set; }
        public virtual ICollection<Price> Price { get; set; }
    }
}
