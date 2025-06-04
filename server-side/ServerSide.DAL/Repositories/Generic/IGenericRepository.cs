﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.DAL.Repositories.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> getAllAsync();
        Task<T?> getByIdAsync(Guid id);
        void Add(T ent);
        void Update(T ent);
        void Delete(T ent);
    }
}
