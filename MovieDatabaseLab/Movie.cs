﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
     class Movie
    {
        public string title { get; set; }
        public string category { get; set; }
        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }

    }
}
