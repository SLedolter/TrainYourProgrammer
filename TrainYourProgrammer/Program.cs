using System;

namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      Niederschlag niederschlag = new Niederschlag();
    }
  }

  public class Niederschlag {
    public int[] monatsWerte = new int[12];

    public Niederschlag() {
    }

    public double DurchschnittBerechnen(int vonMonat, int bisMonat) {
      int count = bisMonat - vonMonat;
      int summe = 0;

      for(int i = vonMonat-1; i<= bisMonat-1; i++) {
        summe += monatsWerte[i];
      }
      return summe/count;
    }
  }
}