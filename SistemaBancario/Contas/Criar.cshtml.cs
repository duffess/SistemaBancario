using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaBancario.Models;

namespace SistemaBancario.Pages.Contas
{
    public class CriarModel : PageModel
    {
        private readonly BancoContext _context;

        public CriarModel(BancoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContaBancaria Conta { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult>
    OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Conta.Saldo = 0m; // Saldo inicial é 0
            _context.Contas.Add(Conta);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
