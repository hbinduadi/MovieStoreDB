using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Web.ViewModels
{
    public class OrdPlace
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int Year { get; set; }

        public virtual int Price { get; set; }
        public virtual double Tax { get; set; }
        public virtual double Total { get; set; }
    }
}