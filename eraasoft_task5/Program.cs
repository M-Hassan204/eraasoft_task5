using eraasoft_task5.Classes;

namespace eraasoft_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionList questions = QuestionFileManager.Load();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("========== Teacher System ==========");
                Console.WriteLine("1- Add New Question");
                Console.WriteLine("2- Show All Questions");
                Console.WriteLine("3- Save Questions");
                Console.WriteLine("4- Exit");

                Console.Write("\nChoose: ");

                int menuChoice = int.Parse(Console.ReadLine()!);

                switch (menuChoice)
                {
                    case 1:

                        Console.Write("How many questions do you want to add? ");
                        int count = int.Parse(Console.ReadLine()!);

                        for (int i = 0; i < count; i++)
                        {
                            Console.Clear();

                            Console.WriteLine($"========== Question {questions.Count + 1} ==========");
                            Console.WriteLine("1- True / False");
                            Console.WriteLine("2- Choose One");
                            Console.WriteLine("3- Choose All");
                            Console.Write("Choose Question Type: ");

                            int type = int.Parse(Console.ReadLine()!);

                            Question q;

                            switch (type)
                            {
                                case 1:
                                    q = new TrueFalseQuestion();
                                    break;

                                case 2:
                                    q = new ChooseOneQuestion();
                                    break;

                                case 3:
                                    q = new ChooseAllQuestion();
                                    break;

                                default:
                                    Console.WriteLine("Invalid Choice!");
                                    Console.ReadKey();
                                    continue;
                            }

                            q.Id = questions.Count + 1;

                            Console.Write("Header: ");
                            q.Header = Console.ReadLine()!;

                            Console.Write("Question: ");
                            q.Body = Console.ReadLine()!;

                            Console.Write("Marks: ");
                            q.Marks = int.Parse(Console.ReadLine()!);

                            Console.WriteLine("Choose Difficulty:");
                            Console.WriteLine("1- Easy");
                            Console.WriteLine("2- Medium");
                            Console.WriteLine("3- Hard");
                            Console.Write("Your Choice: ");

                            int difficulty = int.Parse(Console.ReadLine()!);

                            switch (difficulty)
                            {
                                case 1:
                                    q.Difficulty = "Easy";
                                    break;

                                case 2:
                                    q.Difficulty = "Medium";
                                    break;

                                case 3:
                                    q.Difficulty = "Hard";
                                    break;

                                default:
                                    q.Difficulty = "Unknown";
                                    break;
                            }

                            if (q is TrueFalseQuestion)
                            {
                                Console.WriteLine("1- True");
                                Console.WriteLine("2- False");

                                Console.Write("Correct Answer: ");
                                int correct = int.Parse(Console.ReadLine()!);

                                q.Answers[correct - 1].IsCorrect = true;
                            }
                            else if (q is ChooseOneQuestion)
                            {
                                Console.Write("Number of Choices: ");
                                int answerCount = int.Parse(Console.ReadLine()!);

                                for (int j = 0; j < answerCount; j++)
                                {
                                    Console.Write($"Answer {j + 1}: ");

                                    q.Answers.Add(new Answer
                                    {
                                        Id = j + 1,
                                        Text = Console.ReadLine()!
                                    });
                                }

                                Console.Write("Correct Answer Number: ");
                                int correct = int.Parse(Console.ReadLine()!);

                                q.Answers[correct - 1].IsCorrect = true;
                            }
                            else if (q is ChooseAllQuestion)
                            {
                                Console.Write("Number of Choices: ");
                                int answerCount = int.Parse(Console.ReadLine()!);

                                for (int j = 0; j < answerCount; j++)
                                {
                                    Console.Write($"Answer {j + 1}: ");

                                    q.Answers.Add(new Answer
                                    {
                                        Id = j + 1,
                                        Text = Console.ReadLine()!
                                    });
                                }

                                Console.Write("How many correct answers? ");
                                int correctCount = int.Parse(Console.ReadLine()!);

                                for (int j = 0; j < correctCount; j++)
                                {
                                    Console.Write($"Correct Answer #{j + 1}: ");
                                    int index = int.Parse(Console.ReadLine()!);

                                    q.Answers[index - 1].IsCorrect = true;
                                }
                            }

                            questions.Add(q);
                        }

                        Console.WriteLine("\nQuestions Added Successfully.");
                        Console.ReadKey();
                        break;
                    case 2:

                        Console.Clear();

                        Console.WriteLine("========== All Questions ==========");

                        if (questions.Count == 0)
                        {
                            Console.WriteLine("No Questions Found.");
                        }
                        else
                        {
                            foreach (Question q in questions)
                            {
                                Console.WriteLine($"ID : {q.Id}");
                                Console.WriteLine($"Header : {q.Header}");
                                Console.WriteLine($"Question : {q.Body}");
                                Console.WriteLine($"Marks : {q.Marks}");
                                Console.WriteLine($"Difficulty : {q.Difficulty}");

                                Console.WriteLine("Answers:");

                                foreach (Answer a in q.Answers)
                                {
                                    Console.WriteLine($"{a.Id}. {a.Text} {(a.IsCorrect ? "(Correct)" : "")}");
                                }

                                Console.WriteLine("-------------------------------------------");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 3:

                        if (questions.Count == 0)
                        {
                            Console.WriteLine("There are no questions to save.");
                        }
                        else
                        {
                            QuestionFileManager.Save(questions);
                            Console.WriteLine("Questions Saved Successfully.");
                        }

                        Console.ReadKey();
                        break;

                    case 4:

                        Console.WriteLine("Good Bye...");
                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}