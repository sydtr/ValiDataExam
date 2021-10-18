using System;
using System.Collections.Generic;
using System.Text;
using Validata.Contract;
using Validata.Entities;

namespace Validata.Repository
{
   public class UnitOfWork:IUnitOfWork
    {
        private RepositoryContext repositoryContext;
        private OrderRepository order;
        private CustomerRepository customer;
        private ProductRepository product;

        public IOrderRepository Order
        {
            get
            {
                if (order == null)
                    order = new OrderRepository(repositoryContext);
                return order;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (product == null)
                    product = new ProductRepository(repositoryContext);
                return product;
            }
        }
        public ICustomerRepository Customer
        {
            get
            {
                if (customer == null)
                    customer = new CustomerRepository(repositoryContext);
                return customer;
            }
        }
        public UnitOfWork(RepositoryContext repositoryContext)
        {
           this.repositoryContext = repositoryContext;
        }
        public void Save()
        {
            repositoryContext.SaveChanges();
        }
    }
}
