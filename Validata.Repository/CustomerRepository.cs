using System;
using System.Collections.Generic;
using System.Text;
using Validata.Contract;
using Validata.Entities;
using Validata.Entities.Models;

namespace Validata.Repository
{
    public class CustomerRepository:RepositoryBase<Customer>,ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext)
            :base (repositoryContext)
        {

        }
    }
}
