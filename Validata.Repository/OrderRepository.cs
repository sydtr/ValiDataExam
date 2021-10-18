using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Validata.Contract;
using Validata.Entities;
using Validata.Entities.Models;

namespace Validata.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public  Order  GetLastOrder()
        {
            return RepositoryContext.Orders.OrderByDescending(c => c.OrderDate).First();
        }
    }
}
