using OOP2_TrainingProgram;

var p1 = new TrainingProvider("TechLearn","Bangalore");
var p2 = new TrainingProvider("SkillUp","Mumbai");

TrainingManager mgr = new TrainingManager();
mgr.AddProgram(new TrainingProgram("DotNet Basics","CSharp","Syntax",new DateTime(2026,7,28),p1));
mgr.AddProgram(new TrainingProgram("Advanced CSharp","CSharp","LINQ",new DateTime(2026,7,28),p1));
mgr.AddProgram(new TrainingProgram("Java Fundamentals","Java","OOP",new DateTime(2026,7,29),p2));
mgr.AddProgram(new TrainingProgram("Spring Boot","Java","REST",new DateTime(2026,7,30),p2));
mgr.AddProgram(new TrainingProgram("React Basics","JavaScript","Frontend",new DateTime(2026,7,28),p1));

Console.WriteLine("Programs by TechLearn :");
foreach(var p in mgr.GetByProvider("TechLearn"))
    Console.WriteLine(" - " + p.programName + " | " + p.courseName);

Console.WriteLine("\nPrograms on 28-July-2026 :");
foreach(var p in mgr.GetByDate(new DateTime(2026,7,28)))
    Console.WriteLine(" - " + p.programName + " by " + p.provider.name);

Console.WriteLine("\nPrograms for CSharp course :");
foreach(var p in mgr.GetByCourse("CSharp"))
    Console.WriteLine(" - " + p.programName + " | topic: " + p.topic);
