using ApplicationCommerciale.Infrastructure.Data;
using AutoMapper;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Infrastructure.Repositories
{
    public class UnitOfWork 
    {


        private readonly ApplicationDbContext _context;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            
        }
    }
}
