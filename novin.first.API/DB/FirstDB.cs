using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using novin.first.API.Entities;

namespace novin.first.API.DB
{
    public class FirstDB : DbContext
    {
        public required DbSet<Student> Students { get; set; }
        //  درس جدید
        // {
        public FirstDB(DbContextOptions options)
            : base(options)
        {

        }
        // }
    }
}