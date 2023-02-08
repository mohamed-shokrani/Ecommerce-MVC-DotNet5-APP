using System.Collections.Generic;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> actors_Movies { get; set;}
        


    }
}
