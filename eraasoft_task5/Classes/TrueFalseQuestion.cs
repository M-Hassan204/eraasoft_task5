namespace eraasoft_task5.Classes;

public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion()
    {
        Answers.Add(new Answer
        {
            Id = 1,
            Text = "True"
        });

        Answers.Add(new Answer
        {
            Id = 2,
            Text = "False"
        });
    }

    public override void Display()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Body);

        foreach (Answer answer in Answers)
            Console.WriteLine(answer);
    }
}