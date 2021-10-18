using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Validata.Contract;
using Validata.Entities.Models;
using Validata.Exam.Queries.Orders;

namespace Validata.Exam.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class OrderController : Controller
    {
        public OrderController(IUnitOfWork wrapper , IMediator mediator)
        {
            repositoryWrapper = wrapper;
            this.mediator=mediator;
        }


        private readonly IMediator mediator;


        private IUnitOfWork repositoryWrapper;

         
        [HttpGet]
        public async Task<ActionResult> GetAllOrder (int Id)
        {
            var query = new GetAllOrdersQuery();

            var result = await mediator.Send(query);

            return Ok(result);
        } 

       
    }
}