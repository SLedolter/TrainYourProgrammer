using System;

namespace TrainYourProgrammer {
  class Program {
    const string TEXT_SCREW_COUNT = "Anzahl der Schrauben:";
    const string TEXT_NUT_COUNT = "Anzahl der Muttern: ";
    const string TEXT_WASHER_COUNT = "Anzahl der Beilagscheiben: ";

    const int PRICE_SCREW = 5;
    const int PRICE_NUT = 3;
    const int PRICE_WASHER = 1;

    static void Main(string[] args) {
      int screw_count, nut_count, washer_count;
      string command = "";
      int result;
      
      do {
        Console.WriteLine(TEXT_SCREW_COUNT);
        screw_count = GetIntegerFromConsole(Console.ReadLine());
        Console.WriteLine(TEXT_NUT_COUNT);
        nut_count = GetIntegerFromConsole(Console.ReadLine());
        Console.WriteLine(TEXT_WASHER_COUNT);
        washer_count = GetIntegerFromConsole(Console.ReadLine());
        Console.WriteLine();
        if (screw_count < nut_count) {
          Console.WriteLine("Die Bestellung ist ok!");
        } else {
          Console.WriteLine("Bitte kontrollieren Sie ihre Bestellung!");
        }
        Console.WriteLine();
        result = (PRICE_SCREW * screw_count) + (PRICE_NUT * nut_count) + (PRICE_WASHER * washer_count);
        Console.WriteLine($"Gesamtbetrag: {result}");
        Console.WriteLine();
      } while (command != "exit");
    }

    static int GetIntegerFromConsole(string input) {
      int result = 0;

      if (int.TryParse(input, out _)) {
        result = int.Parse(input);
      } else {
        result = -1;
      }

      return result;
    }
  }
}
