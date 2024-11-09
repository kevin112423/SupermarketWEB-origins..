using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB_origins.Models;

namespace SupermarketWEB_origins.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]

        public User User { get; set; }
        public void OnGet()
        {
        }
    }
}
