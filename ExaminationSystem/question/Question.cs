
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
        public List<string> Choices { get; set; }
        public List<int> AnswerIndexes { get; set; }
        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        public abstract List<int> Display();
        public abstract List<int> CorrectAnswer();
    }
}
