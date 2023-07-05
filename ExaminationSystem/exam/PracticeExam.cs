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

            foreach (var question in Questions.ReadQuestions())
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                question.CorrectAnswer();
            }
        }
    }
}
