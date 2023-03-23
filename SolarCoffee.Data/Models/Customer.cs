using System;

namespace SolarCoffee.Data.Models
{
    public class Customer
    {
        public  int Id { get; set; }
        public  DateTime CreatedOn { get; set; }
        public  DateTime UpdatedOn { get; set; }
        public  String FirstName { get; set; }
        public  String LastName { get; set; }
        
        public  CustomerAddress PrimaryAddress { get; set; }
    }
}