//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaAcademico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Materias { get; set; }
        public Nullable<int> Creditos { get; set; }
        public string Prerequisito { get; set; }
        public Nullable<bool> isAproved { get; set; }
    }
}