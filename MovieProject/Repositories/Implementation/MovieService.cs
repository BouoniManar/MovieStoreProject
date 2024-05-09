using MovieProject.Models.Domain;
using MovieProject.Models.DTO;
using MovieProject.Repositories.Abstract;

namespace MovieProject.Repositories.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly DatabaseContext ctx;
        public MovieService(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }

        public int MovieId { get; private set; }
        public int GenreId { get; private set; }

        public bool Add(Movie model, int Id)
        {
            try
            {
                ctx.Movie.Add(model);
                ctx.SaveChanges();
                foreach (int genreId in model.Genres)
                {
                    var movieGenre = new MovieGenre();
                    {
                        MovieId = model.Id;
                        GenreId = genreId;
                    };
                    ctx.MovieGenre.Add(movieGenre);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                ctx.Movie.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Movie GetById(int id)
        {
            return ctx.Movie.Find(id);
        }

        public MovieListVm List()
        {
            var list = ctx.Movie.AsQueryable();
            var data = new MovieListVm
            {
                MovieList = list
            };
            return data;
        }

        public bool Update(Movie model)
        {
            try
            {
                ctx.Movie.Update(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool IMovieService.Add(Movie model)
        {
            throw new NotImplementedException();
        }

        bool IMovieService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Movie IMovieService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        MovieListVm IMovieService.List()
        {
            throw new NotImplementedException();
        }

        bool IMovieService.Update(Movie model)
        {
            throw new NotImplementedException();
        }
    }
}
