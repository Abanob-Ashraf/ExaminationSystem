using ExaminationSystem.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.exam
{
    public class FinalExam : Exam
    {
        public QuestionList Questions { get; set; }

        public FinalExam(QuestionList _questions) : base(_questions)
        {
            Questions = _questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Number of Questions: {Questions.ReadQuestions().Count}");
            foreach (var question in Questions.ReadQuestions())
            {
                question.Display();
            }
        }
    }
}
