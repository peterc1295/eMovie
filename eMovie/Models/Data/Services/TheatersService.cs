using eMovie.Models.Data.Base;

namespace eMovie.Models.Data.Services
{
    public class TheatersService:EntityBaseRepository<Theaters>, ITheatersService
    {
        public TheatersService(AppDbContext context) : base(context)
        {

        }
    }
}
