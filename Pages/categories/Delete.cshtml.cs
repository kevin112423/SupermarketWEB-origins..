using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB_origins.Data;
using SupermarketWEB_origins.Models;

namespace SupermarketWEB_origins.Pages.categories
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;

        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                Category = category;
            }
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);

            if (category != null)
            {
                Category = category;
                _context.Categories.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");

        }
    }
}
