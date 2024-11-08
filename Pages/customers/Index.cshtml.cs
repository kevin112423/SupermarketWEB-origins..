using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB_origins.Data;
using SupermarketWEB_origins.Models;

namespace SupermarketWEB_origins.Pages.customers
{
    public class IndexModel : PageModel
    {
		private readonly SupermarketContext _context;

		public IndexModel(SupermarketContext context)
		{
			_context = context;
		}
		public IList<Customer> Customers { get; set; } = default!;

		public async Task OnGetAsync()
		{
			if (_context.Customers   != null) 
			{
				Customers = await _context.Customers.ToListAsync();
			}

		}
	}
}
