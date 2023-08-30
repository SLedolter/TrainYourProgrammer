using System;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      Range range = new Range();

      range.GetPoints();
      range.CalculateDistance();
    }
  }

  public class Range {
    Point p1, p2;

    public Range() { }

    public void GetPoints() {
      p1 = GetCoordinates("1");
      p2 = GetCoordinates("2");
    }

    public void CalculateDistance() {
      float result;

      result = (float)Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));

      Console.WriteLine($"Range: {result}");
    }

    private Point GetCoordinates(string label) {
      Point result;

      result.x = GetInteger($"x{label}: ");
      result.y = GetInteger($"y{label}: ");


      return result;
    }

    private int GetInteger(string label) {
      int result;

      Console.Write(label);
      while(!int.TryParse(Console.ReadLine(), out result)) {
        Console.WriteLine("Nur Integer!");
        Console.Write(label);
      }

      return result;
    }
  }

  public struct Point {
    public int x, y;
  }
}
