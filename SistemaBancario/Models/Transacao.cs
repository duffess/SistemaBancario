using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Models
{
    public class Transacao
    {
        public int Id { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public int ContaBancariaId { get; set; } 
        public ContaBancaria ContaBancaria { get; set; }
    }
}