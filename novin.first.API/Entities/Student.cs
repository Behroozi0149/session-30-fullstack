using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novin.first.API.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public double? Average { get; set; }
    }
}