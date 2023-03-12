using MediatorDesignPattern_NET.Repositories;
using MediatR;

namespace MediatorDesignPattern_NET.MeidatR_Library
{
    public class ShoppingBasketRequestHandler : RequestHandler<ShoppingBasketRequest>
    {
        private readonly IProductService _productService;
        private readonly INotificationService _notificationService;
        private readonly IShoppingService _shoppingService;

        public ShoppingBasketRequestHandler(
            IProductService productService,
            INotificationService notificationService,
            IShoppingService shoppingService)
        {
            _productService = productService;
            _notificationService = notificationService;
            _shoppingService = shoppingService;
        }


        protected override void Handle(ShoppingBasketRequest request)
        {
            var product = _productService.GetProduct(request.ProductId);

            if (product == null)
            {
                return;
            }

            // Add Product To basket

            _shoppingService.AddToBasket(product);

            // Send Notificationto the User
            _notificationService.SendNotification(product);


        }

    }
}
