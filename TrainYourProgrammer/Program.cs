using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      RomanDigits romDig = new RomanDigits();

      Console.Write("Geben Sie eine Zahl ein: ");
      romDig.CalculateNumber(Console.ReadLine());
    }
  }

  public class RomanDigits {
    Dictionary<char, int> values;

    public RomanDigits() {
      values = new Dictionary<char, int>() {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
      };
    }

    public void CalculateNumber(string number) {
      int decimalNumber = 0;
      if (int.TryParse(number, out decimalNumber)){
        CalculateRomanNumber(decimalNumber);
      } else {
        CalculateDecimalNumber(number);
      }
    }

    private void CalculateDecimalNumber(string number) {
      throw new NotImplementedException();
    }

    private void CalculateRomanNumber(int number) {
      var valueOrder = values.OrderByDescending(x => x.Value).ToList();
      string result;

      int ones, tens, hundreds, thousands;
      ones = number % 10;
      tens = (number % 100 - ones)/10;
      hundreds = (number % 1000)/100;
      thousands = (number % 10000)/1000;

      Console.WriteLine($"{thousands}-{hundreds}-{tens}-{ones}");

      result = new string('M', thousands);

      if (hundreds == 9) {
        result += "CM";
      } else if (hundreds == 4) {
        result += "CD";
      } else {
        if (hundreds > 5) {
          result += "D";
          hundreds -= 5;
        }
        result += new string('C', hundreds);
      }

      if (tens == 9) {
        result += "XC";
      } else if (tens == 4) {
        result += "XL";
      } else {
        if (tens > 5) {
          result += "L";
          tens -= 5;
        }
        result += new string('X', tens);
      }

      if (ones == 9) {
        result += "IX";
      } else if (ones == 4) {
        result += "IV";
      } else {
        if (ones > 5) {
          result += "V";
          ones -= 5;
        }
        result += new string('I', ones);
      }

      Console.WriteLine(result);
    }

    private string UseSubtractionRule(string subResult) {
      return subResult + "-";
    }
  }
}