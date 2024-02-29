using System.ComponentModel.DataAnnotations;

namespace CleanArchMvc.Application.DTOS
{
    public class CategoryDTO
    {

        public int ID { get; set; }
        [Required(ErrorMessage ="The name is Required")]
        [MinLength(3)]
        [MaxLength(100)]

        public string Name { get; set; }   
    }
}
