namespace Q10_GradeNotification;

public class Student
{
    public string name;
    private int grade;

    public event Action<int>? GradeChanged;

    public Student(string n , int g)
    {
        name  = n;
        grade = g;
    }

    public int GetGrade() => grade;

    public void UpdateGrade(int newGrade)
    {
        grade = newGrade;
        GradeChanged?.Invoke(grade);
    }
}
