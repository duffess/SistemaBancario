using Microsoft.EntityFrameworkCore;
using SistemaBancario.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaBancario.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BancoContext _context;

        public IndexModel(BancoContext context)
        {
            _context = context;
        }

        public List<ContaBancaria> Contas { get; set; }

        public async Task OnGetAsync()
        {
            Contas = await _context.Contas.ToListAsync();
        }
    }
}