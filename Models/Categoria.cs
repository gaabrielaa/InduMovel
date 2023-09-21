using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId {get; set;}
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Categoria")]
        [MinLength(3,ErrorMessage= "categoria deve ter no mínimo {1} caracter")]
        [MaxLength(20, ErrorMessage = "Categoria deve ter no máximo {1} caracter")]
        public string Nome {get; set;}
        public List<Movel> Moveis {get; set;}
    }
}