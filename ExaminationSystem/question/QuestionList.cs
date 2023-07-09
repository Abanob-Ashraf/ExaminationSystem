using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.question
{
    public class QuestionList : List<Question>
    {
        private string FilePath { get; set; }
        public bool FileLocated { get; set; }

        public QuestionList(bool fileLocated)
        {
            
            FileLocated = fileLocated;
        }

        public QuestionList(string filePath, bool fileLocated = true)
        {
            FileLocated = fileLocated;
            FilePath = filePath;
        }

        public new void Add(Question question)
        {
            if(FileLocated)
            {
                LogQuestion(question);
            }
            base.Add(question);
        }

        private void LogQuestion(Question question)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine($"Header: {question.Header}");
                sw.WriteLine($"Body: {question.Body}");
                sw.WriteLine($"Marks: {question.Mark}");

                if (question is TrueFalseQuestion tfq)
                {
                    sw.WriteLine($"Choices: {string.Join(", ", tfq.Choices)}");
                    sw.WriteLine($"AnswerIndexes: {string.Join(", ", tfq.AnswerIndexes)}");
                }

                else if (question is ChooseOneQuestion coq)
                {
                    sw.WriteLine($"Choices: {string.Join(", ", coq.Choices)}");
                    sw.WriteLine($"AnswerIndexes: {string.Join(", ", coq.AnswerIndexes)}");
                }

                else if (question is ChooseAllQuestion caq)
                {
                    sw.WriteLine($"Choices: {string.Join(", ", caq.Choices)}");
                    sw.WriteLine($"AnswerIndexes: {string.Join(", ", caq.AnswerIndexes)}");
                }
                sw.WriteLine("____________________________________________________");
            }
        }

        public QuestionList ReadQuestions()
        {
            QuestionList questionList = new QuestionList(false);

            using (TextReader reader = new StreamReader(FilePath)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Header: "))
                    {
                        string header = line.Substring("Header: ".Length);
                        string body = reader.ReadLine().Substring("Body: ".Length);
                        int marks = int.Parse(reader.ReadLine().Substring("Marks: ".Length));

                        if (header == "TrueFalseQuestion")
                        {
                            List<string> Choices = reader.ReadLine().Substring("Choices: ".Length).Split(", ").ToList();
                            List<int> answerIndexes = reader.ReadLine().Substring("AnswerIndexes: ".Length).Split(", ").Select(int.Parse).ToList();
                            Question trueFalseQuestion = new TrueFalseQuestion(header, body, marks, answerIndexes);
                            questionList.Add(trueFalseQuestion);
                        }
                        else if (header == "ChooseOneQuestion")
                        {
                            List<string> Choices = reader.ReadLine().Substring("Choices: ".Length).Split(", ").ToList();
                            List<int> answerIndexes = reader.ReadLine().Substring("AnswerIndexes: ".Length).Split(", ").Select(int.Parse).ToList();
                            Question chooseOneQuestion = new ChooseOneQuestion(header, body, marks, Choices, answerIndexes);
                            questionList.Add(chooseOneQuestion);
                        }
                        else if (header == "ChooseAllQuestion")
                        {
                            List<string> Choices = reader.ReadLine().Substring("Choices: ".Length).Split(", ").ToList();
                            List<int> answerIndexes = reader.ReadLine().Substring("AnswerIndexes: ".Length).Split(", ").Select(int.Parse).ToList();
                            Question chooseAllQuestion = new ChooseAllQuestion(header, body, marks, Choices, answerIndexes);
                            questionList.Add(chooseAllQuestion);
                        }
                    }
                }
                reader.Close();
            }
            return questionList;
        }
    }
}
