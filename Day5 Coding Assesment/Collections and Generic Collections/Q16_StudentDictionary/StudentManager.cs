namespace Q16_StudentDictionary;

public class StudentManager
{
    private Dictionary<int , Student> students = new Dictionary<int , Student>();

    public void Add(Student s)
    {
        if(students.ContainsKey(s.id)) { Console.WriteLine("ID already exists."); return; }
        students[s.id] = s;
        Console.WriteLine("Added : " + s);
    }

    public void Update(int id , string name , double marks)
    {
        if(!students.ContainsKey(id)) { Console.WriteLine("Student not found."); return; }
        students[id].name  = name;
        students[id].marks = marks;
        Console.WriteLine("Updated : " + students[id]);
    }

    public void Delete(int id)
    {
        if(!students.ContainsKey(id)) { Console.WriteLine("Student not found."); return; }
        Console.WriteLine("Deleted : " + students[id]);
        students.Remove(id);
    }

    public void DisplayAll()
    {
        if(students.Count == 0) { Console.WriteLine("No students."); return; }
        foreach(var s in students.Values)
            Console.WriteLine("  " + s);
    }
}
