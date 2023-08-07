using System;

namespace ArrayOfMultiple 
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter two integer numbers:");
      string input = Console.ReadLine();
      string[] inputArray = input.Split(" ");
      int num = Convert.ToInt32(inputArray[0]);
      int length = Convert.ToInt32(inputArray[1]);

      List<int> numbers = ArrayOfMultiples(num, length);
      foreach (var number in numbers)
      {
        Console.Write(number + " ");
      }
    }
    public static List<int> ArrayOfMultiples(int num, int length)
    {
      List<int> numbers = new List<int>();
      for (int i = 0; i < length; i++)
      {
        int number = (i + 1) * num;
        numbers.Add(number);
      }
      return numbers;
    }
  }
}
