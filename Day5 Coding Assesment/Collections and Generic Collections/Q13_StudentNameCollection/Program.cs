using System.Collections;

ArrayList studentNames = new ArrayList();

void AddStudent(string name)
{
    foreach(string s in studentNames)
    {
        if(s.ToLower() == name.ToLower())
        {
            Console.WriteLine($"'{name}' already exists.");
            return;
        }
    }
    studentNames.Add(name);
    Console.WriteLine($"'{name}' added.");
}

void DisplayAll()
{
    if(studentNames.Count == 0) { Console.WriteLine("No students."); return; }
    Console.WriteLine("Students :");
    foreach(string s in studentNames)
        Console.WriteLine("  - " + s);
}

AddStudent("Aryan");
AddStudent("Sneha");
AddStudent("Rahul");
AddStudent("aryan");
AddStudent("Priya");

DisplayAll();
Console.WriteLine("Total : " + studentNames.Count);
