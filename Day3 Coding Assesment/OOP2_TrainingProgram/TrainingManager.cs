namespace OOP2_TrainingProgram;

public class TrainingManager
{
    public List<TrainingProgram> programs = new List<TrainingProgram>();

    public void AddProgram(TrainingProgram p)
    {
        programs.Add(p);
    }

    public List<TrainingProgram> GetByProvider(string providerName)
    {
        List<TrainingProgram> res = new List<TrainingProgram>();
        foreach(var p in programs)
        {
            if(p.provider.name.ToLower() == providerName.ToLower())
                res.Add(p);
        }
        return res;
    }

    public List<TrainingProgram> GetByDate(DateTime date)
    {
        List<TrainingProgram> res = new List<TrainingProgram>();
        foreach(var p in programs)
        {
            if(p.scheduleDate.Date == date.Date)
                res.Add(p);
        }
        return res;
    }

    public List<TrainingProgram> GetByCourse(string course)
    {
        List<TrainingProgram> res = new List<TrainingProgram>();
        foreach(var p in programs)
        {
            if(p.courseName.ToLower() == course.ToLower())
                res.Add(p);
        }
        return res;
    }
}
