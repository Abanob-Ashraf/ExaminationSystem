using ExaminationSystem.question;
using ExaminationSystem.subject;
using System.Runtime.Serialization;
using System.Transactions;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject.TakeExam();

            //QuestionList questions = new QuestionList("frontEnd.log");

            //questions.Add(new TrueFalseQuestion("TrueFalseQuestion", "Are HTML and CSS programming Language?", 2, false));
            //questions.Add(new ChooseOneQuestion("ChooseOneQuestion", "Which tag is used to define the main Heading of HTML?", 5, new List<string> { "h1", "head", "title" }, 1));
        }
    }
}