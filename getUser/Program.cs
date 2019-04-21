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
        }
    }
}

