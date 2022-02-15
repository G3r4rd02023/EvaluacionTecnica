using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }

        [Display(Name = "Numero de Cuenta")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string AccountNumber { get; set; }

        [Display(Name = "Tipo de Cuenta")]
        public CurrencyType CurrencyType { get; set; }

        [Display(Name = "Saldo")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public decimal Balance { get; set; }

        [Display(Name = "Estado")]
        public Status Status { get; set; }

        [Display(Name = "Tipo de Cuenta")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Cliente")]
        public Customer Customer { get; set; }


    }
}
