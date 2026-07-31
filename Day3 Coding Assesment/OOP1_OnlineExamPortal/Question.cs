namespace OOP1_OnlineExamPortal;

public abstract class Question
{
    public string questionText;
    public string catagory;
    public string topic;

    public Question(string qtext , string cat , string top)
    {
        questionText = qtext;
        catagory = cat;
        topic = top;
    }

    public abstract string GetType2();
}
