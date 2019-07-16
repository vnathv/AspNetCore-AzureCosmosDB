using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLibrary.DomainModel
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public int ReleasedYear { get; set; }

        public Director Director { get; set; }

        public int DirectorId { get; set; }

        public Producer Producer { get; set; }

        public int ProducerId { get; set; }
    }
}