//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public System.DateTime RentedDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public Nullable<System.DateTime> ActualReturnDate { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual User1 User { get; set; }
    }
}
