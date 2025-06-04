using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.DAL.Models
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
