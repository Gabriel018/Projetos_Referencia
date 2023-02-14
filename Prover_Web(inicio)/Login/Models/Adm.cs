using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prover_Web.Models
{
    public class Adm
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF requerido")]
        [MinLength(11, ErrorMessage = "CPF precisa ter 11  digitos")]
        [MaxLength(11, ErrorMessage = "CPF precisa ter 11 digitos")]
        [RegularExpression(@"\d+", ErrorMessage = "Somente números são permitidos")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Telefone requerido")]
        [RegularExpression(@"\d+", ErrorMessage = "Somente números são permitidos")]
        public string Telefone { get; set; }

    }
}