using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? PictureUrl { get; set; }


    }
}
