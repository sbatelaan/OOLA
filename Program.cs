using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
        // Creating a new profile object named 'sam' with the provided information
      Profile sam = new Profile("Sam Drakkila", 30, "NewYork", "USA", "he/him");
      // setting the hobbies for the 'sam' profile using an array of strings
      sam.SetHobbies(new string[] {
        "listening to audiobooks and podcasts",
        "playing rec sports like bowling and kickball",
        "writing a speculative fiction novel",
        "reading advice columns"
      });

      Console.WriteLine(sam.ViewProfile());
        
    }
  }
}

