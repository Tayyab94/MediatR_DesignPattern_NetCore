using MediatorDesignPattern_NET.Repositories;

namespace MediatorDesignPattern_NET.CustomMediator
{
    public class ShoppingMediator : IShoppingMediator
    {
        private readonly IProductService _productService;
        private readonly INotificationService _notificationService;
        private readonly IShoppingService _shoppingService;

        public ShoppingMediator(
            IProductService productService,
            INotificationService notificationService,
            IShoppingService shoppingService)
        {
            _productService = productService;
            _notificationService = notificationService;
            _shoppingService = shoppingService;
        }

        public void Handle(int id)
        {
            // Fetch Product from Database
            var product = _productService.GetProduct(id);

            // Add Product to Basket
            _shoppingService.AddToBasket(product);

            // Send Notification to User
            _notificationService.SendNotification(product);
        }
    }
}
