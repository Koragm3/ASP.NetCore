using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Brands { get; set; } =
        [
            "images/brands/brand1.svg",
            "images/brands/brand2.svg",
            "images/brands/brand3.svg",
            "images/brands/brand4.svg",
        ];


        public void OnGet()
        {
        }
    }
}
