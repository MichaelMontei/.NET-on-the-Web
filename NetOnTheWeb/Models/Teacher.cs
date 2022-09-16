namespace NetOnTheWeb.Models;
public class Teacher

{
    public string _name;
    public int _id;
    public int _classId;
    
    public Teacher(string name, int id, int classId)
    {
        _name = name;
        _id = id;
        _classId = classId;
    }
}