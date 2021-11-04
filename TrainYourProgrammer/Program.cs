using System;

namespace TrainYourProgrammer {
  class Program {
    static int blockHeight = 3;

    static void Main(string[] args) {
      string userInput;
      int treeHeight;

      while((userInput = GetUserInputWithPrompt("Höhe des Weihnachtsbaum in Zeilen eingeben: ")) != "exit") {
        if(!int.TryParse(userInput, out treeHeight)) {
          Console.WriteLine("Nur Zahlen, bitte!");
        } else {
          if(treeHeight <= 3) {
            Console.WriteLine("Babybäume dürfen erst ab einer Höhe von 4 verarbeitet werden!");
          } else {
            DrawTreeInConsole(treeHeight);
            Console.ReadKey();
            Console.Clear();
          }
        }
      }
    }

    static void DrawTreeInConsole(int wantedTreeBlocks) {
      int possibleHeight = CalculatePossibleHeightDependingOnWindowSize(wantedTreeBlocks);
      int possibleTreeBlocks = (possibleHeight - 1) / 3;
      int columnMidpoint = (int)Math.Ceiling(Decimal.Divide(CalculateMaximumTreeWidth(possibleTreeBlocks), 2));

      Console.WriteLine($"Fenstergröße: {Console.WindowWidth}x{Console.WindowHeight}, CursorTop: {Console.CursorTop}, Höhe: {wantedTreeBlocks}/{possibleTreeBlocks}, Benötigte Zeilen: {wantedTreeBlocks * 3 + 1}/{possibleHeight}");

      for(int currentHeight = 1; currentHeight <= possibleTreeBlocks; currentHeight++) {
        DrawSingleTreeBlock(currentHeight, columnMidpoint);
      }
      Console.SetCursorPosition(columnMidpoint - 3 / 2, Console.CursorTop);
      Console.WriteLine("###");
    }


    static void DrawSingleTreeBlock(int blockNumber, int columnMidPoint) {
      int oldConsoleTop = Console.CursorTop, oldConsoleLeft = Console.CursorLeft;
      for(int i = blockNumber - 1; i < blockNumber; i++) {
        for(int row = 0; row < blockHeight; row++) {
          string star = new string('*', (blockNumber - 1) * 2 + (1 + 2 * row));
          Console.SetCursorPosition(columnMidPoint - star.Length / 2, Console.CursorTop);
          Console.WriteLine(star);
        }
      }
    }

    static int CalculatePossibleHeightDependingOnWindowSize(int blockCount) {
      int calculatedRows = blockCount * 3 + 1;

      while(calculatedRows > Console.WindowHeight) {
        calculatedRows -= 3;
      }

      return calculatedRows;
    }

    static int CalculateMaximumTreeWidth(int blockCount) {
      int result;

      result = 1 + (blockCount - 1) * 2 + (blockHeight - 1) * 2;

      return result;
    }

    static string GetUserInputWithPrompt(string prompt) {
      string result;

      Console.Write(prompt);
      result = Console.ReadLine();

      return result;
    }
  }
}