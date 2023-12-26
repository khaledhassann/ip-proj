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
    using System.ComponentModel.DataAnnotations;

    public partial class Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guest()
        {
            this.guest_rest = new HashSet<guest_rest>();
            this.Occasions = new HashSet<Occasion>();
            this.Rooms = new HashSet<Room>();
            this.Packages = new HashSet<Package>();
            this.Reservations = new HashSet<Reservation>();
            this.Transportations = new HashSet<Transportation>();
            this.Trips = new HashSet<Trip>();
        }
    
        public int cust_id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string Fname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Lname { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [StringLength(20,MinimumLength =8,ErrorMessage ="Your password must be at least 8 characters and maximum 20")]
        public string password { get; set; }
        [Required]
        [Display(Name = "confirm password")]
        [Compare("password",ErrorMessage ="Passwords not matching")]
        public string confpassword { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Required]
        [Display(Name = "Nationality")]
        public string nationality { get; set; }
        public string address { get; set; }

        [Display(Name = "Birthdate")]
        public DateTime? birthdate { get; set; }

        [Display(Name = "Phone number")]
        public string phone_no { get; set; }
        public Nullable<int> points { get; set; }
        public string cardholder_name { get; set; }
        public string card_no { get; set; }
        public Nullable<int> cvv { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<guest_rest> guest_rest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Occasion> Occasions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transportation> Transportations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}