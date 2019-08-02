using MVCSample.Models;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> ProductsList;

        public ActionResult List()
        {
            ProductsList = new List<Product>();
            for (int i = 0; i < 25; i++)
            {
                ProductsList.Add(new Product { Id = i, Description =string.Concat("Описание" ,i.ToString()), Name=string.Concat("Название",i.ToString()), Price=i.ToString()});
            }
            return View(ProductsList);
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Shiet";
            return View(ViewBag);
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Shiet";
            return View(ViewBag);
        }
    }
}