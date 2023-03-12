using MediatorDesignPattern_NET.MeidatR_Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorDesignPattern_NET.Controllers
{
    public class MediatRShoppingController : Controller
    {
        private readonly IMediator mediator;
        public MediatRShoppingController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public IActionResult Index()
        {
            var products = mediator.Send(new GetAllProductsQuery());
            var data = products.Result;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            var res = mediator.Send(new GetProductByIdQuery() { productId = id });

            var data = res.Result;

            return View();
        }
    }
}
