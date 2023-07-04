﻿using ExaminationSystem.exam;
using ExaminationSystem.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.subject
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Subject() { }
        public Subject(string _subjectName) 
        {
            SubjectName = _subjectName;
        }

        public void takeExam() 
        {
            Subject subject = new Subject();
            int studentAnswer;
            string input;
            do
            {
                Console.WriteLine("choose your Subject exam 1 for FrontEnd and 2 for BackEnd or OK to exit");

                input = Console.ReadLine();
                if ((int.TryParse(input, out studentAnswer)) && (studentAnswer == 1 || studentAnswer == 2))
                {
                    break;
                }
            } while (input.ToLower() != "ok");

            if (studentAnswer == 1)
            {
                subject = new Subject("frontEnd");
            }
            else if (studentAnswer == 2)
            {
                subject = new Subject("backEnd");
            }
            subject.CreateExam();
            subject.Exam.ShowExam();

        }
        public void CreateExam()
        {
            QuestionList questions = new QuestionList($"{SubjectName}.log");

            int studentAnswer;
            string input;
            do
            {
                Console.WriteLine("choose your type of exam 1 for Practice and 2 for Final or OK to exit");

                input = Console.ReadLine();
                if ((int.TryParse(input, out studentAnswer)) && (studentAnswer == 1 || studentAnswer == 2))
                {
                    break;
                }
            } while (input.ToLower() != "ok");

            if (studentAnswer == 1)
            {
                Exam = new PracticeExam(questions);
            }
            else if (studentAnswer == 2)
            {
                Exam = new FinalExam(questions);
            }
        }
    }
}