namespace OOP1_OnlineExamPortal;

public class MCQQuestion : Question
{
    public List<string> options;
    public int correctAns;

    public MCQQuestion(string qtext,string cat,string top, List<string> opts , int ans) : base(qtext,cat,top)
    {
        options = opts;
        correctAns = ans;
    }

    public override string GetType2()
    {
        return "MCQ";
    }
}
