﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DB.Models
{
    public class Genre
    {
        public virtual int Id{ get; set; }
        public virtual string Type { get; set; }
    }
}
