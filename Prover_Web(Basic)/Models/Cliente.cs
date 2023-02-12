using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prover_Web.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rendimento { get; set; }


    }
}
