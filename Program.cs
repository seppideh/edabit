using System;

namespace MyConsoleApp
{
  // pair summation of input numbers
  // input:2 4 5 6  ===> output: 6 11
  // input:2 4 5 6 9 ===> output: 6 11 9
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter numbers:");
      string input = Console.ReadLine();

      string[] tokens = input.Split(' ');

      List<int> numbers = new List<int>();

      foreach (string token in tokens)
      {
        int number = Convert.ToInt32(token);
        numbers.Add(number);
      }

      List<int> sumList = new List<int>();
      var length = numbers.Count;

      for (int i = 0; i < length; i++)
      {
        if (length % 2 != 0 && i == length - 1)
        {
          sumList.Add(numbers[i]);
        }
        else
        {
          var num1 = numbers[i];
          var num2 = numbers[i + 1];
          var sum = num1 + num2;
          i++;
          sumList.Add(sum);
        }
      }
      foreach (var item in sumList)
      {
        Console.Write(item + " ");
      }


      // if (length % 2 != 0)
      // {
      //   length = length - 1;
      // }
      // for (int i = 0; i < length; i++)
      // {
      //   var num1 = numbers[i];
      //   var num2 = numbers[i + 1];
      //   var sum = num1 + num2;
      //   i++;
      //   sumList.Add(sum);
      // }

      // foreach (var item in sumList)
      // {
      //   Console.Write(item + " ");
      // }

      // if (numbers.Count % 2 != 0)
      // {
      //   Console.WriteLine(numbers[length]); ;
      // }

    }
  }
}
