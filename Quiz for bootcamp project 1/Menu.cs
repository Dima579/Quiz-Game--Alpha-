using System;
using System.Security.Cryptography.X509Certificates;
using static Quiz_for_bootcamp_project_1.QuestionSheet;
using static Quiz_for_bootcamp_project_1.QuestionGameMethod1;
using static Quiz_for_bootcamp_project_1.AnswerMethods;
using Quiz_for_bootcamp_project_1;

public class Menu
{
    public static object Public { get; private set; }

    public static void Main()
    {
        
        String menuOptions = ($"1)START \n2)EXIT");

        Console.WriteLine("State your name");
        String UsersName =Console.ReadLine();

    Console.WriteLine($"welcome! {UsersName} the menu is as follows: \n{menuOptions} \nplease type either the choice name or the number by the choice. Or type MENU to get the options again");
        String userMenuInput = Console.ReadLine();

        while (userMenuInput != "EXIT")
        {
            switch (userMenuInput)
            {
                case "START":
                    Console.WriteLine("you are starting the game");
                    GameStart(QuestionSheet.Q1, QuestionSheet.Q1.answers);
                    break;
                case "EXIT":
                    //Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
                case "MENU":
                    Console.WriteLine(menuOptions);
                    userMenuInput = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    userMenuInput = Console.ReadLine();
                    break;
            }
        }
        Console.WriteLine("Goodbye");
    }
}