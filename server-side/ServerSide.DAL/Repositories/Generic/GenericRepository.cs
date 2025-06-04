using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerSide.DAL.Context;

namespace ServerSide.DAL.Repositories.Generic
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        private readonly GAMADBContext _ctx;

        public GenericRepository(GAMADBContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(T ent)
        {
            _ctx.Set<T>().Add(ent);
        }

        public void Delete(T ent)
        {
            _ctx.Set<T>().Remove(ent);
        }

        public async Task<List<T>> getAllAsync()
        {
            return await _ctx.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> getByIdAsync(Guid id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }

        public void Update(T ent)
        {

        }
    }
}
