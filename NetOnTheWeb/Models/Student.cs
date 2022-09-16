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
