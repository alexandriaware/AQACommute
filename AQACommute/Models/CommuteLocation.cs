//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AQACommute.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommuteLocation
    {
        public int CommuteLocationID { get; set; }
        public int LocationsID { get; set; }
        public int CommuteID { get; set; }
    
        public virtual Commute Commute { get; set; }
        public virtual Location Location { get; set; }
    }
}
