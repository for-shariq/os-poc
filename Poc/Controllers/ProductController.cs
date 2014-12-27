using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Poc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poc.Controllers
{
    public class ProductController : JsonController
    {
        //
        // GET: /Product/
        private readonly OSBuilder repo = new OSBuilder();
        public ActionResult Index()
        {

            return Json(repo.getProducts(), JsonRequestBehavior.AllowGet);
            //OSBuilder os = new OSBuilder();
            //return View("Index",null,os.getProducts());
        }
              

    }

   
}
