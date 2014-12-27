using Poc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poc.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        StoreVM store = new StoreVM();

        public ActionResult Index()
        {
            return View(store.Fetch());
        }

    }
}
