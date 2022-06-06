using eMovie.Models;
using eMovie.Models.Data;
using eMovie.Models.Data.Base;
using eMovie.Models.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovie.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}