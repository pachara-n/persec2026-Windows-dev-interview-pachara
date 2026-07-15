namespace PersecAssignment.Tests
{
  public class Question3Tests
  {
    [Fact]
    public void Autocomplete_ShouldReturnCorrectItemsAndLimitResult()
    {
      var question3 = new Question3();
      string search = "th";
      string[] items = new string[] { "Mother", "Think", "Worthy", "Apple", "Android"};
      int maxResult = 2;

      string[] expect = new string[] { "Think", "Mother" };
      string[] actual =question3.Autocomplete(search, items, maxResult);

      Assert.Equal(expect, actual);
    }
  }
}