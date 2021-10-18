using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Validata.Entities.Models
{
    [Table("Customer")]
   public class Customer
    { 
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(60,ErrorMessage ="Name can't be longer than 60 characters")]
        public string Name { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adress is required")]
        public string Adress { get; set; }
        public string PostCode { get; set; } 
        public ICollection<Order> Orders { get; set; }
    }
}
