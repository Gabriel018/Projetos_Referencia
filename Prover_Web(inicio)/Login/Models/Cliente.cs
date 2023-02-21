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
        
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Telefone requerido")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Descriçao requerido")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Categoria requerida")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Rendimento requerido")]
        public string Rendimento { get; set; }

  
    }
}
