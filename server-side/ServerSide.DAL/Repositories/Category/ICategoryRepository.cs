using ServerSide.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerSide.DAL.Models;

namespace ServerSide.DAL
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
}
