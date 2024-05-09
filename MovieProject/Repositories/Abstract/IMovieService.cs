﻿using MovieProject.Models.Domain;
using MovieProject.Models.DTO;

namespace MovieProject.Repositories.Abstract
{
    public interface IMovieService
    {
       bool Add(Movie model);
       bool Update(Movie model);
       Movie GetById(int id);
       bool Delete(int id);
       MovieListVm List();

    }
}