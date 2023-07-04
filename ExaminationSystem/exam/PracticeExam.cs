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
        public QuestionList Questions { get; set; }

        public PracticeExam(QuestionList _questions) : base(_questions)
        {
            Questions = _questions;
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
