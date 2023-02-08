using System.Collections.Generic;

namespace eTickets.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Movie> Movies { get; set; } 


    }
}
