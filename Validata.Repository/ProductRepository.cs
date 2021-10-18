using System;
using System.Collections.Generic;
using System.Text;
using Validata.Contract;
using Validata.Entities;
using Validata.Entities.Models;

namespace Validata.Repository
{
   public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {

        }
    }
}
