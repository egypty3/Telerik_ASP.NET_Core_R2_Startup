﻿namespace WebApplication3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc;

    namespace Kendo.Mvc.Examples.Models
    {
        public class ProductViewModel
        {
            // We removed ID field so WebApi demo works correctly
            [ScaffoldColumn(false)]
            public int ProductID
            {
                get;
                set;
            }

            [Required]
            [Display(Name = "Product name")]
            [Remote("IsProductName_Available", "Validation")]
            public string ProductName
            {
                get;
                set;
            }

            [Display(Name = "Unit price")]
            [DataType(DataType.Currency)]
            [Range(0, int.MaxValue)]
            public decimal UnitPrice
            {
                get;
                set;
            }

            [Display(Name = "Units in stock")]
            [DataType("Integer")]
            [Range(0, int.MaxValue)]
            public int UnitsInStock
            {
                get;
                set;
            }

            public bool Discontinued
            {
                get;
                set;
            }

            [Display(Name = "Last supply")]
            [DataType(DataType.Date)]
            public DateTime LastSupply
            {
                get;
                set;
            }

            [DataType("Integer")]
            public int UnitsOnOrder
            {
                get;
                set;
            }

            //[UIHint("ClientCategory")]
            //public CategoryViewModel Category
            //{
            //    get;
            //    set;
            //}

            //public int? CategoryID { get; set; }

            public string QuantityPerUnit { get; set; }
        }
    }
}
