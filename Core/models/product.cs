using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.models
{
    public class product : BaseModel
    {


        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? PictureUrl { get; set; }


        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }


    }
}
