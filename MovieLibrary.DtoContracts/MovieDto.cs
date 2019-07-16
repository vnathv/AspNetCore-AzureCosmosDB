using System;

namespace MovieLibrary.DtoContracts
{
    public class MovieDto
    {
        public Guid MovieId { get; set; }

        public string Name { get; set; }

        public int ReleasedYear { get; set; }

        public DirectorDto Director { get; set; }

        public int DirectorId { get; set; }

        public ProducerDto Producer { get; set; }

        public int ProducerId { get; set; }
    }
}