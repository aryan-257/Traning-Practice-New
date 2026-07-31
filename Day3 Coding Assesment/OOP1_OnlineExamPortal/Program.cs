using OOP1_OnlineExamPortal;

ExamPortal portal = new ExamPortal();

portal.AddQuestion(new MCQQuestion("What is OOP?","General","OOPS", new List<string>{"Inheritance","Abstraction","Both","None"},2));
portal.AddQuestion(new MCQQuestion("What is a class?","General","OOPS", new List<string>{"Object","Blueprint","Method","None"},1));
portal.AddQuestion(new ParagraphQuestion("Explain polymorphism","Advanced","OOPS",200));
portal.AddQuestion(new MCQQuestion("What is HTTP?","Networking","Web", new List<string>{"Protocol","Language","Tool","None"},0));
portal.AddQuestion(new ParagraphQuestion("Explain REST API","Advanced","Web",300));

Console.WriteLine("Total Questions : " + portal.TotalQuestions());

Console.WriteLine("\nQuestions by topic - OOPS :");
foreach(var q in portal.GetByTopic("OOPS"))
    Console.WriteLine(" - " + q.questionText + " [" + q.GetType2() + "]");

Console.WriteLine("\nQuestions by topic OOPS and category Advanced :");
foreach(var q in portal.GetByTopicAndCategory("OOPS","Advanced"))
    Console.WriteLine(" - " + q.questionText + " [" + q.GetType2() + "]");
