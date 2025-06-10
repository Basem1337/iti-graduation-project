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
        public Library Library { get; set; }
        public Cart Cart { get; set; }
        public Wishlist WishList { get; set; }

    }
}
