using CarvedRock.Api.Data.Entities;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL
{
    public class ProductInterface : InterfaceGraphType<Product>
    {
        public ProductInterface()
        {
            Name = "Product";
            Field(d => d.Id);
            Field(d => d.Name);
            Field(d => d.Description);
            
        }
    }
}
