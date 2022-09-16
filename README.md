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
Then we made sure we could view everything on our page by adding the Model to the View and made a list of all Students/Teachers and/or Classrooms.
At last we made the routing complete in our program in our Layout.cshtml file and we got the following:
