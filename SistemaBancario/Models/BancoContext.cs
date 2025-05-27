using Microsoft.EntityFrameworkCore;

namespace SistemaBancario.Models
{
    public class BancoContext : DbContext
    {
        public DbSet<ContaBancaria> Contas { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {
        }
    }
}