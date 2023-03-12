using MediatorDesignPattern_NET.Models;

namespace MediatorDesignPattern_NET.Repositories
{
    public class ProductService : IProductService
    {
        public Product GetProduct(int id)
        {
            return new Product() { Id = id, Name="Dell Laptop", Price=2.2m };
        }
    }
}
