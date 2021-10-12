using System;

namespace TrainYourProgrammer {
  class Program {
    static void Main(string[] args) {
      double[]
        array1 = new double[] { 1, 3, 4, 6, 8, 13, 45, 78, 90 },
        array2 = new double[] { 11, 23, 34, 46, 58, 613, 745, 878, 990, 1000, 10001 },
        array3;

      array3 = FusioniereZweiDoubleArrays(array1, array2);

      ZeigeArray(array1);
      ZeigeArray(array2);
      ZeigeArray(array3);
    }

    static double[] FusioniereZweiDoubleArrays(double[] array1, double[] array2) {
      double[] result = new double[array1.Length + array2.Length];

      for(int i = 0; i < array1.Length; i++) {
        result[i] = array1[i];
      }

      for(int i = array1.Length; i < array1.Length + array2.Length; i++) {
        result[i] = array2[i - array1.Length];
      }
      return result;
    }

    static void ZeigeArray(double[] array_in) {
      Console.Write("[");
      for(int i = 0; i < array_in.Length; i++) {
        Console.Write(array_in[i]);
        if(i < array_in.Length - 1) {
          Console.Write(", ");
        }
      }
      Console.WriteLine("]");
    }
  }
}