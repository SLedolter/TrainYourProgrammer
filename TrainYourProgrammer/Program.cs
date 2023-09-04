using System;
using System.Text.RegularExpressions;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      CaesarCrypt caes = new CaesarCrypt();
      caes.GetPlainText();
      caes.GetEncryptionIndex();
      caes.Encrypt();
    }
  }

  public class CaesarCrypt {
    string input;
    int encryptionIndex;

    readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public CaesarCrypt() { }

    public void GetPlainText() {
      Console.Write("Geben Sie den Text ein: ");
      input = Console.ReadLine();

      while(!Regex.IsMatch(input, @"^[a-zA-z]+$")) {
        Console.WriteLine("Nur pure Buchstaben ohne Sonderzeichen!");
        Console.Write("Geben Sie den Text ein: ");
        input = Console.ReadLine();
      }
    }

    public void GetEncryptionIndex() {
      Console.Write("Um wie viele Stellen soll verschoben werden: ");
      while (!int.TryParse(Console.ReadLine(), out encryptionIndex)) {
        Console.WriteLine("Ganze Zahl!");
        Console.Write("Um wie viele Stellen soll verschoben werden: ");
      }
    }

    public void Encrypt() {
      string result = "";
      string toBeEncrypted = input;

      for (int i = 0; i < input.Length; i++) {
        int newIndex = (alphabet.IndexOf(Char.ToUpper(toBeEncrypted[i])) + encryptionIndex) % 26;

        result = result.Insert(result.Length,
          (char.IsUpper(toBeEncrypted[i]) ? char.ToUpper(alphabet[newIndex]) : char.ToLower(alphabet[newIndex])).ToString());
    }

    Console.WriteLine($"Ergebnis: {result}");
    }
}
}
