using System;
using ConsoleLibrary;

namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      int startValue, endValue;

      startValue = Console2k.ReadInt("Startwert: ");
      endValue = Console2k.ReadInt("Endwert: ");

      Console.WriteLine();
      DisplayValues(startValue, endValue);
    }

    static void DisplayValues(int start, int end) {
      for(int i = start; i <= end; i++) {
        Console.WriteLine(i);
      }
    }
  }
}
