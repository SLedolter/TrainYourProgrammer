using System;
using System.Diagnostics;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      BadFridays bF = new BadFridays();

      bF.GetDates();
      bF.FindBadFridays();
    }
  }

  public class BadFridays {
    public DateTime startDate;
    public DateTime endDate;

    public BadFridays() { }

    public void GetDates() {
      Console.Write("Startdatum: ");

      startDate = ReadAndParseDate("Startdatum: ");
      endDate = ReadAndParseDate("Enddatum: ");
    }

    private DateTime ReadAndParseDate(string label) {
      DateTime result;

      Console.Write(label);
      while (!DateTime.TryParse(Console.ReadLine(), out result)) {
        Console.WriteLine("Falsches Datumsformat!");
        Console.Write(label);
      }

      return result;
    }

    public void FindBadFridays() {
      int badDayCount = 0;

      for (DateTime current = startDate; current <= endDate; current = current.AddDays(1)) {
        if (current.DayOfWeek == DayOfWeek.Friday && current.Day == 13) {
          Console.WriteLine(current.ToLongDateString());
          badDayCount++;
        }
      }

      Console.WriteLine($"Summe: {badDayCount}");
    }
  }
}