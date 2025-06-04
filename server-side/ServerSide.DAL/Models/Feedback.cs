using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.DAL.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
