using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieRazorPages.Models;

namespace MovieRazorPages.Data
{
    public class MovieRazorPagesContext : DbContext
    {
        public MovieRazorPagesContext (DbContextOptions<MovieRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MovieRazorPages.Models.Movie> Movie { get; set; } = default!;
    }
}
