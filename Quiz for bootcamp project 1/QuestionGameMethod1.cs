﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quiz_for_bootcamp_project_1.QuestionSheet;
using static Quiz_for_bootcamp_project_1.AnswerMethods;
using Quiz_for_bootcamp_project_1;
using System.Security.Cryptography.X509Certificates;


namespace Quiz_for_bootcamp_project_1
{
    public class QuestionGameMethod1

    {

             public static void GameStart(QuestionSheet Q1, string answers)
            {
                Console.WriteLine($"Please note: Write ALL answer in capital letters \nSTARTING GAME...");
                Thread.Sleep(3000);
                Console.WriteLine("Game starts in 3...");
                Thread.Sleep(1500);
                Console.WriteLine("Game starts in 2...");
                Thread.Sleep(1500);
                Console.WriteLine("Game starts in 1...");
                Thread.Sleep(1500);
                Console.WriteLine("START!");

             Q1Present(Q1, answers);

            }

             public static void Q1Present(QuestionSheet Q1, string answers)
            {
                Console.WriteLine(Q1.questions);
                string UserAnswerIput;
                AnswerValidator(uAInput, answers);
                EndGame();
            }

             static void EndGame()
            {
                Console.WriteLine($"game has ended! \nYou got {userHighScore}!");
                if (userHighScore == 50) {
                    Console.WriteLine("Great Job!");
                }

                Console.WriteLine("if you want to try again, please restart the program");
                System.Environment.Exit(0);
            }
        }
        }
      

