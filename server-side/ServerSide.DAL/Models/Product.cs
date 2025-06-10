using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.DAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal OriginalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }
        public string Company { get; set; } = string.Empty;
        public decimal Rate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string TrailerUrl { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public Guid WishListID { get; set; }
        public Wishlist WishList { get; set; } = null!;
        public Guid CartID { get; set; }
        public Cart Cart { get; set; } = null!;
        public Guid LibraryID { get; set; }
        public Library Library { get; set; } = null!;
        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    }
}
