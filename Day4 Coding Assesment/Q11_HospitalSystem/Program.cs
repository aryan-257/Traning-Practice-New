using Q11_HospitalSystem;

var patients = new HospitalRepository<Patient>();
var doctors  = new HospitalRepository<Doctor>();

patients.Add(new Patient("P1001","Aryan",25,"Fever",1500));
patients.Add(new Patient("P1002","Sneha",30,"Fracture",8000));
patients.Add(new Patient("P1003","Rahul",45,"Diabetes",3000));

doctors.Add(new Doctor("D001","Dr.Sharma",45,"Cardiology"));
doctors.Add(new Doctor("D002","Dr.Mehta",38,"Orthopedics"));

Console.WriteLine("Direct access : ");
patients["P1001"].Print();

Console.WriteLine("\nAll Patients :");
patients.GetAll().ForEach(p => p.Print());

Console.WriteLine("\nAll Doctors :");
doctors.GetAll().ForEach(d => d.Print());

var dashboard = new
{
    TotalPatients = patients.GetAll().Count,
    TotalDoctors  = doctors.GetAll().Count,
    Revenue       = patients.GetAll().Sum(p => p.billAmount)
};

Console.WriteLine($"\n=== Dashboard ===");
Console.WriteLine($"TotalPatients = {dashboard.TotalPatients}");
Console.WriteLine($"TotalDoctors  = {dashboard.TotalDoctors}");
Console.WriteLine($"Revenue       = {dashboard.Revenue}");
