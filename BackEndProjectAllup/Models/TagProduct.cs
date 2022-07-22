using System;
using System.Collections.Generic;
using System.Text;

namespace AllupProject.Models
{
    internal class TagProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public Product Product { get; set; }
        public Tag Tag { get; set; }

    }
}
