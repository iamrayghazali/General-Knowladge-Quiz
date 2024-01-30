internal class Questions
{
    public string Question { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string Answer { get; set; }

    public Questions(string question, string optionA, string optionB, string optionC,string answer)
    {
        Question = question;
        OptionA = optionA;
        OptionB = optionB;
        OptionC = optionC;
        Answer = answer;

    }
}

    