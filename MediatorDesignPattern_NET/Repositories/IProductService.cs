using MediatorDesignPattern_NET.Models;

namespace MediatorDesignPattern_NET.Repositories
{
    public interface IProductService
    {
        Product GetProduct(int id);
    }
}
