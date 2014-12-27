﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Poc.Controllers
{
    public class JsonController : Controller
    {
        protected new ActionResult Json(object data, JsonRequestBehavior behaviour = JsonRequestBehavior.DenyGet)
        {
            var jsonSerializerSettings = new JsonSerializerSettings 
            { 
                ContractResolver = new CamelCasePropertyNamesContractResolver() 
            };

            if (Request.RequestType == WebRequestMethods.Http.Get && behaviour == JsonRequestBehavior.DenyGet)
                throw new InvalidOperationException("GET is not permitted");

            var jsonResult = new ContentResult
            {
                 Content = JsonConvert.SerializeObject(data,jsonSerializerSettings),
                 ContentType = "application/json"
            };
            return jsonResult;
        }
    }
}
