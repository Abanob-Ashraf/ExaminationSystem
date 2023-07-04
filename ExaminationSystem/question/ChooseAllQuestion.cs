using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class ChooseAllQuestion : Question
    {
        public List<string> Choices { get; set; }
        public List<int> AnswerIndexes { get; set; }

        public ChooseAllQuestion(string _header, string _body, int _mark, List<string> _choices, List<int> _answerIndexes) : base(_header, _body, _mark)
        {
            Choices = _choices;
            AnswerIndexes = _answerIndexes;
        }

        public override void Display()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");

            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            };

            Console.WriteLine($"mark: {Mark}");
            List<int> x = new List<int>();

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

                if (!x.Contains(studentAnswer) && studentAnswer != 0)
                {
                    x.Add(studentAnswer);
                }else { i--; }

                if (input.ToLower() == "ok")
                {
                    break;
                }
            }
            for (int j = 0; j < x.Count; j++)
            {
                Console.WriteLine("test"+ x[j]);
            }
        }

        public override void CorrectAnswer()
        {
            for (int i = 0; i < Choices.Count; i++)
            {
                if (AnswerIndexes.Contains(i))
                {
                    Console.WriteLine(Choices[i]);

                }
            }
        }
    }
}
