namespace eraasoft_task5.Classes;

public class ChooseOneQuestion : Question
{
    public override void Display()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Body);

        foreach (Answer answer in Answers)
            Console.WriteLine(answer);
    }
}