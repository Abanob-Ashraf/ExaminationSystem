﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class ChooseOneQuestion : Question
    {
        public List<string> Choices { get; set; }
        public int AnswerIndex { get; set; }

        public ChooseOneQuestion(string header, string body, int mark, List<string> choices, int answerIndex) : base(header, body, mark)
        {
            Choices = choices;
            AnswerIndex = answerIndex;
        }

        public override void Display()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");

            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Choices[i]}");
            };

            Console.WriteLine($"mark: {Mark}");

            int studentAnswer;
            string input;
            do
            {
                Console.Write("Your choice: or type ok to skip ");
                input = Console.ReadLine();
                if ((int.TryParse(input, out studentAnswer)) && (studentAnswer <= Choices.Count && studentAnswer != 0))
                {
                    break;
                }
            } while (input.ToLower() != "ok");

            Console.WriteLine("_______________________________________________________________________________________________");
        }

        public override void CorrectAnswer()
        {
            string trueChoice = "";
            for (int i = 0; i < Choices.Count; i++)
            {
                if (AnswerIndex == i)
                {
                    trueChoice =  Choices[i];
                }
            };
            Console.WriteLine(trueChoice);
            Console.WriteLine("_______________________________________________________________________________________________");
        }
    }
}
