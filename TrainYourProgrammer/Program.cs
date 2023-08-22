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
    Dictionary<string, string> subtractedValues;

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

      subtractedValues = new Dictionary<string, string>() {
        { "CM", "DCCCC" },
        { "CD", "CCCC" },
        { "XC", "LXXXX" },
        { "XL", "XXXX" },
        { "IX", "VIIII" },
        { "IV", "IIII" }
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

    public void CalculateDecimalNumber(string number) {
      int result = 0;

      number = RemoveSubstractionRule(number);

      for(int i = 0; i < number.Length; i++) {
        result += values[number[i]];
      }

      Console.WriteLine(result);
    }

    private string RemoveSubstractionRule(string number) {
      string result = number;

      foreach(var entry in subtractedValues) {
        result = result.Replace(entry.Key, entry.Value);
      }

      return result;
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

      result += UseSubtractionRuleToRoman(hundreds, "MDC");
      result += UseSubtractionRuleToRoman(tens, "CLX");
      result += UseSubtractionRuleToRoman(ones, "XVI");

      Console.WriteLine(result);
    }

    private string UseSubtractionRuleToRoman(int value, string romanDigits) {
      if (romanDigits.Length != 3)
        throw new ArgumentException("Roman numbers exception");

      string result = ""; 
      if (value == 9) {
        result = romanDigits[2].ToString()+romanDigits[0].ToString();
      } else if (value == 4) {
        result = romanDigits[2].ToString() + romanDigits[1].ToString();
      } else {
        if (value >= 5) {
          result = romanDigits[1].ToString();
          value -= 5;
        }
        result += new string(romanDigits[2], value);
      }
      return result;
    }
  }
}