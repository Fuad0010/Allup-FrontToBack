﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AllupProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,

    }
}
