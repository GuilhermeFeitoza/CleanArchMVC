﻿using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product:Entity
    {

        public string Name { get; private set; } 
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock {  get; private set; }

        public string Image { get; private set; }

        public int CategoryId { get;  set; }
        public Category Category { get; set; }


        private void ValidateDomain(string name, string description, decimal price, int stock , string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");

            DomainExceptionValidation.When(name.Length <3, "Name is too short");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "description is required");

            DomainExceptionValidation.When(description.Length < 3, "description is too short");

            DomainExceptionValidation.When(price < 0, "Invalid price value");
            DomainExceptionValidation.When(stock < 0, "Invalid stock value");

            DomainExceptionValidation.When(image.Length > 250, "Invalid image name, too long");


            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;


        }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name,description,price,stock,image);
        }

        public Product(int id,string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id Value");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {

            ValidateDomain(name,description,price,stock,image);
            CategoryId = categoryId;

        }
    }
}
