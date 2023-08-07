using System;

namespace ReverseTheCase
{
  class Program
  {
    // Examples of input and output
    // ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
    // ReverseCase("MANY THANKS") ➞ "many thanks"
    // ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
    static void Main(string[] args)
    {
      Console.WriteLine("Enter string:");
      string input = Console.ReadLine();
      ReverseCase(input);
    }

    public static void ReverseCase(string input)
    {
      char[] charArray = input.ToCharArray();
      foreach (var character in charArray)
      {
        if (char.IsUpper(character))
        {
          Console.Write(char.ToLower(character));
        }
        else
        {
          Console.Write(char.ToUpper(character));
        }
      }
    }
  }
}
