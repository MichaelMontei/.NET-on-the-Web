using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOnTheWeb.Models;
namespace NetOnTheWeb.Pages
{
    public class TeachersModel : PageModel
    {
        public string Message { get; set; } = "In Teachers model: ";
        public Teacher Sicco = new("Sicco", 1, 1 );
        public Teacher Tim = new("Tim", 2, 2 );
        public void OnGet()
        {
        }
    }
}
