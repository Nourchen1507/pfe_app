using ApplicationCommerciale.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity<int>
    {
    }
}
