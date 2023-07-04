using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class TrueFalseQuestion : Question
    {
        public bool TrueOrFalse { get; set; }

        public TrueFalseQuestion(string _header, string _body, int _mark, bool _trueOrFalse) : base(_header, _body, _mark)
        {
            TrueOrFalse = _trueOrFalse;
        }

        public override void Display()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"mark: {Mark}");

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
            Console.WriteLine("_______________________________________________________________________________________________");
        }

        public override void CorrectAnswer()
        {
            Console.WriteLine(TrueOrFalse.ToString());
            Console.WriteLine("_______________________________________________________________________________________________");
        }

    }
}
