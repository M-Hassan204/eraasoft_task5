using System.Text.Json.Serialization;

namespace eraasoft_task5.Classes;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(TrueFalseQuestion), "TrueFalse")]
[JsonDerivedType(typeof(ChooseOneQuestion), "ChooseOne")]
[JsonDerivedType(typeof(ChooseAllQuestion), "ChooseAll")]
// دول من شات تعبت وانا بحاول الاقي حل لمشكله ال Load و Save و ال JsonSerializer
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