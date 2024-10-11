﻿using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{

    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }


        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        // The DataType attribute on ReleaseDate specifies the tyhpe of the data (Date).
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}