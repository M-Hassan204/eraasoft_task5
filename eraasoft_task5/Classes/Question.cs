namespace eraasoft_task5.Classes;

public abstract class Question
{
    public int Id { get; set; }

    public string Header { get; set; } = string.Empty;

    public string Body { get; set; } = string.Empty;

    public int Marks { get; set; }

    public string Difficulty { get; set; } = string.Empty;

    public AnswerList Answers { get; set; } = new();

    public Answer? CorrectAnswer { get; set; }

    public abstract void Display();
}