namespace Q16_StudentDictionary;

public class Student
{
    public int    id;
    public string name;
    public double marks;

    public Student(int i , string n , double m)
    {
        id = i; name = n; marks = m;
    }

    public override string ToString()
    {
        return $"ID:{id} | Name:{name} | Marks:{marks}";
    }
}
