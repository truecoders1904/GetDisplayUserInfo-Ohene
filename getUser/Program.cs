using System;

namespace getUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine($"Hello stranger, I have a few  questions for you: ");

            user.FirstName = user.AnswerQuestion("What is your first name?");
            user.LastName = user.AnswerQuestion("What is your last name?");
            user.FaveAnimal = user.AnswerQuestion("What is your favorite animal?");
            user.FaveSport = user.AnswerQuestion("What is your favorite sport?");
            user.FaveNumber = user.AnswerQuestionWithInteger("What is your favorite number?");

            Console.WriteLine($"Hello {user.FirstName} {user.LastName}.");
            Console.WriteLine($"Your favorite animal is a {user.FaveAnimal}.");
            Console.WriteLine($"Your favorite sport is {user.FaveSport}.");
            Console.Write($"And your favorite number is");

            if(user.FaveNumber < 5 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" {user.FaveNumber}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else if (user.FaveNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($" {user.FaveNumber}");
                Console.ForegroundColor = ConsoleColor.White;


            }

         
     

            //MISSING IF STATEMENTS FOR FAVORITE NUMBER
            //NEED TO INCLUDE COLORs
        }

    }
}

