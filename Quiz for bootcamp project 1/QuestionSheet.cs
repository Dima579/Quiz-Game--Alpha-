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

        public static QuestionSheet Q1 = new QuestionSheet("What's 2+2?", "4");
        public static QuestionSheet Q2 = new QuestionSheet("What's 5X3?", "15");
        public static QuestionSheet Q3 = new QuestionSheet("What fruit is orange and round?", "ORANGE");
        public static QuestionSheet Q4 = new QuestionSheet("What animal barks?", "DOG");
        public static QuestionSheet Q5 = new QuestionSheet("What is the name of the IDE that this program was written in?", "C#");

        //QuestionSheet Q6 = new QuestionSheet("What's 4%40?", "10");
        //QuestionSheet Q7 = new QuestionSheet("What continent does France belong to?", "FRANCE");
        //QuestionSheet Q8 = new QuestionSheet("What country does spaghetti come from?", "ITALY");
        //QuestionSheet Q9 = new QuestionSheet("True or False: A blueberry is blue", "TRUE");
        //QuestionSheet Q10 = new QuestionSheet("The colours of the british flag have blue white and?", "RED");
        
    }


    public class AnswerMethods() 
    {

        public int finalScore;

        public static String uAInput = Console.ReadLine();
        public static int userHighScore = 0;

        public static string UserAnswerIput() 
        { 
        String uAInput =Console.ReadLine();
    
            return uAInput;
        }


        public static void AnswerValidator(String uAInput, string answers)
        {
            if (uAInput == answers)
            {
                Console.WriteLine("Correct! +10 point for you!");
                userHighScore=+10;
            }
            else
            {
                Console.WriteLine("Incorrect! -10 point.");
                userHighScore=-10;
            }
        }

        /*public static int AddPoints(int userHighScore)
        {
            userHighScore++;
            return userHighScore;
        }

        public static int RemovePoints(int userHighScore)
        {
            userHighScore--;
            return userHighScore;
        }

        */
    }
}
