using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "Nome não pode ter mais de 50 caracteres")]
        [MinLength(5, ErrorMessage = "Nome deve ter pelo menos 5 caracteres")]

        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}