using MediatorDesignPattern_NET.Repositories;
using MediatorDesignPattern_NET_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MediatorDesignPattern_NET_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly INotificationService _notificationService;
        private readonly IShoppingService _shoppingService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductService productService,
        INotificationService notificationService,
        IShoppingService shoppingService)
        {
            this._productService = productService;
            this._notificationService = notificationService;
            this._shoppingService = shoppingService;
            this._logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToBasket(int id)
        {
            // Fetch Product from Database
            var product = _productService.GetProduct(id);

            // Add Product to Basket
            _shoppingService.AddToBasket(product);

            // Send Notification to User
            _notificationService.SendNotification(product);

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}