using MediatorDesignPattern_NET.Models;
using MediatR;

namespace MediatorDesignPattern_NET.MeidatR_Library.Queries
{
    public class GetAllProductsQuery :IRequest<List<Product>>
    {
        public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
        {
            public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                return new List<Product>()
                {
                        new Product() { Id=1,Name="as",Price=3},
                                new Product() { Id=2,Name="Product 2",Price=3},
                                        new Product() { Id=3,Name="Product 3",Price=3},        new Product() { Id=4,Name="Zaheer",Price=3},
                };
            }
        }
    }
}
