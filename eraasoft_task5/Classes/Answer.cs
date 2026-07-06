namespace eraasoft_task5.Classes;

public class Answer
{
    public int Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public bool IsCorrect { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Text}";
    }
}