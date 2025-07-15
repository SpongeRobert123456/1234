using System;

namespace CSharp {
  class Program {
    static void Main(string[] args) {
      Answer theTruth = new Answer();
      
      Console.WriteLine("What is in the alphabet");

      string userInput = Console.ReadLine();
      if (userInput.Equals(theTruth.correctAnswer, StringComparison.CurrentCultureIgnoreCase)) {
        Console.WriteLine("Correct");
      } else {
        Console.WriteLine("Wrong");
      }
    }
  }
  class Answer {
    public string correctAnswer = "Letters";
  }
}
