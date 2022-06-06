using eMovie.Models.Data.Base;
using eMovie.Models.Data.ViewModels;

namespace eMovie.Models.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
