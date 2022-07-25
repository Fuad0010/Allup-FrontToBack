using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllupProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UptadetAt { get; set; }


        public List<Product> Products { get; set; }
    }
}
