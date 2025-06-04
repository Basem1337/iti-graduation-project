using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ServerSide.DAL.Models
{
    public class User:IdentityUser<Guid>
    {
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public virtual ICollection<Library> UserLibrary { get; set; } = new List<Library>();
        public virtual ICollection<Wishlist> UserWishlist { get; set; } = new List<Wishlist>();
        public virtual ICollection<Cart> CartItems { get; set; } = new List<Cart>();

    }
}
