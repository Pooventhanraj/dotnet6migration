using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace migratedotnet6.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string RollNo { get; set; }
        public string Sname { get; set; }
        public int? Std { get; set; }
    }
}
