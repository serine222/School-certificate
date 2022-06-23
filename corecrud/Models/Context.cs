using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corecrud.Models
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public Context(DbContextOptions<Context> options) :base(options)
        {

        }
    }
}
