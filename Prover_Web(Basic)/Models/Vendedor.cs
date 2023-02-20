using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Prover_Web.Models
{
    public class Vendedor
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome requerido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF requerido")]
        [MinLength(11, ErrorMessage = "CPF precisa possuir 11 numeros"), MaxLength(11, ErrorMessage = "CPF precisa possuir 11 numeros")]
        [RegularExpression(@"\d+", ErrorMessage = "Somente números são permitidos")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Telefone requerido")]
        [MinLength(11, ErrorMessage = "Telefone precisa possuir 11 numeros"), MaxLength(11, ErrorMessage = "Telefone precisa possuir 11 numeros")]
        [RegularExpression(@"\d+", ErrorMessage = "Somente números são permitidos")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Descricao requerida")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Categoria requerida")]
        public string Categoria { get; set; }

    }
}
