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
    
    public partial class Checkout
    {
        public int invoice_id { get; set; }
        public string cardholder_name { get; set; }
        public string visa_no { get; set; }
        public string cvv { get; set; }
        public System.DateTime expire_date { get; set; }
    }
}
