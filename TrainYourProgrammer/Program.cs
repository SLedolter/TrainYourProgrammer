using System;

namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      string userInput;
      int treeHeight;

      while((userInput = GetUserInputWithPrompt("Höhe des Weihnachtsbaum in Zeilen eingeben: ")) != "exit") {
        if(!int.TryParse(userInput, out treeHeight)) {
          Console.WriteLine("Nur Zahlen, bitte!");
        } else {
          if(treeHeight <= 3) {
            Console.WriteLine("Babybäume dürfen erst ab einer Höhe von 3 verarbeitet werden!");
          } else {
            CreateTreeInConsole(treeHeight);
          }
        }
      }
    }

    static string GetUserInputWithPrompt(string prompt) {
      string result;

      Console.Write(prompt);
      result = Console.ReadLine();

      return result;
    }

    static void CreateTreeInConsole(int wantedHeight) {
      int currentConsoleHeight = Console.WindowHeight, currentConsoleWidth = Console.WindowWidth;
      int neededRows = (wantedHeight * 3) + 1, realRowCount = neededRows;

      while(realRowCount > (currentConsoleHeight - Console.CursorTop) {
        realRowCount -= 3;
      }
      Console.WriteLine($"Fenstergröße: {currentConsoleWidth}x{currentConsoleHeight}, CursorTop: {Console.CursorTop}, Höhe: {wantedHeight}, Benötigte Zeilen: {neededRows}/{realRowCount}");
    }
  }
}
