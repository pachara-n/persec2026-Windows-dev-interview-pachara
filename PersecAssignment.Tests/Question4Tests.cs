namespace PersecAssignment.Tests
{
  public class Question4Tests
  {
    [Fact]
    public void IntToRoman_ShouldConvertCorrectly()
    {
      var question4 = new Question4();

      Assert.Equal("MCMLXXXIX", question4.IntToRoman(1989));
      Assert.Equal("MM", question4.IntToRoman(2000));
      Assert.Equal("LXVIII", question4.IntToRoman(68));
      Assert.Equal("CIX", question4.IntToRoman(109));
    }
  }
}