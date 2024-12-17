using System;
using System.Collections.Generic;

namespace QuizApp
{
    class QuizProgram
    {
        static void Main()
        {
            var quiz = new List<Question>
            {
                new Question("Какой океан самый глубокий?", "Тихий"),
                new Question("Столица Франции?", "Париж"),
                new Question("Какой элемент обозначается символом O?", "Кислород"),
                new Question("Кто написал 'Войну и мир'?", "Толстой"),
                new Question("Сколько дней в феврале в высокосный год?", "29")
            };

            int score = 0;
            foreach (var question in quiz)
            {
                Console.WriteLine(question.Text);
                string userAnswer = Console.ReadLine()?.Trim();

                if (string.Equals(userAnswer, question.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Правильно!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Неправильно! Правильный ответ: {question.Answer}");
                }
            }

            Console.WriteLine($"Ваш итоговый балл: {score} из {quiz.Count}");
        }
    }
}