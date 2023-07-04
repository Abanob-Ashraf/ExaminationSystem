using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class ChooseAllQuestion //: Question
    {
        public List<string> Choices { get; set; }
        public List<int> AnswerIndexes { get; set; }

        //public ChooseAllQuestion(string _header, string _body, int _mark, List<string> _choices, List<int> _answerIndexes) //: base(_header, _body, _mark)
        //{
        //    Choices = _choices;
        //    AnswerIndexes = _answerIndexes;
        //}

        //public override void Display()
        //{
        //    Console.WriteLine($"Header: {Header}");
        //    Console.WriteLine($"Body: {Body}");
        //    Console.WriteLine($"mark: {Mark}");

        //    Console.WriteLine("Choices (Choose more than one):");
 
        //    for (int i = 0; i < Choices.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. {Choices[i]}");
        //    };

        //    int studentAnswer;
        //    foreach (int i in AnswerIndexes)
        //    {
        //        do
        //        {
        //            Console.Write("Your choice:  ");
        //        } while (int.TryParse(Console.ReadLine(), out studentAnswer) == false);
        //    }
            
        //}
    }
}
