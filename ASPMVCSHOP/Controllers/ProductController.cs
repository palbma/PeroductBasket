using ASPMVCSHOP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCSHOP.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController

        private IProductRepository? _productRepository;

        public ProductController(IProductRepository? productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ViewResult List() => View(_productRepository.Products);
    }
}
