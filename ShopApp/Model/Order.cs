//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public Nullable<int> WorkerId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Counts { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
