﻿using CleanArchMvc.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetById(int id);

    

        //Task<ProductDTO> GetProductCategory(int? id);

        Task Add(ProductDTO productDTO);

        Task Remove(int id);    

        Task Update(ProductDTO productDTO);

    }
}
