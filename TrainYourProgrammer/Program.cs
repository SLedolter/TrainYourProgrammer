using System;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      string input;
      Console.WriteLine("Geben Sie ein Wort ein:");
      input = Console.ReadLine();
      Console.WriteLine();

      for(int i = input.Length; i > 0; i--) {
        Console.WriteLine(input);
      }
    }
  }
}
