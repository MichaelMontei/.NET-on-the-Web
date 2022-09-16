using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOnTheWeb.Models;
namespace NetOnTheWeb.Pages
{
    public class ClassRoomModel : PageModel
    {
        public string Message { get; set; } = "In Classroom model: ";
        public Classroom Apollo = new("Apollo", 1, 1 );
        public Classroom Neptune = new("Neptune", 2, 2 );
        public Classroom Saturn = new("Saturn", 3, 3 );
        
        public void OnGet()
        {
        }
    }
}

