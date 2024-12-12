using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novin.first.API.Entities
{
    public class Libary
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Writer { get; set; }
        //   روز قرض گرفتن از کتابخانه
        public string? Date { get; set; } 
        public double Price { get; set; }
    }
}