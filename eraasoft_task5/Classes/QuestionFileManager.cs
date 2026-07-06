using System.IO;
using System.Text.Json;

namespace eraasoft_task5.Classes;

public static class QuestionFileManager
{
    public static void Save(QuestionList questions)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(questions, options);

        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Questions.json");

        File.WriteAllText(path, json);

        Console.WriteLine("\nQuestions Saved Successfully!");
        Console.WriteLine($"Location: {path}");
    }
}