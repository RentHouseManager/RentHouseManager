//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentHouseManager.Project.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIEN
    {
        public string IDPHONG { get; set; }
        public int TIENPHONG { get; set; }
        public int TIENDIEN { get; set; }
        public int TIENINTERNER { get; set; }
        public int TIENRAC { get; set; }
    
        public virtual PHONG PHONG { get; set; }
    }
}