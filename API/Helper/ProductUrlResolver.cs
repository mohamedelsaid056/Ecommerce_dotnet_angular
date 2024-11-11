using API.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helper
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return source.PictureUrl;
            }
            return null;
        }

    }
}