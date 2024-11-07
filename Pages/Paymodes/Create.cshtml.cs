using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB_origins.Data;
using SupermarketWEB_origins.Models;

namespace SupermarketWEB_origins.Pages.PayMode
{
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;

        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Paymode Paymode { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Paymodes == null || Paymode == null)
            {
                return Page();
            }

            _context.Paymodes.Add(Paymode);
            await _context.SaveChangesAsync();

            return RedirectToPage("./index");

        }
    }
}
