using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Validata.Contract;
using Validata.Entities.Models;
using Validata.Exam.Queries.Orders;

namespace Validata.Exam.Queries.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<Order>>
    {

        public GetAllOrdersHandler(IUnitOfWork wrapper)
        {
            repositoryWrapper = wrapper;
        }

        private IUnitOfWork repositoryWrapper;
        public async Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return repositoryWrapper.Order.FindAll().ToList();
        }
    }
}
