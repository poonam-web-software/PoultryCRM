//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoultryCRM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Daily_Feeding_tbl
    {
        public long Id { get; set; }
        public string Flock { get; set; }
        public string feeding_date { get; set; }
        public string Type_Of_Bird { get; set; }
        public string Feed_Type { get; set; }
        public Nullable<int> Quantity_Fed { get; set; }
        public string Comment { get; set; }
    }
}