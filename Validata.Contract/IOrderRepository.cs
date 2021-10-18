using System;
using System.Collections.Generic;
using System.Text;
using Validata.Entities.Models;

namespace Validata.Contract
{
   public interface IOrderRepository:IRepositoryBase<Order>
    {

        Order GetLastOrder();
    }
}
