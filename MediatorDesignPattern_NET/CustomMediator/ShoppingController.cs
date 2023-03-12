using Microsoft.AspNetCore.Mvc;

namespace MediatorDesignPattern_NET.CustomMediator
{
    public class ShoppingController : Controller
    {
        private readonly IShoppingMediator _mediator;

        public ShoppingController(IShoppingMediator mediator)
        {
            _mediator= mediator;
        }

        [HttpPost]
        public IActionResult AddToBasket(int id)
        {
            _mediator.Handle(id);
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
