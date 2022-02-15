using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionTecnica.Data.Entities
{
    public class Gender
    {
        public int Id { get; set; }

        [Display(Name = "Genero")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}
