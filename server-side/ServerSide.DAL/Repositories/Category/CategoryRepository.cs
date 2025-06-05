using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerSide.DAL.Context;
using ServerSide.DAL.Models;
using ServerSide.DAL.Repositories.Generic;

namespace ServerSide.DAL
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly GAMADBContext _ctx;
        public CategoryRepository(GAMADBContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
