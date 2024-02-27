﻿using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {


        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductCategoryAsync(int? id);
        Task<Product> GetByIdAsync(int? id);
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<Product> Remove(Product product);
    }
}
