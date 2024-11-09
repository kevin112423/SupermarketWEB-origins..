using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SupermarketWEB_origins.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnpostAsync()
        {
            await HttpContext.SignOutAsync("MyCookiesAuth");
            return RedirectToPage("/Index");
        }
    }
}
