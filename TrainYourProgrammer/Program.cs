using System;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      Calculator calc = new Calculator();

      calc.GetInput();
    }
  }

  public class Calculator {
    float number1, number2;
    char operator1;

    public Calculator() { }

    public void GetInput() {
      number1 = GetNumber("Erste Zahl: ");
      operator1 = GetOperator("Operator: ");
      number2 = GetNumber("Zweite Zahl: ");
    }

    private char GetOperator(string label) {
      string result;

      Console.Write(label);
      while(!IsOperator(result = Console.ReadLine())) {
        Console.WriteLine("Muss regulärer Operator sein (+,-,*,/)");
      }

      return result[0];
    }

    private bool IsOperator(string input) {
      if(input == "+" || input == "-" || input == "*" || input == "/") {
        return true;
      }
      
      return false;
    }

    private float GetNumber(string label) {
      float result;

      Console.Write(label);
      while(!float.TryParse(Console.ReadLine(), out result)) {
        Console.WriteLine("Float eingeben!");
        Console.Write(label);
      }

      return result;
    }
  }
}
