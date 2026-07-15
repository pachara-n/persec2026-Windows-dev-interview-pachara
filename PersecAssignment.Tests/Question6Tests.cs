namespace PersecAssignment.Tests
{
  public class Question6Tests
  {
    [Fact]
    public void Tribonacci_ShouldReturnCorrectSequence()
    {
      var question6 = new Question6();

      int[] sig1 = { 1, 3, 5 };
      int[] expected1 = { 1, 3, 5, 9, 17 };
      Assert.Equal(expected1, question6.Tribonacci(sig1, 5));

      int[] sig2 = { 2, 2, 2 };
      int[] expected2 = { 2, 2, 2 };
      Assert.Equal(expected2, question6.Tribonacci(sig2, 3));

      int[] sig3 = { 10, 10, 10 };
      int[] expected3 = { 10, 10, 10, 30 };
      Assert.Equal(expected3, question6.Tribonacci(sig3, 4));
    }
  }
}