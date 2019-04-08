using System;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
    private Random rng;
    private int wins;
    private int losses;
    private int ties;

    public RockPaperScissorsGame()
    {
        rng = new Random();

    }
    public void Play()
    {
         string userChoice;
        userChoice = PromptUser();
    }
    private string PromptUser()
    {
        while(true)
        {
     Console.WriteLine("Enter ,R, for rock ,P, for paper, and ,S, for scissors or ,Q,for quit");
        string choice = Console.ReadLine();

        if (choice == "R" || choice == "P" || choice == "S" || choice == "Q")
        {
            return choice;
        }
        else
        {
            Console.WriteLine("That was not a valid choice!");
        
        }         
      }
    }
  }
}
