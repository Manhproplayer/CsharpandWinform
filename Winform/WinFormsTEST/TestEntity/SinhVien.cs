//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SinhVien
    {
        public string masv { get; set; }
        public string tensv { get; set; }
        public string malop { get; set; }
    
        public virtual Lop Lop { get; set; }
    }
}