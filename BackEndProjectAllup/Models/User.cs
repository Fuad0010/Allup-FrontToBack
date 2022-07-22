using System;
using System.Collections.Generic;
using System.Text;

namespace AllupProject.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
