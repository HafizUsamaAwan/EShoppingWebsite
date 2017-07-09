//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SW.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public Cart()
        {
            this.Payments = new HashSet<Payment>();
            this.CartItems = new HashSet<CartItem>();
        }
    
        public int CartID { get; set; }
        public double TotalCost { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Cart Carts1 { get; set; }
        public virtual Cart Cart1 { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
