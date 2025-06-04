﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide.DAL.Models
{
    public class Library
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
