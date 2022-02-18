using Microsoft.AspNetCore.Mvc;
namespace LayeredProjrct.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService service)
        {
            this.productService = service;
        }
        public IActionResult Index()
        {
            var data = productService.GetProduct(1);
            return View(data);
        }
    }
}
