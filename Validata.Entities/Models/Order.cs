using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Validata.Entities.Models
{
    [Table("Order")]
    public class Order
    {
        public Guid OrderId { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime OrderDate { get; set; } 

        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
