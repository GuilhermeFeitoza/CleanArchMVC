using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTOS
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; private set; }
        [Required(ErrorMessage = "The description is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Description { get; private set; }

        [Required(ErrorMessage = "The price is Required")]
      
        public decimal Price { get; private set; }

        [Required(ErrorMessage = "The stock is Required")]
         public int Stock { get; private set; }

        public string Image { get; private set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
