using System;

namespace getUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.FirstName = user.AnswerQuestion("What is your first name?");
            user.LastName = user.AnswerQuestion("What is your last name?");
            user.FaveAnimal = user.AnswerQuestion("What is your favorite animal?");
            user.FaveSport = user.AnswerQuestion("What is your favorite sport?");
            user.FaveNumber = user.AnswerQuestion("What is your favorite number?");

            Console.WriteLine($"Hello {user.FirstName} {user.LastName}.");
            Console.WriteLine($"Your favorite animal is a {user.FaveAnimal}.");
            Console.WriteLine($"Your favorite sport is {user.FaveSport}.");
            Console.WriteLine($"And your favorite number is {user.FaveNumber}.");
            //MISSING IF STATEMENTS FOR FAVORITE NUMBER
            //NEED TO INCLUDE COLORs
        }

    }
}

