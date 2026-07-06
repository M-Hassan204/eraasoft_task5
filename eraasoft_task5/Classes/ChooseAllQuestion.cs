namespace eraasoft_task5.Classes;

public class ChooseAllQuestion : Question
{
    public override void Display()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Body);

        foreach (Answer answer in Answers)
            Console.WriteLine(answer);
    }
}