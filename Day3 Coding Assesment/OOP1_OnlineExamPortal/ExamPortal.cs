namespace OOP1_OnlineExamPortal;

public class ExamPortal
{
    public List<Question> questionList = new List<Question>();

    public void AddQuestion(Question q)
    {
        questionList.Add(q);
    }

    public int TotalQuestions()
    {
        return questionList.Count;
    }

    public List<Question> GetByTopic(string top)
    {
        List<Question> result = new List<Question>();
        foreach(var q in questionList)
        {
            if(q.topic.ToLower() == top.ToLower())
                result.Add(q);
        }
        return result;
    }

    public List<Question> GetByTopicAndCategory(string top , string cat)
    {
        List<Question> result = new List<Question>();
        foreach(var q in questionList)
        {
            if(q.topic.ToLower() == top.ToLower() && q.catagory.ToLower() == cat.ToLower())
                result.Add(q);
        }
        return result;
    }
}
