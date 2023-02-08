using eTickets.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime dateTime { get; set; }
        public MovieCategory movieCategory { get; set; }

        public List<Actor_Movie> actors_Movies { get; set; } 

        //Cinema
        public int cinemaId { get; set; }
        [ForeignKey(nameof(cinemaId))]
        public Cinema Cinema { get; set; }

        //Producer
        public int producerId { get; set; }
        [ForeignKey(nameof(producerId))]
        public Producer Producer  { get; set; }



    }
}
