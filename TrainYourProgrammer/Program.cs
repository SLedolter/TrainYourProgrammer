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
            Console.ReadKey();
            Console.Clear();
          }
        }
      }
    }

    static void CreateTreeInConsole(int wantedHeight) {
      
    }

    static void DrawSingleTreeBlock(int blockNumber, int columnMidPoint) {

    }

    static string GetUserInputWithPrompt(string prompt) {
      string result;

      Console.Write(prompt);
      result = Console.ReadLine();

      return result;
    }
  }
}
