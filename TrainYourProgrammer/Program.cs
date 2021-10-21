﻿using System;

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
            CreateTreeInConsole(treeHeight);
            Console.ReadKey();
            Console.Clear();
          }
        }
      }
    }

    static void CreateTreeInConsole(int wantedTreeBlocks) {
      int possibleHeight = CalculatePossibleHeightDependingOnWindowSize(wantedTreeBlocks);
      int possibleTreeBlocks = (possibleHeight - 1) / 3;

      Console.WriteLine($"Fenstergröße: {Console.WindowWidth}x{Console.WindowHeight}, CursorTop: {Console.CursorTop}, Höhe: {wantedTreeBlocks}/{possibleTreeBlocks}, Benötigte Zeilen: {wantedTreeBlocks * 3 + 1}/{possibleHeight}");

      for(int currentHeight = 1; currentHeight <= possibleTreeBlocks; currentHeight++) {
        DrawSingleTreeBlock(currentHeight, 20);
      }
    }

    static int CalculatePossibleHeightDependingOnWindowSize(int blockCount) {
      int calculatedRows = blockCount * 3 + 1;

      while(calculatedRows > Console.WindowHeight) {
        calculatedRows -= 3;
      }

      return calculatedRows;
    }

    static void DrawSingleTreeBlock(int blockNumber, int columnMidPoint) {
      for(int i = blockNumber-1; i < blockNumber; i++) {
        for(int row = 0; row < blockHeight; row++) {
          string star = new string('*', (blockNumber-1)*2+(1+2*row));
          Console.WriteLine(star);
        }
      }
    }

    static string GetUserInputWithPrompt(string prompt) {
      string result;

      Console.Write(prompt);
      result = Console.ReadLine();

      return result;
    }
  }
}
