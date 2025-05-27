using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Models
{
    public class ContaBancaria
    {
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }

        public decimal Saldo { get; set; }

        public List<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}