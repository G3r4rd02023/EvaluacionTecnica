using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Data.Entities
{
    public class AccountType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Cuenta")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
