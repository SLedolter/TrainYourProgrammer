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

    [InlineData(new int[12] { 1, 1, 1, 12, 14, 8, 1, 1, 1, 1, 1, 1 }, 11.33333333)]
    [InlineData(new int[12] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 3)]
    [InlineData(new int[12] { 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12 }, 12)]
    [InlineData(new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 5)]
    [Theory]
    public void Theory_Durchschnitt(int [] array_in, int estimatedValue) {
      Niederschlag niederschlag = new Niederschlag();
      niederschlag.monatsWerte = array_in;

      Assert.Equal(estimatedValue, niederschlag.DurchschnittBerechnen(4, 6));
    }
  }
} 