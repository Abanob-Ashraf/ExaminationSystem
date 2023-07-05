using ExaminationSystem.answer;
using ExaminationSystem.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.exam
{
    public abstract class Exam
    {
        //public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        //public Dictionary<Question, Answer> QuestionAnswerDictionary { get; set; }

        public QuestionList Questions { get; set; }

        public Exam(QuestionList questions)
        {
            Questions = questions;
            NumberOfQuestions = questions.ReadQuestions().Count;
        }

        public abstract void ShowExam();
    }
}
