using System.Web.Mvc;
using Sitecore.Feature.Products.Models;
using Sitecore.Feature.Products.Repositories;
using System.Collections.Generic;

namespace Sitecore.Feature.Products.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController() : this(new ProductRepository())
        {
        }

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult ProductCallout()
        {
            ProductDetails products = new Models.ProductDetails();
            List<Sitecore.Data.Items.Item> childItems = productRepository.GetProductDetails();
            products.childItems = childItems;
            return View(products);
        }
    }
}