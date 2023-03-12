using MediatorDesignPattern_NET.Models;

namespace MediatorDesignPattern_NET.Repositories
{
    public interface IShoppingService
    {
        void AddToBasket(Product product);
    }
}
