

using System.Collections.Generic;

namespace Millioner;

public class QuestionData
{
    public List<string> questionList = new List<string>();
    public List<string> answerList = new List<string>();

    public QuestionData()
    {

    }
    public void AddQuestionsToList()
    {
        this.questionList.Add("Какой советский космонавт получил первую космическую почту?");

        this.answerList.Add("Владимир Шаталов");
        this.answerList.Add("Владимир Гарбунов");
        this.answerList.Add("Александр Шаталов");
        this.answerList.Add("Никита Шаталов");
        
    }
}
