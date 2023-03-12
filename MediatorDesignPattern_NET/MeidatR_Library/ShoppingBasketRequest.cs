using MediatR;

namespace MediatorDesignPattern_NET.MeidatR_Library
{
    public class ShoppingBasketRequest :IRequest
    {
        public int ProductId { get; set; }
    }
}
