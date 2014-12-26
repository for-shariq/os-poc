using Poc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poc.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            OSBuilder os = new OSBuilder();
            return View("Index",null,os.getOrders());
        }

    }
}
