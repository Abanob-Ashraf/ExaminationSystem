using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string header, string body, int mark, List<string> choices, List<int> answerIndexes) : base(header, body, mark)
        {
            Choices = choices;
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

            for (int i = 0; i < Choices.Count; i++)
            {

                int studentAnswer = 0;
                string input;
                do
                {
                    Console.Write("Your choice: or type ok to skip ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "ok")
                    {
                        break;
                    }
                } while (!((int.TryParse(input, out studentAnswer)) && (studentAnswer <= Choices.Count && studentAnswer != 0)));

                if (input.ToLower() == "ok")
                {
                    break;
                }
                else if (!studentAnswerList.Contains(studentAnswer - 1) && studentAnswer != 0)
                {
                    studentAnswerList.Add(studentAnswer - 1);
                }
                else { i--; }
            }
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
