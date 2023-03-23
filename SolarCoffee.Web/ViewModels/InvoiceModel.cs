using System;
using System.Collections.Generic;

namespace SolarCoffee.Web.ViewModels
{
    public class InvoiceModel
    {
        public  int Id { get; set; }
        public  DateTime CreatedOn { get; set; }
        private DateTime UpdatedOn { get; set; }
        public  int CustomerId { get; set; }
        public  List<SalesOrderItemModel> LineItems { get; set; }
    }

    public class SalesOrderItemModel
    {
        public  int Id { get; set; }
        public  int Quantity { get; set; }
        public  ProductModel Product { get; set; }
    }
}