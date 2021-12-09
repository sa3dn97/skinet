using System;
using System.Linq.Expressions;
using Core.Entitties;

namespace Core.Spacifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpacifications<product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecification(int id)
         : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}