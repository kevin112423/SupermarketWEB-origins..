using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB_origins.Models;
using System.Security.Claims;

namespace SupermarketWEB_origins.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]

        public User User { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnpostAsync()
        {
            if (!ModelState.IsValid) return Page();
            if (User.Email == "correo@gmail.com" && User.Password == "12345")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new  Claim(ClaimTypes.Email,User.Password),
                };
                var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
                ClaimsPrincipal claimsprincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookiesAuth", claimsprincipal);
                return RedirectToPage("/index");
            }
            return Page();
        }
    }
}
