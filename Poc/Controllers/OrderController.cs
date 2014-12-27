using Poc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// delete orders and product controller and views no use now
namespace Poc.Controllers
{
    public class OrderController : JsonController
    {
        //
        // GET: /Order/
        private readonly OSBuilder repo = new OSBuilder();
        public ActionResult Index()
        {
            return Json(repo.getOrders(), JsonRequestBehavior.AllowGet);
        }

    }
}
