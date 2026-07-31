namespace OOP5_SurgeonManagement;

public class Hospital
{
    public string hospitalName;
    public List<Patient> patients = new List<Patient>();

    public Hospital(string name)
    {
        hospitalName = name;
    }

    public void AdmitPatient(Patient p)
    {
        patients.Add(p);
    }

    public int TotalPatientsOperated()
    {
        return patients.Count;
    }

    public List<Patient> GetPatientsBySurgeon(int surgeonId)
    {
        List<Patient> res = new List<Patient>();
        foreach(var p in patients)
        {
            if(p.operatedBy.surgeonId == surgeonId)
                res.Add(p);
        }
        return res;
    }

    public List<Patient> GetPatientsByWard(string ward)
    {
        List<Patient> res = new List<Patient>();
        foreach(var p in patients)
        {
            if(p.wardName.ToLower() == ward.ToLower())
                res.Add(p);
        }
        return res;
    }
}
