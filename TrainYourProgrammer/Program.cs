using System;
using System.Collections.Generic;

namespace TrainYourProgrammer {
  class Program {
    static List<double> zahlenliste1, zahlenliste2;

    static void Main(string[] args) {
      zahlenliste1 = LiesZahlenInListeEin();
      zahlenliste2 = LiesZahlenInListeEin();

      BerechneUndZeigeDurchschnitt("Zahlenliste1", zahlenliste1);
      BerechneUndZeigeDurchschnitt("Zahlenliste2", zahlenliste2);
    }

    static List<double> LiesZahlenInListeEin() {
      List<double> result = new List<double>();
      double parsed_double;
      string input;

      Console.WriteLine("Bitte eine Zahl eingeben, Abbruch mit 'stop'");
      while((input = Console.ReadLine()) != "stop") {
        if(double.TryParse(input, out parsed_double)) {
          result.Add(parsed_double);
        } else {
          Console.WriteLine("Bitte nur Zahlen eingeben!!!");
        }
      }

      return result;
    }

    static void BerechneUndZeigeDurchschnitt(string name_liste, List<double> zahlenListe) {
      double summe = 0;
      double result;

      for(int i = 0; i < zahlenListe.Count; i++) {
        summe += zahlenListe[i];
      }
      result = summe / zahlenListe.Count;

      Console.WriteLine($"Der Durchschnitt der {name_liste}ist: {result}");
    }
  }
}
