using System;
using System.Collections.Generic;
using System.Text;

namespace Validata.Contract
{
    public interface IUnitOfWork
    {
        IOrderRepository Order { get; }
        IProductRepository Product { get; }
        ICustomerRepository Customer { get; }
    }
}
