using MathSample.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSample.MovieContext
{
    // Integration Test olduğu için EF Inmemory paket indirdik.
    public class MovieContextTest
    {

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllItems()
        {

            var options = new DbContextOptionsBuilder<MovieDbContext>()
                .UseInMemoryDatabase(databaseName: "MovieListDatabase")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new MovieDbContext(options))
            {
                context.MovieEntity.Add(new MovieEntity { Id = "1", Name="Movie1" });
                context.MovieEntity.Add(new MovieEntity { Id = "2", Name = "Movie2" });
                context.MovieEntity.Add(new MovieEntity { Id = "3", Name = "Movie3" });

                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new MovieDbContext(options))
            {
               
                //Act
                var movies = context.MovieEntity.ToList();

                //Assert
                Assert.Equal(3, movies.Count());
            }
        }
    }
}
