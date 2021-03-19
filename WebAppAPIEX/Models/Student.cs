using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppAPIEX.Models
{
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int? Sage { get; set; }
        public string Scourse { get; set; }
        public string Semail { get; set; }
        public string Scontact { get; set; }
    }
}
