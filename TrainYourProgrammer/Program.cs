using System;

namespace TrainYourProgrammer {
  class Program {
    const string c_prompt_label = "Eingabe: ";
    const string c_commando_exit = "exit";
    static void Main(string[] args) {
      string userInput;

      while((userInput = ShowUserInputPrompt(c_prompt_label)).ToLower() != c_commando_exit) {
        switch(userInput) {
          case "calc":
            Console.WriteLine("Result: "+ReadTwoNumbersAndMultiply());
            break;

          default:
            Console.WriteLine("Kommando nicht gefunden!");
            break;
        }
      }
    }

    static string ShowUserInputPrompt(string promptLabel) {
      Console.Write(promptLabel);
      return Console.ReadLine();
    }

    static int ReadTwoNumbersAndMultiply() {
      string userInput;
      int parsedInteger1, parsedInteger2;
      int result;

      while(!int.TryParse((userInput=ShowUserInputPrompt("First number: ")), out parsedInteger1)) {
        Console.WriteLine("Only integer numbers!");
      }
      while(!int.TryParse((userInput = ShowUserInputPrompt("Second number: ")), out parsedInteger2)) {
        Console.WriteLine("Only integer numbers!");
      }

      result = 0;
      for(int i = 1; i <= parsedInteger1; i++) {
        result += parsedInteger2;
      }

      return result;
    }
  }
}