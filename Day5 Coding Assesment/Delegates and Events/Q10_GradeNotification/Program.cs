using Q10_GradeNotification;

Student s = new Student("Aryan" , 75);

s.GradeChanged += (newGrade) =>
{
    Console.WriteLine($"Notification : {s.name}'s grade changed to {newGrade}");
    if(newGrade >= 90)
        Console.WriteLine("Excellent performance!");
    else if(newGrade >= 75)
        Console.WriteLine("Good performance!");
    else
        Console.WriteLine("Needs improvement.");
};

Console.WriteLine("Initial grade : " + s.GetGrade());
s.UpdateGrade(92);
s.UpdateGrade(65);
s.UpdateGrade(80);
