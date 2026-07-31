namespace OOP1_OnlineExamPortal;

public class ParagraphQuestion : Question
{
    public int maxWords;

    public ParagraphQuestion(string qtext , string cat,string top, int mwords) : base(qtext,cat,top)
    {
        maxWords = mwords;
    }

    public override string GetType2()
    {
        return "Paragraph";
    }
}
