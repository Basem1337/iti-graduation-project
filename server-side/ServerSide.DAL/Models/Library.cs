using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.DAL.Models
{
    public class Library
    {
        public int LibraryID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }= new List<Product>();
    }
}
