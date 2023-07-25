using System;
using System.Collections.Generic;
using ConsoleLibrary;


namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      VocalCounter vocalCount = new VocalCounter();

      vocalCount.ReadSentence();
      vocalCount.ScanForVocals();
      vocalCount.PrintResult();
    }
  }

  class VocalCounter {
    readonly char[] charMap = new char[5] { 'a', 'e', 'i', 'o', 'u' };

    private string enteredSentence;
    Dictionary<char, int> vocalCounts;
    int vocalSum;

    public VocalCounter() {
      BuildVocalCountDict();
      vocalSum = 0;
    }

    private void BuildVocalCountDict() {
      vocalCounts = new Dictionary<char, int>();
      for (int i = 0; i < charMap.Length; i++ ) {
        vocalCounts[charMap[i]] = 0;
      }
    }

    public void ReadSentence() {
      Console.WriteLine("Geben Sie einen Satz ein:");
      enteredSentence = Console.ReadLine();
    }

    public void ScanForVocals() {
      string lowerCaseString = enteredSentence.ToLower();
      for(int i = 0; i < charMap.Length; i++) {
        int 
          lastIndex = 0,
          newIndex = -1;
        do {
          newIndex = enteredSentence.IndexOf(charMap[i], lastIndex);
          if (newIndex  == -1)
            break;
          lastIndex = newIndex + 1;
          vocalCounts[charMap[i]]++;
          vocalSum++;
        } while (newIndex != -1);
      }
    }
    public void PrintResult() {
      Console.WriteLine($"Anzahl der Vokale: {vocalSum}");
      PrintVocalCountDict();
    }

    private void PrintVocalCountDict() {
      foreach(KeyValuePair<char, int> entry in vocalCounts) {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
      }
    }
  }
}
