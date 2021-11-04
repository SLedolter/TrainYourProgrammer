using TrainYourProgrammer;
using Xunit;

namespace TrainYourProgrammerTests {
  public class UnitTest1 {
    [Fact]
    public void Test_Durchschnitt_1() {
      Niederschlag niederschlag = new Niederschlag();

      niederschlag.monatsWerte = new int[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
      Assert.Equal(1, niederschlag.DurchschnittBerechnen(1, 12));
    }


  }
}
