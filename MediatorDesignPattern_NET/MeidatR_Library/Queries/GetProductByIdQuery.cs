using MediatorDesignPattern_NET.Models;
using MediatR;

namespace MediatorDesignPattern_NET.MeidatR_Library.Queries
{
    public class GetProductByIdQuery :IRequest<IEnumerable<Product>>
    {
        public int productId { get; set; }

        public class GetAllProductsHandler : IRequestHandler<GetProductByIdQuery, IEnumerable<Product>>
        {
            public List<Product> products;
            public GetAllProductsHandler()
            {
              products=  new List<Product>()
                {
                        new Product() { Id=1,Name="as",Price=3},
                                new Product() { Id=2,Name="Product 2",Price=3},
                                        new Product() { Id=3,Name="Product 3",Price=3},        new Product() { Id=4,Name="Zaheer",Price=3},
                };
            }

            public async Task<IEnumerable<Product>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                return products.Where(s => s.Id == request.productId).ToList();
            }
        }
    }
}
