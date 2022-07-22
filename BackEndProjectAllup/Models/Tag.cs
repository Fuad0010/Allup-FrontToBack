using System;
using System.Collections.Generic;
using System.Text;

namespace AllupProject.Models
{
    internal class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TagProduct> TagProducts { get; set; }
    }
}
