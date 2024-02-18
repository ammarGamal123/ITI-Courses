using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        // product/index
        public IActionResult Index()
        {
            // Steps to send request and get respone
            // 1) ask model
            // 2) send view (viewName , Model)
            ProductSampleData productBL = new ProductSampleData();
            List<Product> productList = new List<Product>();
            productList = productBL.GetAll();
            
            
            return View("DisplayAllProducts" , productList);
        }


        // product/details/1 , prodcut/details/2
        // if it's not id then we have to call it like = product/details?pid=1
        // it's called query string
        public IActionResult Details(int pid)
        {
            ProductSampleData productBL = new ProductSampleData();
            Product productModel = productBL.GetById(pid);
            
            
            return View("Details" , productModel); // 
        }
    }
}
