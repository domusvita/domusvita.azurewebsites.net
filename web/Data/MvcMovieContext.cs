#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using domusvita.azurewebsites.net.Models;

namespace domusvita.azurewebsites.net.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<domusvita.azurewebsites.net.Models.Movie> Movie { get; set; }
    }
}
