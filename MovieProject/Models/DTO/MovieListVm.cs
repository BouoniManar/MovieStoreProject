﻿using MovieProject.Models.Domain;

namespace MovieProject.Models.DTO
{
    public class MovieListVm

    {
        public int Id { get; set; }

        public IQueryable<Movie> MovieList { get; set; }
        //public int PageSize { get; set; }
       // public int CurrentPage { get; set; }
        //public int TotalPages { get; set; }
       // public string? Term { get; set; }
    }
}