using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poc.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View("Index",null,GetProducts());
        }

        public string GetProducts()
        {
            var products = new[] 
                {
                    new Product { Name = "Nokia", Price = "12.22"},
                    new Product { Name = "Samsung", Price = "10.22"},
                    new Product { Name = "HTC", Price = "11.22"}
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(products,Formatting.None,settings);
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
