using ExaminationSystem.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.exam
{
    public class PracticeExam : Exam
    {
        public PracticeExam(QuestionList questions) : base(questions)
        {
            Questions = questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");

            foreach (var question in Questions.ReadQuestions())
            {
                question.Display();
            }

            Console.WriteLine("Model Answer");
            Console.WriteLine("______________");
            foreach (var question in Questions.ReadQuestions())
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                foreach (var correctAnswer in question.CorrectAnswer())
                {
                    Console.WriteLine($"{correctAnswer + 1}. {question.Choices[correctAnswer]}");
                }
                ModelAnswers.Add(question.AnswerIndexes.ToList());
                Console.WriteLine("___________________________________________");

            }
            Console.WriteLine(ModelAnswers.Count);
        }
    }
}
