using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{   //sealed faz com que a classse não possa ser herdada
   public sealed class Category : Entity
    {
        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id Value");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name) {

            ValidateDomain(name);
        
        
        }
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required");

            DomainExceptionValidation.When(name.Length <3, "Invalid name. Name is too short");

            Name = name;
        }

      
     

        public string Name { get; private set; }    
        public ICollection<Product> Products { get; private set; }
    }
}
