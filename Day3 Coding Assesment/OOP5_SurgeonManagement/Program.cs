using OOP5_SurgeonManagement;

var s1 = new SeniorSurgeon("Dr. Sharma",1);
var s2 = new NonSeniorSurgeon("Dr. Mehta",2);

Hospital h = new Hospital("Apollo");
h.AdmitPatient(new Patient("Ravi",1,"ICU",s1));
h.AdmitPatient(new Patient("Sita",2,"General",s1));
h.AdmitPatient(new Patient("Mohan",3,"ICU",s2));
h.AdmitPatient(new Patient("Geeta",4,"Cardiology",s2));

Console.WriteLine("Total patients operated : " + h.TotalPatientsOperated());

Console.WriteLine("\nPatients operated by Dr.Sharma (id 1) :");
foreach(var p in h.GetPatientsBySurgeon(1))
    Console.WriteLine(" - " + p.name + " Ward: " + p.wardName);

Console.WriteLine("\nPatients in ICU ward :");
foreach(var p in h.GetPatientsByWard("ICU"))
    Console.WriteLine(" - " + p.name + " Surgeon: " + p.operatedBy.name);
