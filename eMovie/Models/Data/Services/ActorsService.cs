using eMovie.Models;
using eMovie.Models.Data;
using eMovie.Models.Data.Base;
using eMovie.Models.Data.Services;
using eMovie.Models.Data.Services.eMovie.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace eMovie.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

