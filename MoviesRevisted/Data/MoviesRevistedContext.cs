#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesRevisted;

namespace MoviesRevisted.Data
{
    public class MoviesRevistedContext : DbContext
    {
        public MoviesRevistedContext (DbContextOptions<MoviesRevistedContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesRevisted.Movie> Movie { get; set; }
    }
}
