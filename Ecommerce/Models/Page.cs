//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class Page
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        [AllowHtml]
        public string Contents { get; set; }
        public string Thumb { get; set; }
        public bool Published { get; set; }
        public string Title { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public string Alias { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> Ordering { get; set; }
    }
}
