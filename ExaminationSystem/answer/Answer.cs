using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.answer
{
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class AnswerList : List<Answer> 
    {

    }
}
