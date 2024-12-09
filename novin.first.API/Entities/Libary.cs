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
        public int price { get; set; }
    }
}