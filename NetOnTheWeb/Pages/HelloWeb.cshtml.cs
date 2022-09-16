using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOnTheWeb.Models;
namespace NetOnTheWeb.Pages


{
    
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; } = "In Page model: ";
        public Student Michael = new("Michael", 1, 1 );
        public void OnGet()
        {
        }

       
    }
}
