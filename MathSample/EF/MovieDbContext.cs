using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSample.EF
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> dbContextOptions):base(dbContextOptions)
        {

        }


        public DbSet<MovieEntity> MovieEntity { get; set; }
    }
}
