//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class guest_rest
    {
        public int cust_id { get; set; }
        public int rest_id { get; set; }
        public byte[] rest_time { get; set; }
    
        public virtual Guest Guest { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
