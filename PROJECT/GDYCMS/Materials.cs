//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GDYCMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Materials
    {
        public int MaterialID { get; set; }
        public int MaterialGroupID { get; set; }
        public string Name { get; set; }
        public string HTML { get; set; }
        public Nullable<int> FirstCreatorID { get; set; }
        public Nullable<int> LastModifierID { get; set; }
        public Nullable<System.DateTime> LastChange { get; set; }
        public bool isPublished { get; set; }
    
        public virtual MaterialGroups MaterialGroups { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserProfile UserProfile1 { get; set; }
    }
}
