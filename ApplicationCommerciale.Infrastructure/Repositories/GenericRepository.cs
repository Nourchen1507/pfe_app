using ApplicationCommerciale.Core.Entities;
using ApplicationCommerciale.Core.Interfaces;
using ApplicationCommerciale.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Infrastructure.Repositories
{
   public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity<int>
    {


        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
