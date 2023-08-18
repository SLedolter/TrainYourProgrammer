﻿using System;
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
      int count = 0;
      int calcNumber = number;
      string result = "";
      char lastKey = ' ';

      foreach(var entry in valueOrder) {
        if (calcNumber > values[entry.Key]) {
          string subResult = "";
          count = calcNumber / values[entry.Key];
          if(count == 4 && entry.Key != 'M') {
             subResult = entry.Key.ToString() + lastKey;
          } else {
            subResult = new string(entry.Key, count);
          }
          calcNumber -= values[entry.Key] * count;
          lastKey = entry.Key;
          result += subResult;
        }
      }

      Console.WriteLine(result);
    }
  }
}