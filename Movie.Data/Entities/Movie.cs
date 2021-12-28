using System;
using System.Collections.Generic;

namespace Movie.Data.Entities
{
    public class Movie : Entity
    {

        public string Title { get; set; }

        public string MovieType { get; set; }
        public string MovieKind { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }

        public DateTime? ReleaseAt { get; set; }

        public DateTime? EndAt { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public int PGRating { get; set; }

        public string Photo { get; set; }

        public virtual ICollection<Character> Characters{ get; set; }
        public virtual ICollection<MovieRating> MovieRatings { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }



    }
}
