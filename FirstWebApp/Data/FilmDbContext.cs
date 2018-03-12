using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Models
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext (DbContextOptions<FilmDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWebApp.Models.Film> Film { get; set; }
    }
}
