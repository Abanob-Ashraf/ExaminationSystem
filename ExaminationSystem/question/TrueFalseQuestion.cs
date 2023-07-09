using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, List<int> answerIndexes) : base(header, body, mark)
        {
            Choices = new List<string> { "True", "False" };
            AnswerIndexes = answerIndexes;
        }
        public override List<int> Display()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");

            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            };

            Console.WriteLine($"mark: {Mark}");

            List<int> studentAnswerList = new List<int>();
            int studentAnswer;
            string input;
            do
            {
                Console.Write("Your answer: 1 for ture - 2 for false or Ok to skip ");
                input = Console.ReadLine();
                if ((int.TryParse(input, out studentAnswer)) && (studentAnswer == 1 || studentAnswer == 2))
                {
                    break;
                }
            } while (input.ToLower() != "ok");
            studentAnswerList.Add(studentAnswer - 1);
            Console.WriteLine("_______________________________________________________________________________________________");
            return studentAnswerList;
        }

        public override List<int> CorrectAnswer()
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < Choices.Count; i++)
            {
                if (AnswerIndexes.Contains(i))
                {
                    answer.Add(i);
                }
            }
            return answer;
        }
    }
}
