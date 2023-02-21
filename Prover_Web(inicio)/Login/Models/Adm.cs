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
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Telefone requerido")]
        public string Telefone { get; set; }

    }
}