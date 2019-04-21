using System;
namespace getUser
{
   
}
class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FaveAnimal { get; set; }
    public string FaveSport { get; set; }
    public string FaveNumber { get; set; }
}

public string AnswerQuestion(string question)
{
    Console.WriteLine($"Hello {FirstName}, could you answer a few questions: ");
    Console.WriteLine(question);
    return Console.ReadLine();
}

public  int AnswerQuestionWithInteger (string question)
{
    string stringAnswer = AnswerQuestion(question);
    return int.Parse(stringAnswer);
}