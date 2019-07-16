using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.ClientContract
{
    public class Movie
    {
        public Guid MovieId { get; set; }

        public string Name { get; set; }

        public int ReleasedYear { get; set; }

        public Director Director { get; set; }

        public Producer Producer { get; set; }
    }
}
