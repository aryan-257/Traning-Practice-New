namespace OOP5_SurgeonManagement;

public class Patient
{
    public string name;
    public int patientId;
    public string wardName;
    public Surgeon operatedBy;

    public Patient(string n , int id , string ward , Surgeon surgeon)
    {
        name = n;
        patientId = id;
        wardName = ward;
        operatedBy = surgeon;
    }
}
