using System;
using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Data.Models
{
    public class CustomerAddress
    {
        public  int Id { get; set; }
        public  DateTime CreatedOn { get; set; }
        public  DateTime UpdatedOn { get; set; }
        
        [MaxLength(100)]
        public  String AddressLine1 { get; set; }
        
        [MaxLength(100)]
        public  String AddressLine2 { get; set; }
        
        [MaxLength(100)]
        public  String City { get; set; }
        
        [MaxLength(2)]
        public  String State { get; set; }
        
        [MaxLength(10)]
        public  String PostalCode { get; set; }
        
        [MaxLength(32)]
        public  String Country { get; set; }
    }
}