using System;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      NumberGuessing numberGuesser = new NumberGuessing();

      numberGuesser.SetBounds();

      do {
        numberGuesser.GuessNumber();
      } while (!numberGuesser.NumberFound);
    }
  }

  class NumberGuessing {
    int targetNumber;
    int lastGuess;

    Random rand = new Random();

    private int lowerBounds, upperBounds;
    private int tries;
    private bool numberFound;
    public bool NumberFound { get { return numberFound; } }

    const string MSG_ONLY_NUMBERS = "Bitte nur Z A H L E N eingeben.";

    public NumberGuessing() { }

    public void Initialize() {
      this.lowerBounds = -1;
      this.upperBounds = -1;
      tries = 0;
      numberFound = false;
    }

    public void SetBounds() {
      lowerBounds = Console2k.ReadInt($"Bitte die Untergrenze wählen: ");
      upperBounds = Console2k.ReadInt($"Bitte die Obergrenze wählen: ");
      SetRandomNumber();
    }

    public void SetRandomNumber() {
      targetNumber = rand.Next(lowerBounds, upperBounds);
    }

    public void GuessNumber() {
      tries++;
      int input;
      input = Console2k.ReadInt($"Ihr {tries.ToString("D2")} Versuch ({targetNumber}): ");

      if (input == lastGuess) {
        Console.WriteLine("Zahl schon gewählt!");
        // list mit multi result?
      } else if (input < lowerBounds || input > upperBounds) {
        Console.WriteLine("Die Zahl muss innerhalb der Grenzen liegen!");
      } else {
        lastGuess = input;
      }

      if (input == targetNumber) {
        numberFound = true;
        Console.WriteLine($"Glückwunsch die von Ihnen eingegebene Zahl ({input}) stimmt mit {targetNumber} überein!");
      }
    }
  }
}