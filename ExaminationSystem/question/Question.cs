using ExaminationSystem.answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Question(string _header, string _body, int _mark) 
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
        }
        public abstract void Display();
        public abstract void CorrectAnswer();
    }
}
