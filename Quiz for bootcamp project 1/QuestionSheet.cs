using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_for_bootcamp_project_1
{
    public class QuestionSheet
    {
        public string questions;
        public string answers;

        public QuestionSheet(string questions, string answers)
        {
            this.questions = questions;
            this.answers = answers;
        }

        public static List<QuestionSheet> Qs = new();

        public static QuestionSheet Q1 = new QuestionSheet("What's 2+2?", "4");
        public static QuestionSheet Q2 = new QuestionSheet("What's 5X3?", "15");
        public static QuestionSheet Q3 = new QuestionSheet("What fruit is orange and round?", "ORANGE");
        public static QuestionSheet Q4 = new QuestionSheet("What animal barks?", "DOG");
        public static QuestionSheet Q5 = new QuestionSheet("What is the name of the IDE that this program was written in?", "VISUAL STUDIO");

        public static QuestionSheet Q6 = new QuestionSheet("What's 4%40?", "10");
        public static QuestionSheet Q7 = new QuestionSheet("What continent does France belong to?", "EUROPE");
        public static QuestionSheet Q8 = new QuestionSheet("What country does spaghetti come from?", "ITALY");
        public static QuestionSheet Q9 = new QuestionSheet("True or False: A blueberry is blue", "TRUE");
        public static QuestionSheet Q10 = new QuestionSheet("The colours of the british flag have blue white and?", "RED");

        public static void AddQuestionList()
        {
            Qs.Add(Q1);
            Qs.Add(Q2);
            Qs.Add(Q3);
            Qs.Add(Q4);
            Qs.Add(Q5);
            Qs.Add(Q6);
            Qs.Add(Q7);
            Qs.Add(Q8);
            Qs.Add(Q9);
            Qs.Add(Q10);
        }

        public static void Qpresent(List<QuestionSheet> Qs, string uAInput, string answers, string questions)
        {
            foreach (QuestionSheet Q in Qs)
            {
                Console.WriteLine(Q.questions);
                uAInput = Console.ReadLine();
                AnswerMethods.AnswerValidator(uAInput, Q.answers);
            }
            QuestionGameMethod1.EndGame();
        }

    }
}
