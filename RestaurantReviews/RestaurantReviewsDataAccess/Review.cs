//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantReviewsDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ID { get; set; }
        public int RestID { get; set; }
        public string reviewer { get; set; }
        public Nullable<int> rating { get; set; }
        public string reviewBody { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
