using WebApplication3.Models.Kendo.Mvc.Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Http;

namespace WebApplication3.Services
{
    public class ProductService 
    {
        private static bool UpdateDatabase = false;
        private ISession _session;

        public ISession Session { get { return _session; } }

        public ProductService(IHttpContextAccessor httpContextAccessor) 
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        //public IEnumerable<ProductViewModel> Read()
        //{
        //    return GetAll();
        //}

        //public IList<ProductViewModel> GetAll()
        //{
        //    using (var db = GetContext())
        //    {
        //        var result = Session.GetObjectFromJson<IList<ProductViewModel>>("Products");

        //        if (result == null || UpdateDatabase)
        //        {
        //            var categories = db.Categories.ToList();

        //            result = db.Products.ToList().Select(product =>
        //            {
        //                var category = categories.First(c => product.CategoryID == c.CategoryID);

        //                return new ProductViewModel
        //                {
        //                    ProductID = product.ProductID,
        //                    ProductName = product.ProductName,
        //                    UnitPrice = product.UnitPrice.HasValue ? product.UnitPrice.Value : default(decimal),
        //                    UnitsInStock = product.UnitsInStock.HasValue ? product.UnitsInStock.Value : default(int),
        //                    QuantityPerUnit = product.QuantityPerUnit,
        //                    Discontinued = product.Discontinued,
        //                    UnitsOnOrder = product.UnitsOnOrder.HasValue ? product.UnitsOnOrder.Value : default(int),                          
        //                    LastSupply = DateTime.Today
        //                };
        //            }).ToList();

        //            Session.SetObjectAsJson("Products", result);
        //        }

        //        return Json();
        //    }
        //}

    }
}
