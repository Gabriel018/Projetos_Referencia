using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prover_Web.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF requerido")]
        [MinLength(11, ErrorMessage = "CPF precisa possuir 11 numeros"), MaxLength(11, ErrorMessage = "CPF precisa possuir 11 numeros")]
        [RegularExpression(@"\d+", ErrorMessage = "Somente números são permitidos")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Telefone requerido")]
        [RegularExpression(@"\d+", ErrorMessage = "Somente números são permitidos")]
        [MinLength(10, ErrorMessage = "Telefone precisa possuir 10 numeros"), MaxLength(11, ErrorMessage = "CPF precisa possuir 11 numeros")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Descriçao requerido")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Categoria requerida")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Rendimento requerido")]

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rendimento { get; set; }

  
    }
}
