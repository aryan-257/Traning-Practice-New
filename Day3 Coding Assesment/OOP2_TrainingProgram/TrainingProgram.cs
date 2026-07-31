namespace OOP2_TrainingProgram;

public class TrainingProgram
{
    public string programName;
    public string courseName;
    public string topic;
    public DateTime scheduleDate;
    public TrainingProvider provider;

    public TrainingProgram(string pname , string course , string top , DateTime date , TrainingProvider prov)
    {
        programName = pname;
        courseName = course;
        topic = top;
        scheduleDate = date;
        provider = prov;
    }
}
