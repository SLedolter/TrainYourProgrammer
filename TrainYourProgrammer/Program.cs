using System;

namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      string raw_input;
      int parsed_int;

      do {
        Console.Write("Bitte eine ganze Zahl eingeben: ");
        raw_input = Console.ReadLine();
      } while(!int.TryParse(raw_input, out parsed_int));
      Console.WriteLine("Danke! Und tschüss...");
    }
  }
}
