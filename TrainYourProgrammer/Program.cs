using System;

namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      int input;
      int euro, cent;
      string command = "";

      do {
        Console.WriteLine("Geben Sie die Cent ein: ");
        command = Console.ReadLine();

        if(int.TryParse(command,out _)) {
          input = int.Parse(command);
          euro = input / 100;
          cent = input - (euro * 100);
          Console.WriteLine($"Das ergibt {euro} Euro und {cent} Cent.\n");
        }

      } while (command != "exit");
    }
  }
}
