using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetOnTheWeb.Models;
namespace NetOnTheWeb.Pages
{
    public class StudentsModel : PageModel
    {
        public string Message { get; set; } = "In Students model: ";
        public Student Michael = new("Michael", 1, 1 );
        public Student Joske = new("Joske", 2, 2 );
        public Student Franske = new("Franske", 3, 3 );
        public Student Louike = new("Louike", 4, 4 );
        public Student Jefke = new("Jefke", 5, 5 );
        public void OnGet()
        {
        }
    }
}
