namespace PersecAssignment.Tests
{
  public class Question2Tests
  {
    [Fact]
    public void SortArray_ShouldReturnSortArray()
    {
      var question2 = new Question2();
      Assert.Equal(new string[] { "SG20", "TH2", "TH19" },
            question2.ReturnSortArray(new string[] { "TH19", "SG20", "TH2" }));
      Assert.Equal(new string[] { "TH1", "TH3Netflix", "TH7", "TH10" },
            question2.ReturnSortArray(new string[] { "TH10", "TH3Netflix", "TH1", "TH7" }));

    }
  }
}