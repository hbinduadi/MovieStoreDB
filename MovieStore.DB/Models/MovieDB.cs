using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MovieStore.DB.Models;

namespace MovieStore.DB.Models
{
    public class MovieDB : DbContext
    {
        public MovieDB() : base("name = MovieDB")
        {

        }
        public DbSet<MovieStore.DB.Models.Movies> Movies { get; set; }

        public DbSet<MovieStore.DB.Models.Genre> Genres { get; set; }

    }
}
