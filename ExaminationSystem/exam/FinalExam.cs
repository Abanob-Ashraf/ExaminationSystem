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
        public FinalExam(QuestionList questions) : base(questions)
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
        }
    }
}
