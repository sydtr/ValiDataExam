using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validata.Entities.Models;

namespace Validata.Exam.Queries.Orders
{
    public class GetAllOrdersQuery : IRequest<List<Order>>
    {
    }
}
