
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
        public int NumberOfQuestions { get; set; }
        public List<List<int>> ModelAnswers { get; set; } = new List<List<int>>();
        public List<List<int>> UserAnswers { get; set; } = new List<List<int>>();
        public QuestionList Questions { get; set; }

        public Exam(QuestionList questions)
        {
            Questions = questions;
            NumberOfQuestions = questions.ReadQuestions().Count;
        }

        public abstract void ShowExam();
        public void CloseExam()
        {
            int userMarks = 0;
            for (int i = 0; i < Questions.ReadQuestions().Count; i++)
            {
                if (UserAnswers[i].Count > 1)
                {
                    UserAnswers[i].Sort();
                    ModelAnswers[i].Sort();
                }
                if (UserAnswers[i].SequenceEqual(ModelAnswers[i]))
                {
                    userMarks += Questions.ReadQuestions()[i].Mark;
                }
            }
            Console.WriteLine($"Your total Marks is {userMarks}");
        }
    }
}
