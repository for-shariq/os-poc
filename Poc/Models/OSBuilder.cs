using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poc.Models
{
    public class OSBuilder
    {
               
        public string getProducts()
        {
            var products = new[] 
                {
                    new Product { Name = "Nokia", Price = "12.22"},
                    new Product { Name = "Samsung", Price = "10.22"},
                    new Product { Name = "HTC", Price = "11.22"}
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(products, Formatting.None, settings);
        }


        public string getOrders()
        {
            var orders = new[] 
                {
                   new Order {OrderId = "123455", Description = "Test Desc"},
                   new Order {OrderId = "123455", Description = "Test Desc"},
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(orders, Formatting.None, settings);
        }


    }
     
}