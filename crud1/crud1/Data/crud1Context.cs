using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crud1.Models;

namespace crud1.Data
{
    public class crud1Context : DbContext
    {
        public crud1Context (DbContextOptions<crud1Context> options)
            : base(options)
        {
        }

        public DbSet<crud1.Models.Pelicula> Pelicula { get; set; } = default!;
    }
}
