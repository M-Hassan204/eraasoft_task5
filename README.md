# 📚 Examination System

A Console Application built with **C# (.NET)** that allows teachers to create and manage exams using Object-Oriented Programming principles.

---

## 📖 Overview
-md file maded by AI (معتقدش اني اقدر اعمل md بالحلاوه دي 😂😂)
-This project simulates a simple examination system consisting of two parts:

- 👨‍🏫 **Teacher System** *(Completed)*
- 👨‍🎓 **Student System** *(In Progress)*

The current version focuses on the teacher side, where instructors can create, manage, and export exam questions.

---

## ✨ Features

### 👨‍🏫 Teacher System

- ✅ Add new questions
- ✅ Support multiple question types
  - True / False
  - Choose One
  - Choose All
- ✅ Assign marks for each question
- ✅ Assign difficulty level
  - Easy
  - Medium
  - Hard
- ✅ Display all questions
- ✅ Save questions to a JSON file
- ✅ Automatically load questions when the application starts
- ✅ Polymorphic JSON Serialization
- ✅ Object-Oriented Design using Inheritance and Polymorphism

---

## 🏗️ Project Structure

```
Question (Abstract)
│
├── TrueFalseQuestion
├── ChooseOneQuestion
└── ChooseAllQuestion
```

Other classes:

- QuestionList
- Answer
- AnswerList
- QuestionFileManager

---

## 💾 Data Storage

Questions are stored in a JSON file.

Example:

```json
{
  "$type": "ChooseOne",
  "Header": "Q1",
  "Body": "What is OOP?",
  "Marks": 2,
  "Difficulty": "Medium"
}
```

---

## 🛠️ Technologies Used

- C#
- .NET
- System.Text.Json
- Git
- GitHub
- Object-Oriented Programming (OOP)

---

## 🚧 Current Status

| Module | Status |
|---------|--------|
| Teacher System | ✅ Completed |
| JSON Save / Load | ✅ Completed |
| Difficulty Levels | ✅ Completed |
| Student System | 🚧 In Progress |

---

## 📌 Upcoming Features

- Student Examination System
- Calculate Final Score
- Timer for Exams
- Random Question Selection
- Exam Result Summary
- Student Result Storage

---

## 📷 Preview

Teacher Menu

```
1- Add New Question
2- Show All Questions
3- Save Questions
4- Exit
```

---

## 🚀 How to Run

```bash
git clone https://github.com/M-Hassan204/eraasoft_task5.git
```

Open the solution using **Visual Studio** and run the project.

---

## 👨‍💻 Author

**Mohammed Hassan**

GitHub:
https://github.com/M-Hassan204
