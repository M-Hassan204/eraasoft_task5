using System.IO;
using System.Text.Json;

namespace eraasoft_task5.Classes;

public static class QuestionFileManager
{
    private static readonly string path = Path.GetFullPath(
        Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            @"..\..\..\..\Questions.json"));

    public static void Save(QuestionList questions)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(questions, options);

        File.WriteAllText(path, json);

        Console.WriteLine("\nQuestions Saved Successfully!");
        Console.WriteLine($"Saved To: {path}");
    }

    public static QuestionList Load()
    {
        if (!File.Exists(path))
        {
            return new QuestionList();
        }

        string json = File.ReadAllText(path);

        QuestionList? questions =
            JsonSerializer.Deserialize<QuestionList>(json);

        return questions ?? new QuestionList();
    }
}