using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_for_bootcamp_project_1
{
    public class AnswerMethods()
    {
        public static int userHighScore = 0;

        public static void AnswerValidator(string uAInput, string answers)
        {
            if (uAInput == answers)
            {
                Console.WriteLine("Correct! +10 point for you!");
                userHighScore += 10;
            }
            else
            {
                Console.WriteLine("Incorrect! -10 point.");
                userHighScore -= 10;
            }
        }
    }
}
