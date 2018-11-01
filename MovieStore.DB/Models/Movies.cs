using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.DB.Migrations;

namespace MovieStore.DB.Models
{
    public class Movies
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Year { get; set; }
        public virtual DateTime Release { get; set; }
        public virtual int Price { get; set; }
        public virtual int GenreID { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
