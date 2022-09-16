namespace NetOnTheWeb.Models;
public class Classroom  

{
    public string _name;
    public int _id;
    public int _classId;
    
    public Classroom(string name, int id, int classId)
    {
        _name = name;
        _id = id;
        _classId = classId;
    }
}