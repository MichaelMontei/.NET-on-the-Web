# .NET-on-the-Web

First thing first! We learned how to link these pages in .Net Web application and show them with the view in our browser. 
The next step I made three classes in my program: Students, Teachers and Clasrooms.
```js
namespace NetOnTheWeb.Models;
public class Student

{
    public string _name;
    public int _id;
    public int _classId;
    
    public Student(string name, int id, int classId)
    {
        _name = name;
        _id = id;
        _classId = classId;
    }
}
```
After that I imported those classes to the cshtml.cs file to make new objects deriving from those classes. 
```js
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
```
Then we made sure we could view everything on our page by adding the Model to the View and made a list of all Students/Teachers and/or Classrooms.
```js
@page
@model StudentsModel
@{
}
<h1>Students Page</h1>
<p>@Model.Message the time is @DateTime.Now</p>
<br/>

<h3>Our students List: </h3>

<ul>
    <li>
        <p>Name: @Model.Michael._name, Id: @Model.Michael._id, ClassID: @Model.Michael._classId</p>
    </li>
    <li>
        <p>Name: @Model.Joske._name, Id: @Model.Joske._id, ClassID: @Model.Joske._classId</p>
    </li>
    <li>
        <p>Name: @Model.Franske._name, Id: @Model.Franske._id, ClassID: @Model.Franske._classId</p>
    </li>
    <li>
        <p>Name: @Model.Louike._name, Id: @Model.Louike._id, ClassID: @Model.Louike._classId</p>
    </li>
    <li>
        <p>Name: @Model.Jefke._name, Id: @Model.Jefke._id, ClassID: @Model.Jefke._classId</p>
    </li>
</ul>

```
At last we made the routing complete in our program in our Layout.cshtml file and we got the following:

![Students](\images\Students.JPG)
