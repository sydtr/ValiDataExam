using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validata.Entities.Models;

namespace Validata.Exam.Repos
{
    public class OrderRepo
    {
        public List<Order> Orders { get; } = new List<Order>
        {
            new Order{
                OrderDate=DateTime.Now,
                OrderId=Guid.NewGuid(),
                Customer=new Customer{ Name="İbrahim", LastName="Akbaş", Adress="Turkey", PostCode="01170"},
                Products = new List<Product>
            {
                new Product { Name="Example 1", Price=19.9f},
                new Product { Name="Example 2", Price=20.9f},
                new Product { Name="Example 3", Price=32.9f},

            }},
              new Order{
                OrderDate=DateTime.Now.AddDays(5),
                OrderId=Guid.NewGuid(),
                Customer=new Customer{ Name="İbrahim", LastName="Akbaş", Adress="Turkey", PostCode="01170"},
                Products = new List<Product>
            {
                new Product { Name="Example 3", Price=32.9f},

            }}

        };
    }
}
